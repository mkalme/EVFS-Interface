using System;

namespace EncryptedVirtualFileSystem
{
    public class EVFS
    {
        public Key Key { get; set; }
        public VDirectory RootDirectory { get; set; }

        public EVFS(Key key) {
            Key = key;
            RootDirectory = new VDirectory("Root");
        }

        public byte[] SaveToBytes() {
            byte[] bytes = RootDirectory.SaveToBytes().ToArray();

            bytes = AES.Encrypt(bytes, Key);

            return bytes;
        }
        public static EVFS FromBytes(byte[] bytes, Key key) {
            EVFS evfs = new EVFS(key);

            bytes = AES.Decrypt(bytes, key);
            int index = 0;

            evfs.RootDirectory = VDirectory.LoadFromBytes(bytes, ref index);

            return evfs;
        }
    }
}
