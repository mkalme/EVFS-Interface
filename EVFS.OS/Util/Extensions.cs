using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncryptedVirtualFileSystem;
using System.Drawing;
using System.IO;

namespace EVFS.OS {
    public static class VFileExtensions {
        public static Image GetIcon(this VFile file) {
            string ext = Path.GetExtension(file.Name);

            return Image.FromFile("");
        }
        public static void LaunchDefaultProgram(this VFile file, EVFSManager manager) {
            string ext = Path.GetExtension(file.Name);
            if (!string.IsNullOrEmpty(ext)) {
                ext = ext.Substring(1, ext.Length - 1).ToLower();
            }

            FileType type;
            if (manager.AllFileTypes.TryGetValue(ext, out type)) {
                FileProgram program = (FileProgram)type.DefaultProgram;

                if (program != null) {
                    program.Launch(file);
                }
            }
        }
    }
}
