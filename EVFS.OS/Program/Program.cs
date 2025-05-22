using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace EVFS.OS {
    public class Program {
        public EVFSManager Manager { get; set; }
        public Assembly Assembly { get; set; }

        public string Path { get; set; }
        public Image Icon { get; set; }
        public string Version { get; set; }

        public string FolderPath { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void Launch() {
            Assembly = Assembly.LoadFile(Manager.Path + @"\Programs\" + FolderPath + @"\" + Path);

            AssemblyHelper.Launch(Assembly, new object[] { Manager });
        }

        public static Program FromDirectory(string directory)
        {
            if (!Directory.Exists(directory)) return null;
            if (!File.Exists(directory + @"\Description.json")) return null;

            JObject jo = JObject.Parse(File.ReadAllText(directory + @"\Description.json"));

            string type = jo["Type"].ToString();
            if (type == "file") {
                return FileProgram.Parse(jo["Program"], directory);
            } else{
                return Parse(jo["Program"], directory);
            }
        }

        public static Program Parse(JToken obj, string directory) {
            Program program = new Program();

            program.Path = obj["Path"].ToString();
            program.Icon = Image.FromFile(directory + @"\" + obj["Icon"].ToString());
            program.Version = obj["Version"].ToString();

            program.Name = obj["Name"].ToString();
            program.Description = obj["Description"].ToString();

            program.FolderPath = System.IO.Path.GetFileName(directory);

            return program;
        }
    }
}
