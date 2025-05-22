using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace EncryptedVirtualFileSystem {
    public class VFile : VItem, INotifyPropertyChanged {
        private DateTime _lastModified;
        public DateTime LastModified {
            get { return _lastModified; }
            set {
                if (_lastModified != value) {
                    _lastModified = value;
                    OnPropertyChanged("LastModified");
                }
            }
        }
        private byte[] _bytes;
        public byte[] Bytes {
            get { return _bytes; }
            set {
                if (_bytes != value) {
                    _bytes = value;
                    OnPropertyChanged("Bytes");
                }
            }
        }

        public VFile(string name) : base(name) {
            _lastModified = DateTime.Now;
            _bytes = new byte[0];
        }

        public override List<byte> SaveToBytes() {
            List<byte> bytes = new List<byte>() { 1 };

            bytes.AddRange(GetHeaderBytes());
            bytes.AddRange(BitConverter.GetBytes(LastModified.Ticks));
            bytes.AddRange(BitConverter.GetBytes(Bytes.Length));
            bytes.AddRange(Bytes);

            return bytes;
        }
        public static new VFile LoadFromBytes(byte[] bytes, ref int index) {
            index++;

            string name = LoadHelper.GetName(bytes, ref index);
            DateTime creationDate = LoadHelper.GetDate(bytes, ref index);
            DateTime lastModified = LoadHelper.GetDate(bytes, ref index);

            int size = BitConverter.ToInt32(bytes, index);
            index += 4;

            byte[] payload = new byte[size];
            Array.Copy(bytes, index, payload, 0, size);
            index += size;

            return new VFile(name) {
                CreationDate = creationDate,
                LastModified = lastModified,
                Bytes = payload
            };
        }

        public override VItem Clone() {
            VFile file = new VFile(Name);
            
            file.CreationDate = CreationDate;
            file.LastModified = LastModified;
            file.Bytes = (byte[])Bytes.Clone();
            file._parent = _parent;

            return file;
        }

        public override int GetSize() {
            return Bytes.Length;
        }
    }
}
