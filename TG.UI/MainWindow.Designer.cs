namespace TG.UI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.cntMain = new System.Windows.Forms.SplitContainer();
            this.txtCommandHist = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrompt = new System.Windows.Forms.Label();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.cntRightCol = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.lblHPValue = new System.Windows.Forms.Label();
            this.lblDamageValue = new System.Windows.Forms.Label();
            this.txtChrName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vuvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsBottom = new System.Windows.Forms.StatusStrip();
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cntMain)).BeginInit();
            this.cntMain.Panel1.SuspendLayout();
            this.cntMain.Panel2.SuspendLayout();
            this.cntMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cntRightCol)).BeginInit();
            this.cntRightCol.Panel1.SuspendLayout();
            this.cntRightCol.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.stsBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntMain
            // 
            this.cntMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntMain.Location = new System.Drawing.Point(0, 24);
            this.cntMain.Name = "cntMain";
            // 
            // cntMain.Panel1
            // 
            this.cntMain.Panel1.Controls.Add(this.txtCommandHist);
            this.cntMain.Panel1.Controls.Add(this.txtInput);
            this.cntMain.Panel1.Controls.Add(this.txtDescription);
            this.cntMain.Panel1.Controls.Add(this.txtPrompt);
            this.cntMain.Panel1.Controls.Add(this.picMain);
            // 
            // cntMain.Panel2
            // 
            this.cntMain.Panel2.Controls.Add(this.cntRightCol);
            this.cntMain.Size = new System.Drawing.Size(756, 437);
            this.cntMain.SplitterDistance = 541;
            this.cntMain.TabIndex = 3;
            // 
            // txtCommandHist
            // 
            this.txtCommandHist.BackColor = System.Drawing.SystemColors.Control;
            this.txtCommandHist.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCommandHist.Location = new System.Drawing.Point(12, 225);
            this.txtCommandHist.Multiline = true;
            this.txtCommandHist.Name = "txtCommandHist";
            this.txtCommandHist.ReadOnly = true;
            this.txtCommandHist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommandHist.Size = new System.Drawing.Size(509, 119);
            this.txtCommandHist.TabIndex = 7;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 374);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(509, 20);
            this.txtInput.TabIndex = 6;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(txtInput_KeyDown);
            
            // 
            // txtDescription
            // 
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(189, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(332, 216);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = resources.GetString("txtDescription.Text");
            // 
            // txtPrompt
            // 
            this.txtPrompt.AutoSize = true;
            this.txtPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrompt.Location = new System.Drawing.Point(12, 347);
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(153, 24);
            this.txtPrompt.TabIndex = 3;
            this.txtPrompt.Text = "What do you do?";
            // 
            // picMain
            // 
            this.picMain.ImageLocation = "Resources\\Pictures\\lonely.jpg";
            this.picMain.InitialImage = null;
            this.picMain.Location = new System.Drawing.Point(12, 3);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(171, 219);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 2;
            this.picMain.TabStop = false;
            // 
            // cntRightCol
            // 
            this.cntRightCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntRightCol.Location = new System.Drawing.Point(0, 0);
            this.cntRightCol.Name = "cntRightCol";
            this.cntRightCol.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // cntRightCol.Panel1
            // 
            this.cntRightCol.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.cntRightCol.Size = new System.Drawing.Size(211, 437);
            this.cntRightCol.SplitterDistance = 265;
            this.cntRightCol.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtChrName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.88112F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.11888F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(167, 143);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblHP, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDamage, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblHPValue, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDamageValue, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(161, 110);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblHP
            // 
            this.lblHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(26, 21);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(28, 13);
            this.lblHP.TabIndex = 0;
            this.lblHP.Text = "HP:";
            // 
            // lblDamage
            // 
            this.lblDamage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDamage.AutoSize = true;
            this.lblDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamage.Location = new System.Drawing.Point(11, 76);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(57, 13);
            this.lblDamage.TabIndex = 1;
            this.lblDamage.Text = "Damage:";
            // 
            // lblHPValue
            // 
            this.lblHPValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHPValue.AutoSize = true;
            this.lblHPValue.Location = new System.Drawing.Point(120, 21);
            this.lblHPValue.Name = "lblHPValue";
            this.lblHPValue.Size = new System.Drawing.Size(0, 13);
            this.lblHPValue.TabIndex = 2;
            // 
            // lblDamageValue
            // 
            this.lblDamageValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDamageValue.AutoSize = true;
            this.lblDamageValue.Location = new System.Drawing.Point(120, 76);
            this.lblDamageValue.Name = "lblDamageValue";
            this.lblDamageValue.Size = new System.Drawing.Size(0, 13);
            this.lblDamageValue.TabIndex = 3;
            // 
            // txtChrName
            // 
            this.txtChrName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChrName.AutoSize = true;
            this.txtChrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChrName.Location = new System.Drawing.Point(47, 5);
            this.txtChrName.Name = "txtChrName";
            this.txtChrName.Size = new System.Drawing.Size(72, 17);
            this.txtChrName.TabIndex = 1;
            this.txtChrName.Text = "Spartacus";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.vuvToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuTop";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // vuvToolStripMenuItem
            // 
            this.vuvToolStripMenuItem.Name = "vuvToolStripMenuItem";
            this.vuvToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.vuvToolStripMenuItem.Text = "&Vuv";
            this.vuvToolStripMenuItem.Click += new System.EventHandler(this.vuvToolStripMenuItem_Click);
            // 
            // stsBottom
            // 
            this.stsBottom.GripMargin = new System.Windows.Forms.Padding(0);
            this.stsBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStatus});
            this.stsBottom.Location = new System.Drawing.Point(0, 439);
            this.stsBottom.Name = "stsBottom";
            this.stsBottom.Size = new System.Drawing.Size(756, 22);
            this.stsBottom.SizingGrip = false;
            this.stsBottom.TabIndex = 6;
            // 
            // txtStatus
            // 
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(52, 17);
            this.txtStatus.Text = "Running";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 461);
            this.Controls.Add(this.stsBottom);
            this.Controls.Add(this.cntMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(762, 489);
            this.MinimumSize = new System.Drawing.Size(762, 489);
            this.Name = "MainWindow";
            this.Text = "Titanium Grasshopper";
            this.cntMain.Panel1.ResumeLayout(false);
            this.cntMain.Panel1.PerformLayout();
            this.cntMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cntMain)).EndInit();
            this.cntMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.cntRightCol.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cntRightCol)).EndInit();
            this.cntRightCol.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.stsBottom.ResumeLayout(false);
            this.stsBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer cntMain;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label txtPrompt;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vuvToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCommandHist;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.SplitContainer cntRightCol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label txtChrName;
        private System.Windows.Forms.StatusStrip stsBottom;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.Label lblHPValue;
        private System.Windows.Forms.Label lblDamageValue;

    }
}