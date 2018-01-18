namespace SPGen.FileManager.Forms
{
    partial class FileManagerForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManagerForm));
            this.filesTreeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.saveBtn = new System.Windows.Forms.Button();
            this.removeFileBtn = new System.Windows.Forms.Button();
            this.addFileBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filesTreeView
            // 
            this.filesTreeView.Dock = System.Windows.Forms.DockStyle.Top;
            this.filesTreeView.Location = new System.Drawing.Point(0, 0);
            this.filesTreeView.Name = "filesTreeView";
            this.filesTreeView.Size = new System.Drawing.Size(635, 450);
            this.filesTreeView.TabIndex = 1;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "blanc");
            this.imageList.Images.SetKeyName(1, "css");
            this.imageList.Images.SetKeyName(2, "dll");
            this.imageList.Images.SetKeyName(3, "folder");
            this.imageList.Images.SetKeyName(4, "picture");
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(396, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(234, 38);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // removeFileBtn
            // 
            this.removeFileBtn.Location = new System.Drawing.Point(196, 3);
            this.removeFileBtn.Name = "removeFileBtn";
            this.removeFileBtn.Size = new System.Drawing.Size(194, 38);
            this.removeFileBtn.TabIndex = 3;
            this.removeFileBtn.Text = "Remove File";
            this.removeFileBtn.UseVisualStyleBackColor = true;
            this.removeFileBtn.Click += new System.EventHandler(this.removeFileBtn_Click);
            // 
            // addFileBtn
            // 
            this.addFileBtn.Location = new System.Drawing.Point(3, 3);
            this.addFileBtn.Name = "addFileBtn";
            this.addFileBtn.Size = new System.Drawing.Size(187, 39);
            this.addFileBtn.TabIndex = 2;
            this.addFileBtn.Text = "Add File";
            this.addFileBtn.UseVisualStyleBackColor = true;
            this.addFileBtn.Click += new System.EventHandler(this.addFileBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addFileBtn);
            this.flowLayoutPanel1.Controls.Add(this.removeFileBtn);
            this.flowLayoutPanel1.Controls.Add(this.saveBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 453);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(635, 49);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // FileManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.filesTreeView);
            this.Name = "FileManagerForm";
            this.Size = new System.Drawing.Size(635, 502);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView filesTreeView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button removeFileBtn;
        private System.Windows.Forms.Button addFileBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
