namespace SearchDirectoriesAndFiles
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
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.TxtBrowseName = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GBSearchOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxDirectories = new System.Windows.Forms.CheckBox();
            this.checkBoxSearchFiles = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioBtnNormal = new System.Windows.Forms.RadioButton();
            this.radioBtnWholeName = new System.Windows.Forms.RadioButton();
            this.radioBtnMachCase = new System.Windows.Forms.RadioButton();
            this.checkBoxReadOnly = new System.Windows.Forms.CheckBox();
            this.checkBoxHiddenItem = new System.Windows.Forms.CheckBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtExtention = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.GBSearchOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBrowse.Location = new System.Drawing.Point(431, 12);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowse.TabIndex = 0;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TxtBrowseName
            // 
            this.TxtBrowseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBrowseName.Location = new System.Drawing.Point(2, 12);
            this.TxtBrowseName.Name = "TxtBrowseName";
            this.TxtBrowseName.ReadOnly = true;
            this.TxtBrowseName.Size = new System.Drawing.Size(411, 20);
            this.TxtBrowseName.TabIndex = 1;
            this.TxtBrowseName.Text = "C:\\Users\\test\\Desktop\\MineSweeper";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Location = new System.Drawing.Point(2, 212);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 33);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Extention";
            // 
            // GBSearchOptions
            // 
            this.GBSearchOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBSearchOptions.Controls.Add(this.checkBoxDirectories);
            this.GBSearchOptions.Controls.Add(this.checkBoxSearchFiles);
            this.GBSearchOptions.Controls.Add(this.groupBox1);
            this.GBSearchOptions.Controls.Add(this.checkBoxReadOnly);
            this.GBSearchOptions.Controls.Add(this.checkBoxHiddenItem);
            this.GBSearchOptions.Controls.Add(this.TxtName);
            this.GBSearchOptions.Controls.Add(this.TxtExtention);
            this.GBSearchOptions.Controls.Add(this.label2);
            this.GBSearchOptions.Controls.Add(this.label1);
            this.GBSearchOptions.Location = new System.Drawing.Point(2, 58);
            this.GBSearchOptions.Name = "GBSearchOptions";
            this.GBSearchOptions.Size = new System.Drawing.Size(504, 148);
            this.GBSearchOptions.TabIndex = 4;
            this.GBSearchOptions.TabStop = false;
            this.GBSearchOptions.Text = "Search Options";
            // 
            // checkBoxDirectories
            // 
            this.checkBoxDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDirectories.AutoSize = true;
            this.checkBoxDirectories.Checked = true;
            this.checkBoxDirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDirectories.Location = new System.Drawing.Point(10, 93);
            this.checkBoxDirectories.Name = "checkBoxDirectories";
            this.checkBoxDirectories.Size = new System.Drawing.Size(113, 17);
            this.checkBoxDirectories.TabIndex = 11;
            this.checkBoxDirectories.Text = "Search Directories";
            this.checkBoxDirectories.UseVisualStyleBackColor = true;
            // 
            // checkBoxSearchFiles
            // 
            this.checkBoxSearchFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSearchFiles.AutoSize = true;
            this.checkBoxSearchFiles.Location = new System.Drawing.Point(10, 116);
            this.checkBoxSearchFiles.Name = "checkBoxSearchFiles";
            this.checkBoxSearchFiles.Size = new System.Drawing.Size(84, 17);
            this.checkBoxSearchFiles.TabIndex = 10;
            this.checkBoxSearchFiles.Text = "Search Files";
            this.checkBoxSearchFiles.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.RadioBtnNormal);
            this.groupBox1.Controls.Add(this.radioBtnWholeName);
            this.groupBox1.Controls.Add(this.radioBtnMachCase);
            this.groupBox1.Location = new System.Drawing.Point(261, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 81);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Panel";
            // 
            // RadioBtnNormal
            // 
            this.RadioBtnNormal.AutoSize = true;
            this.RadioBtnNormal.Location = new System.Drawing.Point(11, 62);
            this.RadioBtnNormal.Name = "RadioBtnNormal";
            this.RadioBtnNormal.Size = new System.Drawing.Size(58, 17);
            this.RadioBtnNormal.TabIndex = 2;
            this.RadioBtnNormal.TabStop = true;
            this.RadioBtnNormal.Text = "Normal";
            this.RadioBtnNormal.UseVisualStyleBackColor = true;
            // 
            // radioBtnWholeName
            // 
            this.radioBtnWholeName.AutoSize = true;
            this.radioBtnWholeName.Location = new System.Drawing.Point(11, 39);
            this.radioBtnWholeName.Name = "radioBtnWholeName";
            this.radioBtnWholeName.Size = new System.Drawing.Size(87, 17);
            this.radioBtnWholeName.TabIndex = 1;
            this.radioBtnWholeName.TabStop = true;
            this.radioBtnWholeName.Text = "Whole Name";
            this.radioBtnWholeName.UseVisualStyleBackColor = true;
            // 
            // radioBtnMachCase
            // 
            this.radioBtnMachCase.AutoSize = true;
            this.radioBtnMachCase.Location = new System.Drawing.Point(11, 16);
            this.radioBtnMachCase.Name = "radioBtnMachCase";
            this.radioBtnMachCase.Size = new System.Drawing.Size(79, 17);
            this.radioBtnMachCase.TabIndex = 0;
            this.radioBtnMachCase.TabStop = true;
            this.radioBtnMachCase.Text = "Mach Case";
            this.radioBtnMachCase.UseVisualStyleBackColor = true;
            // 
            // checkBoxReadOnly
            // 
            this.checkBoxReadOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxReadOnly.AutoSize = true;
            this.checkBoxReadOnly.Checked = true;
            this.checkBoxReadOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxReadOnly.Location = new System.Drawing.Point(390, 25);
            this.checkBoxReadOnly.Name = "checkBoxReadOnly";
            this.checkBoxReadOnly.Size = new System.Drawing.Size(114, 17);
            this.checkBoxReadOnly.TabIndex = 8;
            this.checkBoxReadOnly.Text = "Include Read Only";
            this.checkBoxReadOnly.UseVisualStyleBackColor = true;
            // 
            // checkBoxHiddenItem
            // 
            this.checkBoxHiddenItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHiddenItem.AutoSize = true;
            this.checkBoxHiddenItem.Checked = true;
            this.checkBoxHiddenItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHiddenItem.Location = new System.Drawing.Point(261, 25);
            this.checkBoxHiddenItem.Name = "checkBoxHiddenItem";
            this.checkBoxHiddenItem.Size = new System.Drawing.Size(126, 17);
            this.checkBoxHiddenItem.TabIndex = 7;
            this.checkBoxHiddenItem.Text = "Include Hidden Items";
            this.checkBoxHiddenItem.UseVisualStyleBackColor = true;
            // 
            // TxtName
            // 
            this.TxtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtName.Location = new System.Drawing.Point(77, 58);
            this.TxtName.MaxLength = 50;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(119, 20);
            this.TxtName.TabIndex = 6;
            // 
            // TxtExtention
            // 
            this.TxtExtention.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtExtention.Location = new System.Drawing.Point(77, 26);
            this.TxtExtention.MaxLength = 50;
            this.TxtExtention.Name = "TxtExtention";
            this.TxtExtention.Size = new System.Drawing.Size(119, 20);
            this.TxtExtention.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // listViewResult
            // 
            this.listViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewResult.Location = new System.Drawing.Point(2, 251);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(527, 213);
            this.listViewResult.TabIndex = 10;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 463);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.GBSearchOptions);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtBrowseName);
            this.Controls.Add(this.BtnBrowse);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Files";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBSearchOptions.ResumeLayout(false);
            this.GBSearchOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TxtBrowseName;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBSearchOptions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioBtnNormal;
        private System.Windows.Forms.RadioButton radioBtnWholeName;
        private System.Windows.Forms.RadioButton radioBtnMachCase;
        private System.Windows.Forms.CheckBox checkBoxReadOnly;
        private System.Windows.Forms.CheckBox checkBoxHiddenItem;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtExtention;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.CheckBox checkBoxDirectories;
        private System.Windows.Forms.CheckBox checkBoxSearchFiles;
    }
}

