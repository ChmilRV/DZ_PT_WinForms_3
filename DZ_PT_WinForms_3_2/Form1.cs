using System;
using System.Windows.Forms;
/*Фирма продает составляющие компьютера...*/
namespace DZ_PT_WinForms_3_2
{
    public partial class Form1 : Form
    {
        double totalSumm = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

        }
        Form2 form2 = null;
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1_Date.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel1_Time.Text = DateTime.Now.ToLongTimeString();
        }
        Goods goods = null;
        private void button_addEditGoods_Click(object sender, EventArgs e)
        {
            if (comboBox_goods.SelectedIndex == 0)
            {
                goods = new Goods();
                Form2 addForm = new Form2(goods, true);
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    comboBox_goods.Items.Add(goods);
                }
            }
            else
            {
                int n = comboBox_goods.SelectedIndex;
                goods = (Goods)comboBox_goods.Items[n];
                Form2 editform = new Form2(goods, false);
                if (editform.ShowDialog() == DialogResult.OK)
                {
                    comboBox_goods.Items.RemoveAt(n);
                    comboBox_goods.Items.Insert(n, goods);
                    comboBox_goods.SelectedIndex = n;
                }
            } 
        }
        private void button_addToCart_Click(object sender, EventArgs e)
        {
            if (comboBox_goods.SelectedIndex == 0)
            {
                MessageBox.Show("Вы не выбрали товар");
                return;
            }
            else
            {
                goods = (Goods)comboBox_goods.SelectedItem;
                listBox_cart.Items.Add(goods);
                totalSumm = Convert.ToDouble(textBox_totalSumm.Text);
                totalSumm += goods.GoodsPrice;
                textBox_totalSumm.Text = totalSumm.ToString();
            }
        }
        private void button_deleteFromCart_Click(object sender, EventArgs e)
        {
            if (listBox_cart.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали товар");
                return;
            }
            goods = (Goods)listBox_cart.SelectedItem;
            totalSumm = Convert.ToDouble(textBox_totalSumm.Text);
            totalSumm -= goods.GoodsPrice;
            textBox_totalSumm.Text = totalSumm.ToString();
            listBox_cart.Items.Remove(goods);
        }
        private void button_clearCart_Click(object sender, EventArgs e)
        {
            listBox_cart.Items.Clear();
            totalSumm = 0;
            textBox_totalSumm.Text = totalSumm.ToString();
        }
        private void comboBox_goods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_goods.SelectedIndex != 0)
            {
                goods = (Goods)comboBox_goods.SelectedItem;
                richTextBox_character.Text = goods.GoodsCharacter;
                richTextBox_about.Text = goods.GoodsAbout;
                textBox_price.Text = goods.GoodsPrice.ToString();
            }
            else
            {
                richTextBox_character.Clear();
                richTextBox_about.Clear();
                textBox_price.Clear();
            }
        }
    }
}
