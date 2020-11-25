namespace DZ_PT_WinForms_3_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_addEditGoods = new System.Windows.Forms.Button();
            this.groupBox_goodsList = new System.Windows.Forms.GroupBox();
            this.richTextBox_about = new System.Windows.Forms.RichTextBox();
            this.richTextBox_character = new System.Windows.Forms.RichTextBox();
            this.label_goodsAbout = new System.Windows.Forms.Label();
            this.label_goodsCharacter = new System.Windows.Forms.Label();
            this.comboBox_goods = new System.Windows.Forms.ComboBox();
            this.label_priceTxt = new System.Windows.Forms.Label();
            this.label_goods = new System.Windows.Forms.Label();
            this.groupBox_goodsCart = new System.Windows.Forms.GroupBox();
            this.label_totalSummtxt = new System.Windows.Forms.Label();
            this.listBox_cart = new System.Windows.Forms.ListBox();
            this.button_clearCart = new System.Windows.Forms.Button();
            this.button_deleteFromCart = new System.Windows.Forms.Button();
            this.button_addToCart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1_mail = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_totalSumm = new System.Windows.Forms.TextBox();
            this.groupBox_goodsList.SuspendLayout();
            this.groupBox_goodsCart.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_addEditGoods
            // 
            this.button_addEditGoods.Location = new System.Drawing.Point(12, 12);
            this.button_addEditGoods.Name = "button_addEditGoods";
            this.button_addEditGoods.Size = new System.Drawing.Size(217, 36);
            this.button_addEditGoods.TabIndex = 0;
            this.button_addEditGoods.Text = "Добавить / Редактировать товар";
            this.button_addEditGoods.UseVisualStyleBackColor = true;
            this.button_addEditGoods.Click += new System.EventHandler(this.button_addEditGoods_Click);
            // 
            // groupBox_goodsList
            // 
            this.groupBox_goodsList.Controls.Add(this.textBox_price);
            this.groupBox_goodsList.Controls.Add(this.richTextBox_about);
            this.groupBox_goodsList.Controls.Add(this.richTextBox_character);
            this.groupBox_goodsList.Controls.Add(this.label_goodsAbout);
            this.groupBox_goodsList.Controls.Add(this.label_goodsCharacter);
            this.groupBox_goodsList.Controls.Add(this.comboBox_goods);
            this.groupBox_goodsList.Controls.Add(this.label_priceTxt);
            this.groupBox_goodsList.Controls.Add(this.label_goods);
            this.groupBox_goodsList.Location = new System.Drawing.Point(12, 63);
            this.groupBox_goodsList.Name = "groupBox_goodsList";
            this.groupBox_goodsList.Size = new System.Drawing.Size(400, 240);
            this.groupBox_goodsList.TabIndex = 1;
            this.groupBox_goodsList.TabStop = false;
            this.groupBox_goodsList.Text = "Список товаров";
            // 
            // richTextBox_about
            // 
            this.richTextBox_about.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_about.Location = new System.Drawing.Point(113, 127);
            this.richTextBox_about.Name = "richTextBox_about";
            this.richTextBox_about.ReadOnly = true;
            this.richTextBox_about.Size = new System.Drawing.Size(270, 60);
            this.richTextBox_about.TabIndex = 3;
            this.richTextBox_about.Text = "";
            // 
            // richTextBox_character
            // 
            this.richTextBox_character.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_character.Location = new System.Drawing.Point(113, 61);
            this.richTextBox_character.Name = "richTextBox_character";
            this.richTextBox_character.ReadOnly = true;
            this.richTextBox_character.Size = new System.Drawing.Size(270, 60);
            this.richTextBox_character.TabIndex = 2;
            this.richTextBox_character.Text = "";
            // 
            // label_goodsAbout
            // 
            this.label_goodsAbout.AutoSize = true;
            this.label_goodsAbout.Location = new System.Drawing.Point(19, 127);
            this.label_goodsAbout.Name = "label_goodsAbout";
            this.label_goodsAbout.Size = new System.Drawing.Size(60, 13);
            this.label_goodsAbout.TabIndex = 3;
            this.label_goodsAbout.Text = "Описание:";
            // 
            // label_goodsCharacter
            // 
            this.label_goodsCharacter.AutoSize = true;
            this.label_goodsCharacter.Location = new System.Drawing.Point(16, 61);
            this.label_goodsCharacter.Name = "label_goodsCharacter";
            this.label_goodsCharacter.Size = new System.Drawing.Size(93, 13);
            this.label_goodsCharacter.TabIndex = 4;
            this.label_goodsCharacter.Text = "Характеристика:";
            // 
            // comboBox_goods
            // 
            this.comboBox_goods.FormattingEnabled = true;
            this.comboBox_goods.Items.AddRange(new object[] {
            "Выберите товар..."});
            this.comboBox_goods.Location = new System.Drawing.Point(113, 26);
            this.comboBox_goods.Name = "comboBox_goods";
            this.comboBox_goods.Size = new System.Drawing.Size(270, 21);
            this.comboBox_goods.TabIndex = 1;
            this.comboBox_goods.Text = "Выберите товар...";
            this.comboBox_goods.SelectedIndexChanged += new System.EventHandler(this.comboBox_goods_SelectedIndexChanged);
            // 
            // label_priceTxt
            // 
            this.label_priceTxt.AutoSize = true;
            this.label_priceTxt.Location = new System.Drawing.Point(22, 205);
            this.label_priceTxt.Name = "label_priceTxt";
            this.label_priceTxt.Size = new System.Drawing.Size(36, 13);
            this.label_priceTxt.TabIndex = 0;
            this.label_priceTxt.Text = "Цена:";
            // 
            // label_goods
            // 
            this.label_goods.AutoSize = true;
            this.label_goods.Location = new System.Drawing.Point(16, 29);
            this.label_goods.Name = "label_goods";
            this.label_goods.Size = new System.Drawing.Size(86, 13);
            this.label_goods.TabIndex = 0;
            this.label_goods.Text = "Наименование:";
            // 
            // groupBox_goodsCart
            // 
            this.groupBox_goodsCart.Controls.Add(this.textBox_totalSumm);
            this.groupBox_goodsCart.Controls.Add(this.label_totalSummtxt);
            this.groupBox_goodsCart.Controls.Add(this.listBox_cart);
            this.groupBox_goodsCart.Controls.Add(this.button_clearCart);
            this.groupBox_goodsCart.Controls.Add(this.button_deleteFromCart);
            this.groupBox_goodsCart.Controls.Add(this.button_addToCart);
            this.groupBox_goodsCart.Location = new System.Drawing.Point(12, 309);
            this.groupBox_goodsCart.Name = "groupBox_goodsCart";
            this.groupBox_goodsCart.Size = new System.Drawing.Size(400, 240);
            this.groupBox_goodsCart.TabIndex = 2;
            this.groupBox_goodsCart.TabStop = false;
            this.groupBox_goodsCart.Text = "Корзина";
            // 
            // label_totalSummtxt
            // 
            this.label_totalSummtxt.AutoSize = true;
            this.label_totalSummtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_totalSummtxt.Location = new System.Drawing.Point(18, 203);
            this.label_totalSummtxt.Name = "label_totalSummtxt";
            this.label_totalSummtxt.Size = new System.Drawing.Size(64, 20);
            this.label_totalSummtxt.TabIndex = 4;
            this.label_totalSummtxt.Text = "Итого:";
            // 
            // listBox_cart
            // 
            this.listBox_cart.FormattingEnabled = true;
            this.listBox_cart.Location = new System.Drawing.Point(19, 66);
            this.listBox_cart.Name = "listBox_cart";
            this.listBox_cart.Size = new System.Drawing.Size(364, 108);
            this.listBox_cart.TabIndex = 3;
            // 
            // button_clearCart
            // 
            this.button_clearCart.Location = new System.Drawing.Point(293, 28);
            this.button_clearCart.Name = "button_clearCart";
            this.button_clearCart.Size = new System.Drawing.Size(90, 25);
            this.button_clearCart.TabIndex = 2;
            this.button_clearCart.Text = "Очистить";
            this.button_clearCart.UseVisualStyleBackColor = true;
            this.button_clearCart.Click += new System.EventHandler(this.button_clearCart_Click);
            // 
            // button_deleteFromCart
            // 
            this.button_deleteFromCart.Location = new System.Drawing.Point(157, 28);
            this.button_deleteFromCart.Name = "button_deleteFromCart";
            this.button_deleteFromCart.Size = new System.Drawing.Size(90, 25);
            this.button_deleteFromCart.TabIndex = 1;
            this.button_deleteFromCart.Text = "Удалить";
            this.button_deleteFromCart.UseVisualStyleBackColor = true;
            this.button_deleteFromCart.Click += new System.EventHandler(this.button_deleteFromCart_Click);
            // 
            // button_addToCart
            // 
            this.button_addToCart.Location = new System.Drawing.Point(22, 28);
            this.button_addToCart.Name = "button_addToCart";
            this.button_addToCart.Size = new System.Drawing.Size(90, 25);
            this.button_addToCart.TabIndex = 0;
            this.button_addToCart.Text = "Добавить";
            this.button_addToCart.UseVisualStyleBackColor = true;
            this.button_addToCart.Click += new System.EventHandler(this.button_addToCart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1_Date,
            this.toolStripStatusLabel1_Time,
            this.toolStripStatusLabel1_mail});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(424, 22);
            this.statusStrip1.TabIndex = 3;
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
            // textBox_price
            // 
            this.textBox_price.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_price.Location = new System.Drawing.Point(113, 202);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.ReadOnly = true;
            this.textBox_price.Size = new System.Drawing.Size(66, 20);
            this.textBox_price.TabIndex = 6;
            this.textBox_price.Text = "0,00";
            // 
            // textBox_totalSumm
            // 
            this.textBox_totalSumm.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_totalSumm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_totalSumm.Location = new System.Drawing.Point(113, 197);
            this.textBox_totalSumm.Name = "textBox_totalSumm";
            this.textBox_totalSumm.ReadOnly = true;
            this.textBox_totalSumm.Size = new System.Drawing.Size(104, 26);
            this.textBox_totalSumm.TabIndex = 6;
            this.textBox_totalSumm.Text = "0";
            this.textBox_totalSumm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 582);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox_goodsCart);
            this.Controls.Add(this.groupBox_goodsList);
            this.Controls.Add(this.button_addEditGoods);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DZ_PT_WinForms_3_2__Магазин";
            this.groupBox_goodsList.ResumeLayout(false);
            this.groupBox_goodsList.PerformLayout();
            this.groupBox_goodsCart.ResumeLayout(false);
            this.groupBox_goodsCart.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addEditGoods;
        private System.Windows.Forms.GroupBox groupBox_goodsList;
        private System.Windows.Forms.Label label_priceTxt;
        private System.Windows.Forms.Label label_goods;
        private System.Windows.Forms.ComboBox comboBox_goods;
        private System.Windows.Forms.GroupBox groupBox_goodsCart;
        private System.Windows.Forms.Button button_clearCart;
        private System.Windows.Forms.Button button_deleteFromCart;
        private System.Windows.Forms.Button button_addToCart;
        private System.Windows.Forms.Label label_totalSummtxt;
        private System.Windows.Forms.ListBox listBox_cart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1_Date;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1_Time;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1_mail;
        private System.Windows.Forms.RichTextBox richTextBox_about;
        private System.Windows.Forms.RichTextBox richTextBox_character;
        private System.Windows.Forms.Label label_goodsAbout;
        private System.Windows.Forms.Label label_goodsCharacter;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_totalSumm;
    }
}

