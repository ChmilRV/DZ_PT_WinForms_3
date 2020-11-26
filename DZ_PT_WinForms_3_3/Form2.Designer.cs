namespace DZ_PT_WinForms_3_3
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
            this.textBox_textEdit = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cancel_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.About_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2_mail = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_font = new System.Windows.Forms.Button();
            this.button_PrintPreviewDialog = new System.Windows.Forms.Button();
            this.button_PageSetupDialog = new System.Windows.Forms.Button();
            this.button_Print = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_textEdit
            // 
            this.textBox_textEdit.Location = new System.Drawing.Point(12, 27);
            this.textBox_textEdit.Multiline = true;
            this.textBox_textEdit.Name = "textBox_textEdit";
            this.textBox_textEdit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_textEdit.Size = new System.Drawing.Size(596, 501);
            this.textBox_textEdit.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem,
            this.Edit_ToolStripMenuItem,
            this.Help_ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File_ToolStripMenuItem
            // 
            this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit_ToolStripMenuItem});
            this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
            this.File_ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.File_ToolStripMenuItem.Text = "Файл";
            // 
            // Exit_ToolStripMenuItem
            // 
            this.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
            this.Exit_ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.Exit_ToolStripMenuItem.Text = "Выход";
            this.Exit_ToolStripMenuItem.Click += new System.EventHandler(this.Exit_ToolStripMenuItem_Click);
            // 
            // Edit_ToolStripMenuItem
            // 
            this.Edit_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_ToolStripMenuItem,
            this.Cancel_ToolStripMenuItem});
            this.Edit_ToolStripMenuItem.Name = "Edit_ToolStripMenuItem";
            this.Edit_ToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.Edit_ToolStripMenuItem.Text = "Редактировать";
            // 
            // Save_ToolStripMenuItem
            // 
            this.Save_ToolStripMenuItem.Name = "Save_ToolStripMenuItem";
            this.Save_ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.Save_ToolStripMenuItem.Text = "Сохранить";
            this.Save_ToolStripMenuItem.Click += new System.EventHandler(this.Save_ToolStripMenuItem_Click);
            // 
            // Cancel_ToolStripMenuItem
            // 
            this.Cancel_ToolStripMenuItem.Name = "Cancel_ToolStripMenuItem";
            this.Cancel_ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.Cancel_ToolStripMenuItem.Text = "Отменить";
            this.Cancel_ToolStripMenuItem.Click += new System.EventHandler(this.Cancel_ToolStripMenuItem_Click);
            // 
            // Help_ToolStripMenuItem1
            // 
            this.Help_ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About_ToolStripMenuItem1});
            this.Help_ToolStripMenuItem1.Name = "Help_ToolStripMenuItem1";
            this.Help_ToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.Help_ToolStripMenuItem1.Text = "Справка";
            // 
            // About_ToolStripMenuItem1
            // 
            this.About_ToolStripMenuItem1.Name = "About_ToolStripMenuItem1";
            this.About_ToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.About_ToolStripMenuItem1.Text = "О программе";
            this.About_ToolStripMenuItem1.Click += new System.EventHandler(this.About_ToolStripMenuItem1_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(8, 536);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(123, 31);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(144, 536);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(123, 31);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Отменить";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2_Date,
            this.toolStripStatusLabel2_Time,
            this.toolStripStatusLabel2_mail});
            this.statusStrip1.Location = new System.Drawing.Point(0, 575);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(620, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2_Date
            // 
            this.toolStripStatusLabel2_Date.Name = "toolStripStatusLabel2_Date";
            this.toolStripStatusLabel2_Date.Size = new System.Drawing.Size(147, 17);
            this.toolStripStatusLabel2_Date.Text = "toolStripStatusLabel2_Date";
            // 
            // toolStripStatusLabel2_Time
            // 
            this.toolStripStatusLabel2_Time.Name = "toolStripStatusLabel2_Time";
            this.toolStripStatusLabel2_Time.Size = new System.Drawing.Size(150, 17);
            this.toolStripStatusLabel2_Time.Text = "toolStripStatusLabel2_Time";
            // 
            // toolStripStatusLabel2_mail
            // 
            this.toolStripStatusLabel2_mail.IsLink = true;
            this.toolStripStatusLabel2_mail.Name = "toolStripStatusLabel2_mail";
            this.toolStripStatusLabel2_mail.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusLabel2_mail.Text = "chmilrv@gmail.com";
            // 
            // button_font
            // 
            this.button_font.Location = new System.Drawing.Point(288, 536);
            this.button_font.Name = "button_font";
            this.button_font.Size = new System.Drawing.Size(75, 31);
            this.button_font.TabIndex = 6;
            this.button_font.Text = "Шрифт";
            this.button_font.UseVisualStyleBackColor = true;
            this.button_font.Click += new System.EventHandler(this.button_font_Click);
            // 
            // button_PrintPreviewDialog
            // 
            this.button_PrintPreviewDialog.Location = new System.Drawing.Point(368, 536);
            this.button_PrintPreviewDialog.Name = "button_PrintPreviewDialog";
            this.button_PrintPreviewDialog.Size = new System.Drawing.Size(75, 31);
            this.button_PrintPreviewDialog.TabIndex = 7;
            this.button_PrintPreviewDialog.Text = "Preview";
            this.button_PrintPreviewDialog.UseVisualStyleBackColor = true;
            this.button_PrintPreviewDialog.Click += new System.EventHandler(this.button_PrintPreviewDialog_Click);
            // 
            // button_PageSetupDialog
            // 
            this.button_PageSetupDialog.Location = new System.Drawing.Point(448, 536);
            this.button_PageSetupDialog.Name = "button_PageSetupDialog";
            this.button_PageSetupDialog.Size = new System.Drawing.Size(75, 31);
            this.button_PageSetupDialog.TabIndex = 8;
            this.button_PageSetupDialog.Text = "Page Setup";
            this.button_PageSetupDialog.UseVisualStyleBackColor = true;
            this.button_PageSetupDialog.Click += new System.EventHandler(this.button_PageSetupDialog_Click);
            // 
            // button_Print
            // 
            this.button_Print.Location = new System.Drawing.Point(528, 536);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(80, 31);
            this.button_Print.TabIndex = 9;
            this.button_Print.Text = "Print";
            this.button_Print.UseVisualStyleBackColor = true;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 597);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.button_PageSetupDialog);
            this.Controls.Add(this.button_PrintPreviewDialog);
            this.Controls.Add(this.button_font);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox_textEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DZ_PT_WinForms_3_3_EditForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_textEdit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Cancel_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Help_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem About_ToolStripMenuItem1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2_Date;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2_Time;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2_mail;
        private System.Windows.Forms.Button button_font;
        private System.Windows.Forms.ToolStripMenuItem Save_ToolStripMenuItem;
        private System.Windows.Forms.Button button_PrintPreviewDialog;
        private System.Windows.Forms.Button button_PageSetupDialog;
        private System.Windows.Forms.Button button_Print;
    }
}