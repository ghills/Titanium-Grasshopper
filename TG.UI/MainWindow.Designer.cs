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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vuvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtCommandHist = new System.Windows.Forms.TextBox();
            this.cntRightCol = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.cntMain)).BeginInit();
            this.cntMain.Panel1.SuspendLayout();
            this.cntMain.Panel2.SuspendLayout();
            this.cntMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cntRightCol)).BeginInit();
            this.cntRightCol.SuspendLayout();
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
            this.cntMain.Panel1.Controls.Add(this.statusStrip1);
            this.cntMain.Panel1.Controls.Add(this.txtDescription);
            this.cntMain.Panel1.Controls.Add(this.lblPrompt);
            this.cntMain.Panel1.Controls.Add(this.picMain);
            // 
            // cntMain.Panel2
            // 
            this.cntMain.Panel2.Controls.Add(this.cntRightCol);
            this.cntMain.Size = new System.Drawing.Size(746, 441);
            this.cntMain.SplitterDistance = 534;
            this.cntMain.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(534, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "stsBottom";
            // 
            // txtDescription
            // 
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(177, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(357, 216);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "You are in a room full of loneliness - a vuvezela reminds you of your sadness and" +
                " drives you into insanity.";
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(54, 347);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(153, 24);
            this.lblPrompt.TabIndex = 3;
            this.lblPrompt.Text = "What do you do?";
            // 
            // picMain
            // 
            this.picMain.InitialImage = ((System.Drawing.Image)(resources.GetObject("picMain.InitialImage")));
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(171, 219);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 2;
            this.picMain.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.vuvToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
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
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(58, 374);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(418, 20);
            this.txtInput.TabIndex = 6;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtCommandHist
            // 
            this.txtCommandHist.BackColor = System.Drawing.SystemColors.Control;
            this.txtCommandHist.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCommandHist.Location = new System.Drawing.Point(58, 225);
            this.txtCommandHist.Multiline = true;
            this.txtCommandHist.Name = "txtCommandHist";
            this.txtCommandHist.ReadOnly = true;
            this.txtCommandHist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommandHist.Size = new System.Drawing.Size(418, 119);
            this.txtCommandHist.TabIndex = 7;
            // 
            // cntRightCol
            // 
            this.cntRightCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntRightCol.Location = new System.Drawing.Point(0, 0);
            this.cntRightCol.Name = "cntRightCol";
            this.cntRightCol.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.cntRightCol.Size = new System.Drawing.Size(208, 441);
            this.cntRightCol.SplitterDistance = 69;
            this.cntRightCol.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 465);
            this.Controls.Add(this.cntMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Titanium Grasshopper";
            this.cntMain.Panel1.ResumeLayout(false);
            this.cntMain.Panel1.PerformLayout();
            this.cntMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cntMain)).EndInit();
            this.cntMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cntRightCol)).EndInit();
            this.cntRightCol.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer cntMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vuvToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCommandHist;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.SplitContainer cntRightCol;

    }
}