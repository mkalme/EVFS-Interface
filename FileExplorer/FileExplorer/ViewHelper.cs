using System;
using System.Globalization;
using System.Drawing;
using EVFS.OS;
using EncryptedVirtualFileSystem;

namespace FileExplorer {
    class ViewHelper {
        private static Random Random = new Random();
        private static CultureInfo CultureInfoES = new CultureInfo("en-EN");

        public static Image GetDirectoryIcon(VDirectory dir) {
            if (dir.GetCountOfSubFiles() > 0) {
                return Properties.Resources.FolderFiles;
            } else if(dir.ContainsDirectories()){
                return Properties.Resources.FolderBundle;
            }

            return Properties.Resources.Folder;
        }
        public static string GetTypeDescription(EVFSManager manager, VFile file) {
            string ext = System.IO.Path.GetExtension(file.Name);
            if (ext == "") return "File";
            ext = ext.Substring(1, ext.Length - 1).ToLower();

            FileType type;
            if (manager.AllFileTypes.TryGetValue(ext, out type)) return type.Description;

            return ext.ToUpper() + " File";
        }
        public static string ParseDate(DateTime time) {
            //DateTime time1 = DateTime.Parse("01.01.2018");
            //time = time1.AddMinutes(Random.Next((int)(DateTime.Now - time1).TotalMinutes));

            return time.ToString("dd.MM.yyyy HH:mm");
        }
        public static string ParseSize(int length) {
            string[] suffix = { "Bytes", "KB", "MB", "GB" };

            //int pow = (int)Math.Pow(1024, Random.Next(3));
            //length = Random.Next(pow * 1024); 

            uint exponent = (uint)Math.Log(length, 1024);
            exponent = exponent > 3 ? 3 : exponent;
            double units = Math.Pow(1024, exponent);

            return string.Format("{0} {1}", DoFormat(length / units), suffix[exponent]);
        }
        
        private static string DoFormat(double value)
        {
            var s = string.Format("{0:0.00}", value);

            if (s.EndsWith("00")) {
                return ((int)value).ToString();
            } else {
                return s;
            }
        }
        public static string ParseFormat(int value) {
            if (value < 1024) return "";
            return string.Format("({0:n0} bytes)", value);
        }

        public static string GetPath(VDirectory directory, string suff = " > ") {
            if (directory == null) return "";
            string path = directory.Name;

            VDirectory currentDir = directory;
            while (currentDir.Parent != null) {
                path = currentDir.Parent.Name + suff + path;

                currentDir = currentDir.Parent;
            };

            return path;
        }
        public static string GetExtension(string name)
        {
            string ext = System.IO.Path.GetExtension(name);
            if (ext == "") return "File";
            ext = ext.Substring(1, ext.Length - 1).ToLower();

            return ext;
        }

        public static string ParseDateReadable(DateTime time) {
            return time.ToString("dddd, MMMM dd, yyyy, HH:mm:ss", CultureInfoES);
        }
    }
}
