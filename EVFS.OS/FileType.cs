using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Drawing;

namespace EVFS.OS {
    public class FileType {
        public string Type { get; set; }
        public string Description { get; set; }
        public Program DefaultProgram { get; set; }
        public List<Program> SupportedPrograms { get; set; }
        public Image Icon { get; set; }

        public static FileType Parse(JToken token, EVFSManager manager) {
            FileType type = new FileType();

            type.Type = token["Type"].ToString();
            type.Description = token["Description"].ToString();
            if (token["DefaultProgram"].Type != JTokenType.Null) {
                type.DefaultProgram = manager.AllPrograms[token["DefaultProgram"].ToString()];
            }
            type.SupportedPrograms = new List<Program>();
            type.Icon = Image.FromFile(manager.Path + @"\Icons\" + token["Icon"].ToString());

            return type;
        }
    }
}
