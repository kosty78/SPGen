using System;
using System.ComponentModel.Design;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
using SPGen.Common.Settings;
using SPGen.VSIX.Forms;

namespace SPGen.VSIX.Commands.Sync
{
    /// <summary>
    ///     Command handler
    /// </summary>
    internal sealed class SyncCommand
    {
        /// <summary>
        ///     Command ID.
        /// </summary>
        public const int CommandId = 0x0200;

        /// <summary>
        ///     Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("2d7f5709-90cb-4821-a842-256c7b3ff745");

        /// <summary>
        ///     VS Package that provides this command, not null.
        /// </summary>
        private readonly Package _package;

        /// <summary>
        ///     Initializes a new instance of the <see cref="SyncCommand" /> class.
        ///     Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        private SyncCommand(Package package)
        {
            _package = package ?? throw new ArgumentNullException(nameof(package));

            if (ServiceProvider.GetService(typeof(IMenuCommandService)) is OleMenuCommandService commandService)
            {
                var menuCommandId = new CommandID(CommandSet, CommandId);

                OleMenuCommand menuItem = new OleMenuCommand(MenuItemCallback, menuCommandId);
                menuItem.BeforeQueryStatus += menuItem_BeforeQueryStatus;

                commandService.AddCommand(menuItem);
            }
        }


        /// <summary>
        ///     Gets the instance of the command.
        /// </summary>
        public static SyncCommand Instance { get; private set; }

        /// <summary>
        ///     Gets the service provider from the owner package.
        /// </summary>
        private IServiceProvider ServiceProvider => _package;

        /// <summary>
        ///     Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static void Initialize(Package package)
        {
            Instance = new SyncCommand(package);
        }


        private void menuItem_BeforeQueryStatus(object sender, EventArgs e)
        {
            DTE dte = ServiceProvider.GetService(typeof(DTE)) as DTE;
            //TODO: add to cpec proj
            ((OleMenuCommand)sender).Visible = true;// dte.CurrentProject().IsSpGenProject();
        }
        /// <summary>
        ///     This function is the callback used to execute the command when the menu item is clicked.
        ///     See the constructor to see how the menu item is associated with this function using
        ///     OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void MenuItemCallback(object sender, EventArgs e)
        {
            var dte = ServiceProvider.GetService(typeof(DTE)) as DTE;
            SyncPackage syncPackage = new SyncPackage(new Settings(dte));
            syncPackage.ShowDialog();
        }
    }
}