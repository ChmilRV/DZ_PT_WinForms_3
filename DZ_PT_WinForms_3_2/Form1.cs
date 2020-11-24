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

        private void button_addEditGoods_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
