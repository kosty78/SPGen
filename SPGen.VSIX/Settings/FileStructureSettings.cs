
using System.IO;
using EnvDTE;
using SPGen.VSIX.Extensions;

namespace SPGen.VSIX.Settings
{
    public class FileStructureSettings
    {

        public const string SyncFile = "syncFiles.json";
        public const string CoreFile = "core.spg";
        public const string MasterFile = "master.spg";
        public const string WebFile = "web.spg";
        public FileStructureSettings(DTE dte)
        {

            if (dte == null) return;
            foreach (ProjectItem item in dte.CurrentProject().ProjectItems)
            {
                switch (item.Name)
                {
                    case "Files":
                        foreach (ProjectItem subItem in item.ProjectItems)
                        {
                            if (subItem.Name == SyncFile)
                            {
                                FilesPath = subItem.FileNames[0];
                            }
                        }
                        break;
                    case "Items":
                        foreach (ProjectItem subItem in item.ProjectItems)
                        {
                            switch (subItem.Name)
                            {
                                case CoreFile:
                                    CoreItemsPath = subItem.FileNames[0];
                                    break;
                                case MasterFile:
                                    MasterItemsPath = subItem.FileNames[0];
                                    break;
                                case WebFile:
                                    WebItemsPath = subItem.FileNames[0];
                                    break;
                            }
                        }
                        break;
                }
            }

        }

        //Project files location
        public string FilesPath { get; set; }
        public string CoreItemsPath { get; set; }
        public string MasterItemsPath { get; set; }
        public string WebItemsPath { get; set; }

        public string GetFile(string file)
        {
            using (StreamReader r = new StreamReader(file))
            {
                return r.ReadToEnd();
            }
        }

    }
}
