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
                textBox_goodsCharacter.Text = goods.GoodsCharacter;
                textBox_goodsAbout.Text = goods.GoodsAbout;
                textBox_goodsPrice.Text = Convert.ToString(goods.GoodsPrice);
                this.Text = "Редактирование товара";
            }
            else this.Text = "Добавление товара";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1_Date.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel1_Time.Text = DateTime.Now.ToLongTimeString();
        }




    }
}
