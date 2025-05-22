using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using EncryptedVirtualFileSystem;
using Newtonsoft.Json.Linq;
using System.Drawing;

namespace EVFS.OS
{
    public class EVFSManager {
        public string Path { get; set; }
        public string SystemPath { get; set; }
        public EncryptedVirtualFileSystem.EVFS FileSystem { get; set; }

        public Dictionary<string, Program> AllPrograms { get; set; }
        public Dictionary<string, FileType> AllFileTypes { get; set; }
        public List<Program> StartupPrograms { get; set; }
        public VItem ClipBoard { get; set; }

        public static readonly string DEF_FILENAME = "file.evfs";

        public void Save() {
            byte[] bytes = FileSystem.SaveToBytes();

            File.WriteAllBytes(Path + @"\Files\" + DEF_FILENAME, bytes);
        }
        public Image GetFileIcon(VFile file) {
            return IconManager.IconReader.GetFileIcon(file.Name, IconManager.IconSize.Large).ToBitmap();
            
            string ext = System.IO.Path.GetExtension(file.Name);
            if (ext == "") return Properties.Resources.FileIcon;
            ext = ext.Substring(1, ext.Length - 1).ToLower();

            FileType type;
            if (AllFileTypes.TryGetValue(ext, out type)) {
                return type.Icon;
            } else {
                return Properties.Resources.FileIcon;
            }
        }
        public Image GetTypeIcon(FileType type) {
            if (type == null) return Properties.Resources.FileIcon;
            else return type.Icon;
        }

        public static EVFSManager FromDirectory(string directory, Key key) {
            if (!Directory.Exists(directory)) return null;
            if (!File.Exists(directory + @"\Files\" + DEF_FILENAME)) return null;

            EVFSManager manager = new EVFSManager();
            manager.Path = directory;
            manager.SystemPath = directory + @"\Files\" + DEF_FILENAME;
            manager.FileSystem = EncryptedVirtualFileSystem.EVFS.FromBytes(File.ReadAllBytes(manager.SystemPath), key);

            LoadAllPrograms(manager);
            LoadAllFileTypes(manager);
            InitializeSupportedFileTypes(manager);
            InitializeStartupPrograms(manager);

            return manager;
        }

        private static void LoadAllPrograms(EVFSManager manager) {
            manager.AllPrograms = new Dictionary<string, Program>();

            string path = manager.Path + @"\Programs";
            if (Directory.Exists(path)) {
                string[] directories = Directory.GetDirectories(path);

                foreach (string programPath in directories) {
                    Program program = Program.FromDirectory(programPath);

                    if (program != null) {
                        program.Manager = manager;

                        manager.AllPrograms.Add(program.FolderPath, program);
                    }
                }
            }
        }
        private static void LoadAllFileTypes(EVFSManager manager) {
            manager.AllFileTypes = new Dictionary<string, FileType>();

            string path = manager.Path + @"\FileTypeList\TypeList.json";
            if (File.Exists(path)) {
                JObject jo = JObject.Parse(File.ReadAllText(path));

                JToken objects = jo["Types"];

                foreach (var token in objects) {
                    FileType type = FileType.Parse(token, manager);

                    manager.AllFileTypes.Add(type.Type, type);
                }
            }
        }
        private static void InitializeSupportedFileTypes(EVFSManager manager) {
            for (int i = 0; i < manager.AllPrograms.Count; i++) {
                Program program = manager.AllPrograms.ElementAt(i).Value;

                if (program.GetType() == typeof(FileProgram)) {
                    FileProgram fileProgram = (FileProgram)program;

                    for (int b = 0; b < fileProgram.SupportedTypes.Length; b++) {
                        FileType type = manager.AllFileTypes[fileProgram.SupportedTypes[b]];

                        type.SupportedPrograms.Add(fileProgram);
                    }
                }
            }
        }
        private static void InitializeStartupPrograms(EVFSManager manager) {
            manager.StartupPrograms = new List<Program>();

            string path = manager.Path + @"\StartupPrograms.json";
            if (File.Exists(path)) {
                JObject jo = JObject.Parse(File.ReadAllText(path));

                JToken objects = jo["StartupPrograms"];

                foreach (var token in objects) {
                    manager.StartupPrograms.Add(manager.AllPrograms[token.ToString()]);
                }
            }
        }
        public void CallStartupPrograms() {
            for (int i = 0; i < StartupPrograms.Count; i++) {
                StartupPrograms[i].Launch();
            }
        }
    }
}