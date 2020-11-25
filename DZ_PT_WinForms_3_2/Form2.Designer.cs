namespace DZ_PT_WinForms_3_2
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
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1_mail = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_goodsName = new System.Windows.Forms.TextBox();
            this.textBox_goodsCharacter = new System.Windows.Forms.TextBox();
            this.label_goodsName = new System.Windows.Forms.Label();
            this.textBox_goodsAbout = new System.Windows.Forms.TextBox();
            this.label_goodsCharacter = new System.Windows.Forms.Label();
            this.label_goodsAbout = new System.Windows.Forms.Label();
            this.label_goodsPrice = new System.Windows.Forms.Label();
            this.numericUpDown_goodsPrice = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_goodsPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(61, 272);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(110, 32);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(233, 272);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(110, 32);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1_Date,
            this.toolStripStatusLabel1_Time,
            this.toolStripStatusLabel1_mail});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(571, 22);
            this.statusStrip1.TabIndex = 4;
            // 
            // toolStripStatusLabel1_Date
            // 
            this.toolStripStatusLabel1_Date.Name = "toolStripStatusLabel1_Date";
            this.toolStripStatusLabel1_Date.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1_Time
            // 
            this.toolStripStatusLabel1_Time.Name = "toolStripStatusLabel1_Time";
            this.toolStripStatusLabel1_Time.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1_mail
            // 
            this.toolStripStatusLabel1_mail.IsLink = true;
            this.toolStripStatusLabel1_mail.Name = "toolStripStatusLabel1_mail";
            this.toolStripStatusLabel1_mail.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusLabel1_mail.Text = "chmilrv@gmail.com";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_goodsName
            // 
            this.textBox_goodsName.Location = new System.Drawing.Point(111, 30);
            this.textBox_goodsName.Name = "textBox_goodsName";
            this.textBox_goodsName.Size = new System.Drawing.Size(251, 20);
            this.textBox_goodsName.TabIndex = 0;
            // 
            // textBox_goodsCharacter
            // 
            this.textBox_goodsCharacter.Location = new System.Drawing.Point(111, 69);
            this.textBox_goodsCharacter.Name = "textBox_goodsCharacter";
            this.textBox_goodsCharacter.Size = new System.Drawing.Size(251, 20);
            this.textBox_goodsCharacter.TabIndex = 0;
            // 
            // label_goodsName
            // 
            this.label_goodsName.AutoSize = true;
            this.label_goodsName.Location = new System.Drawing.Point(19, 33);
            this.label_goodsName.Name = "label_goodsName";
            this.label_goodsName.Size = new System.Drawing.Size(86, 13);
            this.label_goodsName.TabIndex = 1;
            this.label_goodsName.Text = "Наименование:";
            // 
            // textBox_goodsAbout
            // 
            this.textBox_goodsAbout.Location = new System.Drawing.Point(112, 112);
            this.textBox_goodsAbout.Name = "textBox_goodsAbout";
            this.textBox_goodsAbout.Size = new System.Drawing.Size(251, 20);
            this.textBox_goodsAbout.TabIndex = 0;
            // 
            // label_goodsCharacter
            // 
            this.label_goodsCharacter.AutoSize = true;
            this.label_goodsCharacter.Location = new System.Drawing.Point(18, 72);
            this.label_goodsCharacter.Name = "label_goodsCharacter";
            this.label_goodsCharacter.Size = new System.Drawing.Size(93, 13);
            this.label_goodsCharacter.TabIndex = 1;
            this.label_goodsCharacter.Text = "Характеристика:";
            // 
            // label_goodsAbout
            // 
            this.label_goodsAbout.AutoSize = true;
            this.label_goodsAbout.Location = new System.Drawing.Point(18, 119);
            this.label_goodsAbout.Name = "label_goodsAbout";
            this.label_goodsAbout.Size = new System.Drawing.Size(60, 13);
            this.label_goodsAbout.TabIndex = 1;
            this.label_goodsAbout.Text = "Описание:";
            // 
            // label_goodsPrice
            // 
            this.label_goodsPrice.AutoSize = true;
            this.label_goodsPrice.Location = new System.Drawing.Point(19, 162);
            this.label_goodsPrice.Name = "label_goodsPrice";
            this.label_goodsPrice.Size = new System.Drawing.Size(36, 13);
            this.label_goodsPrice.TabIndex = 1;
            this.label_goodsPrice.Text = "Цена:";
            // 
            // numericUpDown_goodsPrice
            // 
            this.numericUpDown_goodsPrice.DecimalPlaces = 2;
            this.numericUpDown_goodsPrice.Location = new System.Drawing.Point(116, 163);
            this.numericUpDown_goodsPrice.Name = "numericUpDown_goodsPrice";
            this.numericUpDown_goodsPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_goodsPrice.TabIndex = 2;
            this.numericUpDown_goodsPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 395);
            this.Controls.Add(this.numericUpDown_goodsPrice);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label_goodsPrice);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label_goodsAbout);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_goodsCharacter);
            this.Controls.Add(this.textBox_goodsAbout);
            this.Controls.Add(this.label_goodsName);
            this.Controls.Add(this.textBox_goodsName);
            this.Controls.Add(this.textBox_goodsCharacter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_goodsPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1_Date;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1_Time;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1_mail;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_goodsName;
        private System.Windows.Forms.TextBox textBox_goodsCharacter;
        private System.Windows.Forms.Label label_goodsName;
        private System.Windows.Forms.TextBox textBox_goodsAbout;
        private System.Windows.Forms.Label label_goodsCharacter;
        private System.Windows.Forms.Label label_goodsAbout;
        private System.Windows.Forms.Label label_goodsPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown_goodsPrice;
    }
}