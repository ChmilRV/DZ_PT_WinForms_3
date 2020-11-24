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
            this.groupBox_addEditGoods = new System.Windows.Forms.GroupBox();
            this.textBox_goodsName = new System.Windows.Forms.TextBox();
            this.label_goodsName = new System.Windows.Forms.Label();
            this.label_goodsCharacter = new System.Windows.Forms.Label();
            this.textBox_goodsCharacter = new System.Windows.Forms.TextBox();
            this.label_goodsAbout = new System.Windows.Forms.Label();
            this.textBox_goodsAbout = new System.Windows.Forms.TextBox();
            this.label_goodsPrice = new System.Windows.Forms.Label();
            this.textBox_goodsPrice = new System.Windows.Forms.TextBox();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1_mail = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox_addEditGoods.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_addEditGoods
            // 
            this.groupBox_addEditGoods.Controls.Add(this.label_goodsPrice);
            this.groupBox_addEditGoods.Controls.Add(this.label_goodsAbout);
            this.groupBox_addEditGoods.Controls.Add(this.label_goodsCharacter);
            this.groupBox_addEditGoods.Controls.Add(this.textBox_goodsPrice);
            this.groupBox_addEditGoods.Controls.Add(this.textBox_goodsAbout);
            this.groupBox_addEditGoods.Controls.Add(this.label_goodsName);
            this.groupBox_addEditGoods.Controls.Add(this.textBox_goodsCharacter);
            this.groupBox_addEditGoods.Controls.Add(this.textBox_goodsName);
            this.groupBox_addEditGoods.Location = new System.Drawing.Point(32, 29);
            this.groupBox_addEditGoods.Name = "groupBox_addEditGoods";
            this.groupBox_addEditGoods.Size = new System.Drawing.Size(442, 218);
            this.groupBox_addEditGoods.TabIndex = 0;
            this.groupBox_addEditGoods.TabStop = false;
            this.groupBox_addEditGoods.Text = "groupBox1";
            // 
            // textBox_goodsName
            // 
            this.textBox_goodsName.Location = new System.Drawing.Point(99, 35);
            this.textBox_goodsName.Name = "textBox_goodsName";
            this.textBox_goodsName.Size = new System.Drawing.Size(251, 20);
            this.textBox_goodsName.TabIndex = 0;
            // 
            // label_goodsName
            // 
            this.label_goodsName.AutoSize = true;
            this.label_goodsName.Location = new System.Drawing.Point(7, 38);
            this.label_goodsName.Name = "label_goodsName";
            this.label_goodsName.Size = new System.Drawing.Size(86, 13);
            this.label_goodsName.TabIndex = 1;
            this.label_goodsName.Text = "Наименование:";
            // 
            // label_goodsCharacter
            // 
            this.label_goodsCharacter.AutoSize = true;
            this.label_goodsCharacter.Location = new System.Drawing.Point(6, 77);
            this.label_goodsCharacter.Name = "label_goodsCharacter";
            this.label_goodsCharacter.Size = new System.Drawing.Size(93, 13);
            this.label_goodsCharacter.TabIndex = 1;
            this.label_goodsCharacter.Text = "Характеристика:";
            // 
            // textBox_goodsCharacter
            // 
            this.textBox_goodsCharacter.Location = new System.Drawing.Point(99, 74);
            this.textBox_goodsCharacter.Name = "textBox_goodsCharacter";
            this.textBox_goodsCharacter.Size = new System.Drawing.Size(251, 20);
            this.textBox_goodsCharacter.TabIndex = 0;
            // 
            // label_goodsAbout
            // 
            this.label_goodsAbout.AutoSize = true;
            this.label_goodsAbout.Location = new System.Drawing.Point(6, 124);
            this.label_goodsAbout.Name = "label_goodsAbout";
            this.label_goodsAbout.Size = new System.Drawing.Size(60, 13);
            this.label_goodsAbout.TabIndex = 1;
            this.label_goodsAbout.Text = "Описание:";
            // 
            // textBox_goodsAbout
            // 
            this.textBox_goodsAbout.Location = new System.Drawing.Point(100, 117);
            this.textBox_goodsAbout.Name = "textBox_goodsAbout";
            this.textBox_goodsAbout.Size = new System.Drawing.Size(251, 20);
            this.textBox_goodsAbout.TabIndex = 0;
            // 
            // label_goodsPrice
            // 
            this.label_goodsPrice.AutoSize = true;
            this.label_goodsPrice.Location = new System.Drawing.Point(7, 167);
            this.label_goodsPrice.Name = "label_goodsPrice";
            this.label_goodsPrice.Size = new System.Drawing.Size(36, 13);
            this.label_goodsPrice.TabIndex = 1;
            this.label_goodsPrice.Text = "Цена:";
            // 
            // textBox_goodsPrice
            // 
            this.textBox_goodsPrice.Location = new System.Drawing.Point(99, 164);
            this.textBox_goodsPrice.Name = "textBox_goodsPrice";
            this.textBox_goodsPrice.Size = new System.Drawing.Size(251, 20);
            this.textBox_goodsPrice.TabIndex = 0;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(61, 272);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(110, 32);
            this.button_Ok.TabIndex = 1;
            this.button_Ok.Text = "Сохранить";
            this.button_Ok.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(233, 272);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(110, 32);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1_Date,
            this.toolStripStatusLabel1_Time,
            this.toolStripStatusLabel1_mail});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(565, 22);
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
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 395);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.groupBox_addEditGoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.groupBox_addEditGoods.ResumeLayout(false);
            this.groupBox_addEditGoods.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_addEditGoods;
        private System.Windows.Forms.Label label_goodsPrice;
        private System.Windows.Forms.Label label_goodsAbout;
        private System.Windows.Forms.Label label_goodsCharacter;
        private System.Windows.Forms.TextBox textBox_goodsPrice;
        private System.Windows.Forms.TextBox textBox_goodsAbout;
        private System.Windows.Forms.Label label_goodsName;
        private System.Windows.Forms.TextBox textBox_goodsCharacter;
        private System.Windows.Forms.TextBox textBox_goodsName;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1_Date;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1_Time;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1_mail;
        private System.Windows.Forms.Timer timer1;
    }
}