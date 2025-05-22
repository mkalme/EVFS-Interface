using System;
using System.Security.Cryptography;
using System.IO;

namespace EncryptedVirtualFileSystem {
    public class AES {
        public static byte[] Encrypt(byte[] input, Key key) {
            byte[] encrypted;

            using (Aes aes = Aes.Create()) {
                aes.Key = key.Bytes;
                aes.GenerateIV();

                using (var encrypter = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var cipherStream = new MemoryStream()) {
                    using (var tCryptoStream = new CryptoStream(cipherStream, encrypter, CryptoStreamMode.Write))
                    using (var tBinaryWriter = new BinaryWriter(tCryptoStream)) {
                        cipherStream.Write(aes.IV, 0, aes.IV.Length);
                        tBinaryWriter.Write(input);
                        tCryptoStream.FlushFinalBlock();
                    }

                    encrypted = cipherStream.ToArray();
                }
            }

            return encrypted;
        }

        public static byte[] Decrypt(byte[] input, Key key) {
            byte[] decrypted;

            using (var aes = new AesCryptoServiceProvider()) {
                var iv = new byte[16];
                Array.Copy(input, 0, iv, 0, iv.Length);

                using (var ms = new MemoryStream()) {
                    using (var cs = new CryptoStream(ms, aes.CreateDecryptor(key.Bytes, iv), CryptoStreamMode.Write))
                    using (var binaryWriter = new BinaryWriter(cs)) {
                        binaryWriter.Write(
                            input,
                            iv.Length,
                            input.Length - iv.Length
                        );
                    }

                    decrypted = ms.ToArray();
                }
            }

            return decrypted;
        }
    }
}
