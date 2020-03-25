namespace SearchFileApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.HiddenCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchOptionsPanel = new System.Windows.Forms.Panel();
            this.SearchPatternGroupBox = new System.Windows.Forms.GroupBox();
            this.NormalRadioButton = new System.Windows.Forms.RadioButton();
            this.WholeWordRadioButton = new System.Windows.Forms.RadioButton();
            this.MatchCaseRadioButton = new System.Windows.Forms.RadioButton();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExtensionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReadOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.ItemCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusCountlable = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ResultListView = new System.Windows.Forms.ListView();
            this.LargeImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SmallImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ViewComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SearchOptionsPanel.SuspendLayout();
            this.SearchPatternGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Path:";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathTextBox.Location = new System.Drawing.Point(50, 32);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(465, 20);
            this.PathTextBox.TabIndex = 0;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseButton.Location = new System.Drawing.Point(549, 30);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(61, 23);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // HiddenCheckBox
            // 
            this.HiddenCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HiddenCheckBox.AutoSize = true;
            this.HiddenCheckBox.Checked = true;
            this.HiddenCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HiddenCheckBox.Location = new System.Drawing.Point(336, 15);
            this.HiddenCheckBox.Name = "HiddenCheckBox";
            this.HiddenCheckBox.Size = new System.Drawing.Size(126, 17);
            this.HiddenCheckBox.TabIndex = 3;
            this.HiddenCheckBox.Text = "Include &Hidden Items";
            this.HiddenCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchOptionsPanel
            // 
            this.SearchOptionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchOptionsPanel.Controls.Add(this.SearchPatternGroupBox);
            this.SearchOptionsPanel.Controls.Add(this.NameTextBox);
            this.SearchOptionsPanel.Controls.Add(this.label3);
            this.SearchOptionsPanel.Controls.Add(this.ExtensionTextBox);
            this.SearchOptionsPanel.Controls.Add(this.label2);
            this.SearchOptionsPanel.Controls.Add(this.ReadOnlyCheckBox);
            this.SearchOptionsPanel.Controls.Add(this.HiddenCheckBox);
            this.SearchOptionsPanel.Location = new System.Drawing.Point(0, 81);
            this.SearchOptionsPanel.Name = "SearchOptionsPanel";
            this.SearchOptionsPanel.Size = new System.Drawing.Size(622, 148);
            this.SearchOptionsPanel.TabIndex = 3;
            // 
            // SearchPatternGroupBox
            // 
            this.SearchPatternGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPatternGroupBox.Controls.Add(this.NormalRadioButton);
            this.SearchPatternGroupBox.Controls.Add(this.WholeWordRadioButton);
            this.SearchPatternGroupBox.Controls.Add(this.MatchCaseRadioButton);
            this.SearchPatternGroupBox.Location = new System.Drawing.Point(336, 38);
            this.SearchPatternGroupBox.Name = "SearchPatternGroupBox";
            this.SearchPatternGroupBox.Size = new System.Drawing.Size(200, 100);
            this.SearchPatternGroupBox.TabIndex = 8;
            this.SearchPatternGroupBox.TabStop = false;
            this.SearchPatternGroupBox.Text = "SearchPattern";
            // 
            // NormalRadioButton
            // 
            this.NormalRadioButton.AutoSize = true;
            this.NormalRadioButton.Checked = true;
            this.NormalRadioButton.Location = new System.Drawing.Point(16, 65);
            this.NormalRadioButton.Name = "NormalRadioButton";
            this.NormalRadioButton.Size = new System.Drawing.Size(58, 17);
            this.NormalRadioButton.TabIndex = 10;
            this.NormalRadioButton.TabStop = true;
            this.NormalRadioButton.Text = "N&ormal";
            this.NormalRadioButton.UseVisualStyleBackColor = true;
            // 
            // WholeWordRadioButton
            // 
            this.WholeWordRadioButton.AutoSize = true;
            this.WholeWordRadioButton.Location = new System.Drawing.Point(16, 42);
            this.WholeWordRadioButton.Name = "WholeWordRadioButton";
            this.WholeWordRadioButton.Size = new System.Drawing.Size(85, 17);
            this.WholeWordRadioButton.TabIndex = 9;
            this.WholeWordRadioButton.Text = "&Whole Word";
            this.WholeWordRadioButton.UseVisualStyleBackColor = true;
            // 
            // MatchCaseRadioButton
            // 
            this.MatchCaseRadioButton.AutoSize = true;
            this.MatchCaseRadioButton.Location = new System.Drawing.Point(16, 19);
            this.MatchCaseRadioButton.Name = "MatchCaseRadioButton";
            this.MatchCaseRadioButton.Size = new System.Drawing.Size(82, 17);
            this.MatchCaseRadioButton.TabIndex = 8;
            this.MatchCaseRadioButton.Text = "&Match Case";
            this.MatchCaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(74, 42);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(180, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Name:";
            // 
            // ExtensionTextBox
            // 
            this.ExtensionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtensionTextBox.Location = new System.Drawing.Point(74, 19);
            this.ExtensionTextBox.Name = "ExtensionTextBox";
            this.ExtensionTextBox.Size = new System.Drawing.Size(87, 20);
            this.ExtensionTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Extension:";
            // 
            // ReadOnlyCheckBox
            // 
            this.ReadOnlyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadOnlyCheckBox.AutoSize = true;
            this.ReadOnlyCheckBox.Checked = true;
            this.ReadOnlyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReadOnlyCheckBox.Location = new System.Drawing.Point(468, 15);
            this.ReadOnlyCheckBox.Name = "ReadOnlyCheckBox";
            this.ReadOnlyCheckBox.Size = new System.Drawing.Size(139, 17);
            this.ReadOnlyCheckBox.TabIndex = 4;
            this.ReadOnlyCheckBox.Text = "Include &ReadOnly Items";
            this.ReadOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(0, 240);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(123, 36);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ResultListBox
            // 
            this.ResultListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultListBox.FormattingEnabled = true;
            this.ResultListBox.Location = new System.Drawing.Point(433, 235);
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.Size = new System.Drawing.Size(177, 43);
            this.ResultListBox.TabIndex = 5;
            this.ResultListBox.Visible = false;
            // 
            // ItemCountToolStripStatusLabel
            // 
            this.ItemCountToolStripStatusLabel.Name = "ItemCountToolStripStatusLabel";
            this.ItemCountToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemCountToolStripStatusLabel,
            this.toolStripStatusLabel3,
            this.toolStripStatusCountlable,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(622, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusCountlable
            // 
            this.toolStripStatusCountlable.Name = "toolStripStatusCountlable";
            this.toolStripStatusCountlable.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // ResultListView
            // 
            this.ResultListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultListView.LargeImageList = this.LargeImageList1;
            this.ResultListView.Location = new System.Drawing.Point(0, 293);
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.Size = new System.Drawing.Size(622, 244);
            this.ResultListView.SmallImageList = this.SmallImageList1;
            this.ResultListView.TabIndex = 7;
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            // 
            // LargeImageList1
            // 
            this.LargeImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LargeImageList1.ImageStream")));
            this.LargeImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.LargeImageList1.Images.SetKeyName(0, "docs_32.png");
            // 
            // SmallImageList1
            // 
            this.SmallImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallImageList1.ImageStream")));
            this.SmallImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.SmallImageList1.Images.SetKeyName(0, "docs_16.png");
            // 
            // ViewComboBox
            // 
            this.ViewComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ViewComboBox.FormattingEnabled = true;
            this.ViewComboBox.Items.AddRange(new object[] {
            "Large Item",
            "Small Item",
            "List Item"});
            this.ViewComboBox.Location = new System.Drawing.Point(198, 249);
            this.ViewComboBox.Name = "ViewComboBox";
            this.ViewComboBox.Size = new System.Drawing.Size(226, 21);
            this.ViewComboBox.TabIndex = 8;
            this.ViewComboBox.SelectedIndexChanged += new System.EventHandler(this.ViewComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "View Mode:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel3.Text = "Count:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ViewComboBox);
            this.Controls.Add(this.ResultListView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ResultListBox);
            this.Controls.Add(this.SearchOptionsPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Search Engine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SearchOptionsPanel.ResumeLayout(false);
            this.SearchOptionsPanel.PerformLayout();
            this.SearchPatternGroupBox.ResumeLayout(false);
            this.SearchPatternGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.CheckBox HiddenCheckBox;
        private System.Windows.Forms.Panel SearchOptionsPanel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExtensionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox ResultListBox;
        private System.Windows.Forms.CheckBox ReadOnlyCheckBox;
        private System.Windows.Forms.ToolStripStatusLabel ItemCountToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCountlable;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox SearchPatternGroupBox;
        private System.Windows.Forms.RadioButton NormalRadioButton;
        private System.Windows.Forms.RadioButton WholeWordRadioButton;
        private System.Windows.Forms.RadioButton MatchCaseRadioButton;
        private System.Windows.Forms.ListView ResultListView;
        private System.Windows.Forms.ImageList LargeImageList1;
        private System.Windows.Forms.ImageList SmallImageList1;
        private System.Windows.Forms.ComboBox ViewComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

