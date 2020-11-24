namespace DZ_PT_WinForms_3_1
{
    partial class Form2
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_folder = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox_fileTypes = new System.Windows.Forms.ComboBox();
            this.label_patternForSearch = new System.Windows.Forms.Label();
            this.label_folderForSearch = new System.Windows.Forms.Label();
            this.comboBox_folder = new System.Windows.Forms.ComboBox();
            this.button_search = new System.Windows.Forms.Button();
            this.checkBox_AllDirectories = new System.Windows.Forms.CheckBox();
            this.listBox_searchedFiles = new System.Windows.Forms.ListBox();
            this.toolStripStatusLabel_countTXT = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_count_int = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_folder
            // 
            this.button_folder.Location = new System.Drawing.Point(376, 15);
            this.button_folder.Name = "button_folder";
            this.button_folder.Size = new System.Drawing.Size(56, 23);
            this.button_folder.TabIndex = 0;
            this.button_folder.Text = "Папка";
            this.button_folder.UseVisualStyleBackColor = true;
            this.button_folder.Click += new System.EventHandler(this.button_folder_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Date,
            this.toolStripStatusLabel_Time,
            this.toolStripStatusLabel_countTXT,
            this.toolStripStatusLabel_count_int,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(535, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Date
            // 
            this.toolStripStatusLabel_Date.Name = "toolStripStatusLabel_Date";
            this.toolStripStatusLabel_Date.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel_Time
            // 
            this.toolStripStatusLabel_Time.Name = "toolStripStatusLabel_Time";
            this.toolStripStatusLabel_Time.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusLabel1.Text = "chmilrv@gmail.com";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox_fileTypes
            // 
            this.comboBox_fileTypes.FormattingEnabled = true;
            this.comboBox_fileTypes.Location = new System.Drawing.Point(96, 46);
            this.comboBox_fileTypes.Name = "comboBox_fileTypes";
            this.comboBox_fileTypes.Size = new System.Drawing.Size(274, 21);
            this.comboBox_fileTypes.Sorted = true;
            this.comboBox_fileTypes.TabIndex = 3;
            // 
            // label_patternForSearch
            // 
            this.label_patternForSearch.AutoSize = true;
            this.label_patternForSearch.Location = new System.Drawing.Point(6, 49);
            this.label_patternForSearch.Name = "label_patternForSearch";
            this.label_patternForSearch.Size = new System.Drawing.Size(84, 13);
            this.label_patternForSearch.TabIndex = 4;
            this.label_patternForSearch.Text = "Искать файлы:";
            // 
            // label_folderForSearch
            // 
            this.label_folderForSearch.AutoSize = true;
            this.label_folderForSearch.Location = new System.Drawing.Point(6, 18);
            this.label_folderForSearch.Name = "label_folderForSearch";
            this.label_folderForSearch.Size = new System.Drawing.Size(81, 13);
            this.label_folderForSearch.TabIndex = 4;
            this.label_folderForSearch.Text = "Место поиска:";
            // 
            // comboBox_folder
            // 
            this.comboBox_folder.FormattingEnabled = true;
            this.comboBox_folder.Location = new System.Drawing.Point(96, 15);
            this.comboBox_folder.Name = "comboBox_folder";
            this.comboBox_folder.Size = new System.Drawing.Size(274, 21);
            this.comboBox_folder.Sorted = true;
            this.comboBox_folder.TabIndex = 3;
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.Location = new System.Drawing.Point(376, 44);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(154, 23);
            this.button_search.TabIndex = 0;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // checkBox_AllDirectories
            // 
            this.checkBox_AllDirectories.AutoSize = true;
            this.checkBox_AllDirectories.Checked = true;
            this.checkBox_AllDirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AllDirectories.Location = new System.Drawing.Point(438, 19);
            this.checkBox_AllDirectories.Name = "checkBox_AllDirectories";
            this.checkBox_AllDirectories.Size = new System.Drawing.Size(92, 17);
            this.checkBox_AllDirectories.TabIndex = 6;
            this.checkBox_AllDirectories.Text = "Подкаталоги";
            this.checkBox_AllDirectories.UseVisualStyleBackColor = true;
            // 
            // listBox_searchedFiles
            // 
            this.listBox_searchedFiles.FormattingEnabled = true;
            this.listBox_searchedFiles.Location = new System.Drawing.Point(9, 73);
            this.listBox_searchedFiles.Name = "listBox_searchedFiles";
            this.listBox_searchedFiles.Size = new System.Drawing.Size(521, 446);
            this.listBox_searchedFiles.TabIndex = 7;
            // 
            // toolStripStatusLabel_countTXT
            // 
            this.toolStripStatusLabel_countTXT.Name = "toolStripStatusLabel_countTXT";
            this.toolStripStatusLabel_countTXT.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel_countTXT.Text = "Найдено файлов: ";
            // 
            // toolStripStatusLabel_count_int
            // 
            this.toolStripStatusLabel_count_int.Name = "toolStripStatusLabel_count_int";
            this.toolStripStatusLabel_count_int.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel_count_int.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 552);
            this.Controls.Add(this.listBox_searchedFiles);
            this.Controls.Add(this.checkBox_AllDirectories);
            this.Controls.Add(this.label_folderForSearch);
            this.Controls.Add(this.label_patternForSearch);
            this.Controls.Add(this.comboBox_folder);
            this.Controls.Add(this.comboBox_fileTypes);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_folder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "DZ_PT_WinForms_3_1__Find_files";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_folder;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Date;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Time;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox comboBox_fileTypes;
        private System.Windows.Forms.Label label_patternForSearch;
        private System.Windows.Forms.Label label_folderForSearch;
        private System.Windows.Forms.ComboBox comboBox_folder;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.CheckBox checkBox_AllDirectories;
        private System.Windows.Forms.ListBox listBox_searchedFiles;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_countTXT;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_count_int;
    }
}