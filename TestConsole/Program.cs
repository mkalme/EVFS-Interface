using System;
using System.Collections.Generic;
using EncryptedVirtualFileSystem;
using EVFS.OS;
using FileExplorer;

namespace TestConsole {
    class Program {
        private static string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\EVFS Interface";
        private static Key Key = new Key(new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5 });

        [STAThread]
        static void Main(string[] args)
        {
            EVFSManager manager = EVFSManager.FromDirectory(Path, Key);

            manager.CallStartupPrograms();

            Console.ReadLine();
        }

        private static void PrintArray(byte[] array) {
            Console.Write(" ");

            for (int i = 0; i < array.Length; i++) {
                byte b = array[i];

                Console.Write(b);

                if (b < 10) Console.Write("   ");
                else if (b > 9 && b < 100) Console.Write("  ");
                else Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}
