namespace SPGen.VSIX.Forms
{
    partial class SyncPackage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.syncTabControl = new System.Windows.Forms.TabControl();
            this.syncItemsTab = new System.Windows.Forms.TabPage();
            this.syncFilesTab = new System.Windows.Forms.TabPage();
            this.syncTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // syncTabControl
            // 
            this.syncTabControl.Controls.Add(this.syncItemsTab);
            this.syncTabControl.Controls.Add(this.syncFilesTab);
            this.syncTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.syncTabControl.Location = new System.Drawing.Point(0, 0);
            this.syncTabControl.Name = "syncTabControl";
            this.syncTabControl.SelectedIndex = 0;
            this.syncTabControl.Size = new System.Drawing.Size(761, 681);
            this.syncTabControl.TabIndex = 0;
            // 
            // syncItemsTab
            // 
            this.syncItemsTab.Location = new System.Drawing.Point(4, 22);
            this.syncItemsTab.Name = "syncItemsTab";
            this.syncItemsTab.Padding = new System.Windows.Forms.Padding(3);
            this.syncItemsTab.Size = new System.Drawing.Size(688, 575);
            this.syncItemsTab.TabIndex = 0;
            this.syncItemsTab.Text = "Sync Items";
            this.syncItemsTab.UseVisualStyleBackColor = true;
            // 
            // syncFilesTab
            // 
            this.syncFilesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syncFilesTab.Location = new System.Drawing.Point(4, 22);
            this.syncFilesTab.Name = "syncFilesTab";
            this.syncFilesTab.Padding = new System.Windows.Forms.Padding(3);
            this.syncFilesTab.Size = new System.Drawing.Size(753, 655);
            this.syncFilesTab.TabIndex = 1;
            this.syncFilesTab.Text = "Sync Files";
            this.syncFilesTab.UseVisualStyleBackColor = true;
            // 
            // SyncPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 681);
            this.Controls.Add(this.syncTabControl);
            this.Name = "SyncPackage";
            this.Text = "SyncPackage";
            this.Load += new System.EventHandler(this.SyncPackage_Load);
            this.syncTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl syncTabControl;
        private System.Windows.Forms.TabPage syncItemsTab;
        private System.Windows.Forms.TabPage syncFilesTab;
    }
}