using System;
using EVFS.OS;
using System.Windows.Forms;

namespace Program
{
    public class Program
    {
        public static void Invoke(EVFSManager manager) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new FileExplorer.FileExplorerWindow(manager, manager.FileSystem.RootDirectory).ShowDialog();
        }
    }
}
