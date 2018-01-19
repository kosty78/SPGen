using EnvDTE;
using SPGen.Common.Extensions;

namespace SPGen.Common.Settings
{
    public class FileStructureSettings
    {

        public const string SyncFile = "syncFiles.json";
        public const string CoreFile = "core.json";
        public const string MasterFile = "master.json";
        public FileStructureSettings(DTE dte)
        {

            if (dte == null) return;
            foreach (ProjectItem item in dte.CurrentProject().ProjectItems)
            {
                switch (item.Name)
                {
                    case "Files":

                        FilesPath = $"{item.FileNames[0]}{SyncFile}";

                        break;
                    case "Items":
                        CoreItemsPath = $"{item.FileNames[0]}{CoreFile}";
                        MasterItemsPath = $"{item.FileNames[0]}{MasterFile}";
                        break;
                }
            }

        }

        //Project files location
        public string FilesPath { get; set; }
        public string CoreItemsPath { get; set; }
        public string MasterItemsPath { get; set; }
        public string WebItemsPath { get; set; }
    }
}
