using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_PT_WinForms_3_2
{
    public partial class Form1 : Form
    {
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
            if (comboBox_goods.SelectedIndex == -1)
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
                // Запоминаем выделенный элемент
                int n = comboBox_goods.SelectedIndex;

                // Забираем ссылку на выделенный элемент
                goods = (Goods)comboBox_goods.Items[n];
                Form2 editform = new Form2(goods, false);
                if (editform.ShowDialog() == DialogResult.OK)
                {
                    //Удаляем выделенный элемент
                    comboBox_goods.Items.RemoveAt(n);

                    // И добавляем его снова в ту же позицию, чтобы он перерисовался в списке
                    comboBox_goods.Items.Insert(n, goods);

                    // Снова выделяем этот элемент
                    comboBox_goods.SelectedIndex = n;
                }
            } 
        }

        private void button_addToCart_Click(object sender, EventArgs e)
        {





        }

        private void button_clearCart_Click(object sender, EventArgs e)
        {
            listBox_cart.Items.Clear();
        }
    }
}
