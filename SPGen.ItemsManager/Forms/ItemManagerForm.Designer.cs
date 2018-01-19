namespace SPGen.ItemManager.Forms
{
    partial class ItemManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemManagerForm));
            this.itemsTreeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.saveBtn = new System.Windows.Forms.Button();
            this.removeItemBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addChildBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemsTreeView
            // 
            this.itemsTreeView.BackColor = System.Drawing.Color.LightGray;
            this.itemsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTreeView.Location = new System.Drawing.Point(3, 53);
            this.itemsTreeView.Name = "itemsTreeView";
            this.itemsTreeView.Size = new System.Drawing.Size(629, 446);
            this.itemsTreeView.TabIndex = 1;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "");
            this.imageList.Images.SetKeyName(1, "");
            this.imageList.Images.SetKeyName(2, "");
            this.imageList.Images.SetKeyName(3, "");
            this.imageList.Images.SetKeyName(4, "");
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.White;
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(474, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(152, 38);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // removeItemBtn
            // 
            this.removeItemBtn.BackColor = System.Drawing.Color.White;
            this.removeItemBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeItemBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeItemBtn.Location = new System.Drawing.Point(317, 3);
            this.removeItemBtn.Name = "removeItemBtn";
            this.removeItemBtn.Size = new System.Drawing.Size(151, 38);
            this.removeItemBtn.TabIndex = 3;
            this.removeItemBtn.Text = "Remove Item";
            this.removeItemBtn.UseVisualStyleBackColor = false;
            this.removeItemBtn.Click += new System.EventHandler(this.removeItemBtn_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.Color.White;
            this.addItemBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addItemBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addItemBtn.Location = new System.Drawing.Point(3, 3);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(151, 38);
            this.addItemBtn.TabIndex = 2;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = false;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.addItemBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addChildBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.removeItemBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveBtn, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(629, 44);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // addChildBtn
            // 
            this.addChildBtn.BackColor = System.Drawing.Color.White;
            this.addChildBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addChildBtn.Location = new System.Drawing.Point(160, 3);
            this.addChildBtn.Name = "addChildBtn";
            this.addChildBtn.Size = new System.Drawing.Size(151, 38);
            this.addChildBtn.TabIndex = 5;
            this.addChildBtn.Text = "Add w Children";
            this.addChildBtn.UseVisualStyleBackColor = false;
            this.addChildBtn.Click += new System.EventHandler(this.addChildBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.itemsTreeView, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(635, 502);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // ItemManagerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ItemManagerForm";
            this.Size = new System.Drawing.Size(635, 502);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView itemsTreeView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button removeItemBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button addChildBtn;
    }
}
