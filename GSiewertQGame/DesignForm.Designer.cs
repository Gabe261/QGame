namespace GSiewertQGame
{
    partial class DesignForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.lblColumns = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.pnlToolBox = new System.Windows.Forms.Panel();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.lblToolBox = new System.Windows.Forms.Label();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.toolBoxImgList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(982, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.txtColumns);
            this.panel1.Controls.Add(this.lblColumns);
            this.panel1.Controls.Add(this.txtRows);
            this.panel1.Controls.Add(this.lblRows);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 75);
            this.panel1.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(483, 15);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(143, 46);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(316, 27);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(100, 22);
            this.txtColumns.TabIndex = 3;
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(237, 30);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(62, 16);
            this.lblColumns.TabIndex = 2;
            this.lblColumns.Text = "Columns:";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(104, 27);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(100, 22);
            this.txtRows.TabIndex = 1;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(36, 30);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(44, 16);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Rows:";
            // 
            // pnlToolBox
            // 
            this.pnlToolBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlToolBox.Controls.Add(this.btnGreenBox);
            this.pnlToolBox.Controls.Add(this.btnRedBox);
            this.pnlToolBox.Controls.Add(this.btnGreenDoor);
            this.pnlToolBox.Controls.Add(this.btnRedDoor);
            this.pnlToolBox.Controls.Add(this.btnWall);
            this.pnlToolBox.Controls.Add(this.btnNone);
            this.pnlToolBox.Controls.Add(this.lblToolBox);
            this.pnlToolBox.Location = new System.Drawing.Point(0, 112);
            this.pnlToolBox.Name = "pnlToolBox";
            this.pnlToolBox.Size = new System.Drawing.Size(176, 545);
            this.pnlToolBox.TabIndex = 2;
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenBox.ImageIndex = 5;
            this.btnGreenBox.ImageList = this.toolBoxImgList;
            this.btnGreenBox.Location = new System.Drawing.Point(22, 401);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(130, 60);
            this.btnGreenBox.TabIndex = 6;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.ToolBoxClicked);
            // 
            // btnRedBox
            // 
            this.btnRedBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedBox.ImageIndex = 4;
            this.btnRedBox.ImageList = this.toolBoxImgList;
            this.btnRedBox.Location = new System.Drawing.Point(22, 335);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(130, 60);
            this.btnRedBox.TabIndex = 5;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.ToolBoxClicked);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenDoor.ImageIndex = 3;
            this.btnGreenDoor.ImageList = this.toolBoxImgList;
            this.btnGreenDoor.Location = new System.Drawing.Point(22, 269);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(130, 60);
            this.btnGreenDoor.TabIndex = 4;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.ToolBoxClicked);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedDoor.ImageIndex = 2;
            this.btnRedDoor.ImageList = this.toolBoxImgList;
            this.btnRedDoor.Location = new System.Drawing.Point(22, 203);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(130, 60);
            this.btnRedDoor.TabIndex = 3;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.ToolBoxClicked);
            // 
            // btnWall
            // 
            this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWall.ImageIndex = 1;
            this.btnWall.ImageList = this.toolBoxImgList;
            this.btnWall.Location = new System.Drawing.Point(22, 137);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(130, 60);
            this.btnWall.TabIndex = 2;
            this.btnWall.Text = "Wall";
            this.btnWall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.ToolBoxClicked);
            // 
            // btnNone
            // 
            this.btnNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNone.ImageIndex = 0;
            this.btnNone.ImageList = this.toolBoxImgList;
            this.btnNone.Location = new System.Drawing.Point(22, 71);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(130, 60);
            this.btnNone.TabIndex = 1;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.ToolBoxClicked);
            // 
            // lblToolBox
            // 
            this.lblToolBox.AutoSize = true;
            this.lblToolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolBox.Location = new System.Drawing.Point(47, 21);
            this.lblToolBox.Name = "lblToolBox";
            this.lblToolBox.Size = new System.Drawing.Size(80, 24);
            this.lblToolBox.TabIndex = 0;
            this.lblToolBox.Text = "Toolbox";
            // 
            // dlgSave
            // 
            this.dlgSave.AddExtension = false;
            // 
            // toolBoxImgList
            // 
            this.toolBoxImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toolBoxImgList.ImageStream")));
            this.toolBoxImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.toolBoxImgList.Images.SetKeyName(0, "None.png");
            this.toolBoxImgList.Images.SetKeyName(1, "Wall.png");
            this.toolBoxImgList.Images.SetKeyName(2, "RedDoor.png");
            this.toolBoxImgList.Images.SetKeyName(3, "GreenDoor.png");
            this.toolBoxImgList.Images.SetKeyName(4, "RedBox.png");
            this.toolBoxImgList.Images.SetKeyName(5, "GreenBox.png");
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 905);
            this.Controls.Add(this.pnlToolBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "DesignForm";
            this.Text = "Design Form";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlToolBox.ResumeLayout(false);
            this.pnlToolBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Panel pnlToolBox;
        private System.Windows.Forms.Label lblToolBox;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        public System.Windows.Forms.ImageList toolBoxImgList;
    }
}