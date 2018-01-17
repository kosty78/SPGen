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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addBtn = new System.Windows.Forms.Button();
            this.addChldBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.syncTabControl.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // syncTabControl
            // 
            this.syncTabControl.Controls.Add(this.syncItemsTab);
            this.syncTabControl.Controls.Add(this.syncFilesTab);
            this.syncTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.syncTabControl.Location = new System.Drawing.Point(0, 0);
            this.syncTabControl.Name = "syncTabControl";
            this.syncTabControl.SelectedIndex = 0;
            this.syncTabControl.Size = new System.Drawing.Size(1330, 449);
            this.syncTabControl.TabIndex = 0;
            // 
            // syncItemsTab
            // 
            this.syncItemsTab.Location = new System.Drawing.Point(4, 22);
            this.syncItemsTab.Name = "syncItemsTab";
            this.syncItemsTab.Padding = new System.Windows.Forms.Padding(3);
            this.syncItemsTab.Size = new System.Drawing.Size(1322, 423);
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
            this.syncFilesTab.Size = new System.Drawing.Size(1322, 423);
            this.syncFilesTab.TabIndex = 1;
            this.syncFilesTab.Text = "Sync Files";
            this.syncFilesTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addBtn);
            this.flowLayoutPanel1.Controls.Add(this.addChldBtn);
            this.flowLayoutPanel1.Controls.Add(this.removeBtn);
            this.flowLayoutPanel1.Controls.Add(this.saveBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 449);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1330, 48);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(154, 33);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // addChldBtn
            // 
            this.addChldBtn.Location = new System.Drawing.Point(163, 3);
            this.addChldBtn.Name = "addChldBtn";
            this.addChldBtn.Size = new System.Drawing.Size(175, 33);
            this.addChldBtn.TabIndex = 1;
            this.addChldBtn.Text = "Add with Children";
            this.addChldBtn.UseVisualStyleBackColor = true;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(344, 3);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(175, 33);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(525, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(167, 33);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // SyncPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 497);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.syncTabControl);
            this.Name = "SyncPackage";
            this.Text = "SyncPackage";
            this.syncTabControl.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl syncTabControl;
        private System.Windows.Forms.TabPage syncItemsTab;
        private System.Windows.Forms.TabPage syncFilesTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button addChldBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}