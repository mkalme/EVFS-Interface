using System;
using EncryptedVirtualFileSystem;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace EVFS.OS {
    public class FileProgram : Program {
        public string[] SupportedTypes { get; set; }

        public void Launch(VFile file) {
            Assembly = Assembly.LoadFile(Manager.Path + @"\Programs\" + FolderPath + @"\" + Path);

            AssemblyHelper.Launch(Assembly, new object[] { Manager, file });
        }

        public static new FileProgram Parse(JToken obj, string directory) {
            Program program = Program.Parse(obj, directory);

            FileProgram fileProgram = new FileProgram();
            
            fileProgram.Path = program.Path;
            fileProgram.Icon = program.Icon;
            fileProgram.Version = program.Version;

            fileProgram.Name = program.Name;
            fileProgram.Description = program.Description;

            fileProgram.FolderPath = program.FolderPath;

            fileProgram.SupportedTypes = JsonConvert.DeserializeObject<string[]>(obj["SupportedTypes"].ToString());

            return fileProgram;
        }
    }
}
