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
            this.characterTab = new System.Windows.Forms.TabPage();
            this.characterPictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numberofdieLabel = new System.Windows.Forms.Label();
            this.numberofdieTextBox = new System.Windows.Forms.TextBox();
            this.dieTypeLabel = new System.Windows.Forms.Label();
            this.dieRollTextBox = new System.Windows.Forms.RichTextBox();
            this.rollButton = new System.Windows.Forms.Button();
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
            this.dieRollPanel = new System.Windows.Forms.Panel();
            this.dieTypeComboBox = new System.Windows.Forms.ComboBox();
            this.setPortraitButton = new System.Windows.Forms.Button();
            this.PagedControls.SuspendLayout();
            this.characterTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterPictureBox)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.dieRollPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagedControls
            // 
            this.PagedControls.Controls.Add(this.characterTab);
            this.PagedControls.Controls.Add(this.tabPage2);
            this.PagedControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PagedControls.Location = new System.Drawing.Point(0, 24);
            this.PagedControls.Name = "PagedControls";
            this.PagedControls.SelectedIndex = 0;
            this.PagedControls.Size = new System.Drawing.Size(812, 498);
            this.PagedControls.TabIndex = 0;
            // 
            // characterTab
            // 
            this.characterTab.Controls.Add(this.setPortraitButton);
            this.characterTab.Controls.Add(this.characterPictureBox);
            this.characterTab.Location = new System.Drawing.Point(4, 22);
            this.characterTab.Name = "characterTab";
            this.characterTab.Padding = new System.Windows.Forms.Padding(3);
            this.characterTab.Size = new System.Drawing.Size(804, 472);
            this.characterTab.TabIndex = 0;
            this.characterTab.Text = "Character Page";
            this.characterTab.UseVisualStyleBackColor = true;
            // 
            // characterPictureBox
            // 
            this.characterPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.characterPictureBox.Location = new System.Drawing.Point(3, 6);
            this.characterPictureBox.Name = "characterPictureBox";
            this.characterPictureBox.Size = new System.Drawing.Size(175, 292);
            this.characterPictureBox.TabIndex = 0;
            this.characterPictureBox.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numberofdieLabel
            // 
            this.numberofdieLabel.AutoSize = true;
            this.numberofdieLabel.Location = new System.Drawing.Point(9, 65);
            this.numberofdieLabel.Name = "numberofdieLabel";
            this.numberofdieLabel.Size = new System.Drawing.Size(75, 13);
            this.numberofdieLabel.TabIndex = 7;
            this.numberofdieLabel.Text = "Number of Die";
            // 
            // numberofdieTextBox
            // 
            this.numberofdieTextBox.Location = new System.Drawing.Point(12, 81);
            this.numberofdieTextBox.Name = "numberofdieTextBox";
            this.numberofdieTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberofdieTextBox.TabIndex = 6;
            // 
            // dieTypeLabel
            // 
            this.dieTypeLabel.AutoSize = true;
            this.dieTypeLabel.Location = new System.Drawing.Point(10, 25);
            this.dieTypeLabel.Name = "dieTypeLabel";
            this.dieTypeLabel.Size = new System.Drawing.Size(50, 13);
            this.dieTypeLabel.TabIndex = 4;
            this.dieTypeLabel.Text = "Die Type";
            // 
            // dieRollTextBox
            // 
            this.dieRollTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.dieRollTextBox.Enabled = false;
            this.dieRollTextBox.Location = new System.Drawing.Point(451, 6);
            this.dieRollTextBox.Name = "dieRollTextBox";
            this.dieRollTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.dieRollTextBox.Size = new System.Drawing.Size(349, 116);
            this.dieRollTextBox.TabIndex = 3;
            this.dieRollTextBox.Text = "";
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(140, 25);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(281, 76);
            this.rollButton.TabIndex = 1;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tabsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(812, 24);
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
            // dieRollPanel
            // 
            this.dieRollPanel.Controls.Add(this.dieTypeComboBox);
            this.dieRollPanel.Controls.Add(this.numberofdieLabel);
            this.dieRollPanel.Controls.Add(this.rollButton);
            this.dieRollPanel.Controls.Add(this.numberofdieTextBox);
            this.dieRollPanel.Controls.Add(this.dieRollTextBox);
            this.dieRollPanel.Controls.Add(this.dieTypeLabel);
            this.dieRollPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dieRollPanel.Location = new System.Drawing.Point(0, 388);
            this.dieRollPanel.Name = "dieRollPanel";
            this.dieRollPanel.Size = new System.Drawing.Size(812, 134);
            this.dieRollPanel.TabIndex = 8;
            // 
            // dieTypeComboBox
            // 
            this.dieTypeComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dieTypeComboBox.FormattingEnabled = true;
            this.dieTypeComboBox.Items.AddRange(new object[] {
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20",
            "d100"});
            this.dieTypeComboBox.Location = new System.Drawing.Point(12, 41);
            this.dieTypeComboBox.Name = "dieTypeComboBox";
            this.dieTypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.dieTypeComboBox.TabIndex = 9;
            // 
            // setPortraitButton
            // 
            this.setPortraitButton.Location = new System.Drawing.Point(3, 304);
            this.setPortraitButton.Name = "setPortraitButton";
            this.setPortraitButton.Size = new System.Drawing.Size(175, 23);
            this.setPortraitButton.TabIndex = 1;
            this.setPortraitButton.Text = "Set Portrait";
            this.setPortraitButton.UseVisualStyleBackColor = true;
            this.setPortraitButton.Click += new System.EventHandler(this.setPortraitButton_Click);
            // 
            // MainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 522);
            this.Controls.Add(this.dieRollPanel);
            this.Controls.Add(this.PagedControls);
            this.Controls.Add(this.mainMenuStrip);
            this.Name = "MainContainer";
            this.Text = "D&DGameChanger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PagedControls.ResumeLayout(false);
            this.characterTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.characterPictureBox)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.dieRollPanel.ResumeLayout(false);
            this.dieRollPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage characterTab;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabControl PagedControls;
        private System.Windows.Forms.PictureBox characterPictureBox;
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
        private System.Windows.Forms.Label numberofdieLabel;
        private System.Windows.Forms.Panel dieRollPanel;
        private System.Windows.Forms.ComboBox dieTypeComboBox;
        private System.Windows.Forms.Button setPortraitButton;
    }
}

