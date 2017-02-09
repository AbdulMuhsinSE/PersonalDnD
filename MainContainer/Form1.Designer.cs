namespace MainContainer
{
    partial class MainContainer
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
            this.PagedControls = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dieTypeLabel = new System.Windows.Forms.Label();
            this.dieRollTextBox = new System.Windows.Forms.RichTextBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.dicePictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dieTypeTextBox = new System.Windows.Forms.TextBox();
            this.numberofdieTextBox = new System.Windows.Forms.TextBox();
            this.numberofdieLabel = new System.Windows.Forms.Label();
            this.PagedControls.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagedControls
            // 
            this.PagedControls.Controls.Add(this.tabPage1);
            this.PagedControls.Controls.Add(this.tabPage2);
            this.PagedControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PagedControls.Location = new System.Drawing.Point(0, 24);
            this.PagedControls.Name = "PagedControls";
            this.PagedControls.SelectedIndex = 0;
            this.PagedControls.Size = new System.Drawing.Size(723, 438);
            this.PagedControls.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.PagedControls.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numberofdieLabel);
            this.tabPage1.Controls.Add(this.numberofdieTextBox);
            this.tabPage1.Controls.Add(this.dieTypeTextBox);
            this.tabPage1.Controls.Add(this.dieTypeLabel);
            this.tabPage1.Controls.Add(this.dieRollTextBox);
            this.tabPage1.Controls.Add(this.rollButton);
            this.tabPage1.Controls.Add(this.dicePictureBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(715, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dieTypeLabel
            // 
            this.dieTypeLabel.AutoSize = true;
            this.dieTypeLabel.Location = new System.Drawing.Point(323, 91);
            this.dieTypeLabel.Name = "dieTypeLabel";
            this.dieTypeLabel.Size = new System.Drawing.Size(50, 13);
            this.dieTypeLabel.TabIndex = 4;
            this.dieTypeLabel.Text = "Die Type";
            this.dieTypeLabel.Click += new System.EventHandler(this.dieTypeLabel_Click);
            // 
            // dieRollTextBox
            // 
            this.dieRollTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.dieRollTextBox.Enabled = false;
            this.dieRollTextBox.Location = new System.Drawing.Point(463, 157);
            this.dieRollTextBox.Name = "dieRollTextBox";
            this.dieRollTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.dieRollTextBox.Size = new System.Drawing.Size(244, 96);
            this.dieRollTextBox.TabIndex = 3;
            this.dieRollTextBox.Text = "";
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(463, 107);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(244, 33);
            this.rollButton.TabIndex = 1;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.d6Button_Click);
            // 
            // dicePictureBox
            // 
            this.dicePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dicePictureBox.Location = new System.Drawing.Point(8, 57);
            this.dicePictureBox.Name = "dicePictureBox";
            this.dicePictureBox.Size = new System.Drawing.Size(244, 259);
            this.dicePictureBox.TabIndex = 0;
            this.dicePictureBox.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(715, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tabsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(723, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem1,
            this.exportToToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "New";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem1.Text = "Save As";
            // 
            // exportToToolStripMenuItem
            // 
            this.exportToToolStripMenuItem.Name = "exportToToolStripMenuItem";
            this.exportToToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exportToToolStripMenuItem.Text = "Export To";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // tabsToolStripMenuItem
            // 
            this.tabsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTabToolStripMenuItem});
            this.tabsToolStripMenuItem.Name = "tabsToolStripMenuItem";
            this.tabsToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.tabsToolStripMenuItem.Text = "Tabs";
            // 
            // addTabToolStripMenuItem
            // 
            this.addTabToolStripMenuItem.Name = "addTabToolStripMenuItem";
            this.addTabToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addTabToolStripMenuItem.Text = "Manage Tabs";
            // 
            // dieTypeTextBox
            // 
            this.dieTypeTextBox.Location = new System.Drawing.Point(326, 114);
            this.dieTypeTextBox.Name = "dieTypeTextBox";
            this.dieTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.dieTypeTextBox.TabIndex = 5;
            // 
            // numberofdieTextBox
            // 
            this.numberofdieTextBox.Location = new System.Drawing.Point(326, 157);
            this.numberofdieTextBox.Name = "numberofdieTextBox";
            this.numberofdieTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberofdieTextBox.TabIndex = 6;
            // 
            // numberofdieLabel
            // 
            this.numberofdieLabel.AutoSize = true;
            this.numberofdieLabel.Location = new System.Drawing.Point(323, 141);
            this.numberofdieLabel.Name = "numberofdieLabel";
            this.numberofdieLabel.Size = new System.Drawing.Size(75, 13);
            this.numberofdieLabel.TabIndex = 7;
            this.numberofdieLabel.Text = "Number of Die";
            // 
            // MainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 462);
            this.Controls.Add(this.PagedControls);
            this.Controls.Add(this.mainMenuStrip);
            this.Name = "MainContainer";
            this.Text = "D&DGameChanger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PagedControls.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabControl PagedControls;
        private System.Windows.Forms.PictureBox dicePictureBox;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTabToolStripMenuItem;
        private System.Windows.Forms.RichTextBox dieRollTextBox;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label dieTypeLabel;
        private System.Windows.Forms.TextBox numberofdieTextBox;
        private System.Windows.Forms.TextBox dieTypeTextBox;
        private System.Windows.Forms.Label numberofdieLabel;
    }
}

