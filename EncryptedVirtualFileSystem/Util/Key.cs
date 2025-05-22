using System;

namespace EncryptedVirtualFileSystem {
    public class Key {
        private byte[] _bytes;
        public byte[] Bytes { get { return _bytes; }}

        public static readonly int RequiredLength = 16;

        public Key() {
            _bytes = new byte[RequiredLength];
        }
        public Key(byte[] bytes) {
            SetKey(bytes);
        }

        public void SetKey(byte[] bytes) {
            if (bytes.Length == RequiredLength) {
                _bytes = bytes;
            }
        }
    }
}
