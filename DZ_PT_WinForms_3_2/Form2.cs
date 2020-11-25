using System;
using System.Windows.Forms;

namespace DZ_PT_WinForms_3_2
{
    public partial class Form2 : Form
    {
        Goods goods;
        bool addNewgoods;
        public Form2(Goods goods, bool addNewgoods)
        {
            InitializeComponent();
            timer1.Start();
            this.addNewgoods = addNewgoods;
            this.goods = goods;
            if (!addNewgoods)
            {
                textBox_goodsName.Text = goods.GoodsName;
                richTextBox_goodsCharacter.Text = goods.GoodsCharacter;
                richTextBox_goodsAbout.Text = goods.GoodsAbout;
                numericUpDown_goodsPrice.Value = (Decimal)goods.GoodsPrice;
                this.Text = "Редактирование товара";
            }
            else this.Text = "Добавление товара";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1_Date.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel1_Time.Text = DateTime.Now.ToLongTimeString();
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            if (textBox_goodsName.Text == "" || richTextBox_goodsCharacter.Text == "" || richTextBox_goodsAbout.Text == "" || numericUpDown_goodsPrice.Value == 0)
            {
                MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (goods == null) goods = new Goods();
            goods.GoodsName = textBox_goodsName.Text;
            goods.GoodsCharacter = richTextBox_goodsCharacter.Text;
            goods.GoodsAbout = richTextBox_goodsAbout.Text;
            goods.GoodsPrice = (Double)numericUpDown_goodsPrice.Value;
            this.DialogResult = DialogResult.OK;
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
