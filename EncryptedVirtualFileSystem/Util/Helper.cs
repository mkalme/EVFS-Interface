using System;
using System.Text;

namespace EncryptedVirtualFileSystem {
    class LoadHelper {
        public static string GetName(byte[] bytes, ref int index) {
            byte length = bytes[index];
            index++;

            string name = Encoding.UTF8.GetString(bytes, index, length);
            index += length;

            return name;
        }
        public static DateTime GetDate(byte[] bytes, ref int index) {
            long ticks = BitConverter.ToInt64(bytes, index);
            index += 8;

            return new DateTime(ticks);
        }
    }
}
