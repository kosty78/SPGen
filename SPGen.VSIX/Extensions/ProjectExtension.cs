using System;
using EnvDTE;

namespace SPGen.VSIX.Extensions
{
    public static class ProjectExtention
    {
        private const string SpgenProject = ".spgenproj";
        public static bool IsSpGenProject(this Project project)
        {
            return project?.FullName.EndsWith(SpgenProject) ?? false;
        }

        public static Project CurrentProject(this DTE dte)
        {
            Array projects = (Array)dte.ActiveSolutionProjects;
            return projects.Length > 0 ? (Project)projects.GetValue(0) : null;
        }
    }
}
