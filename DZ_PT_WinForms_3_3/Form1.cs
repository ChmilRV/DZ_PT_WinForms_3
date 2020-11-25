using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_PT_WinForms_3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1_Date.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel1_Time.Text = DateTime.Now.ToShortTimeString();
        }

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Простейший текстовый редактор.\nchmilrv@gmail.com","О программе",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button_loadFile_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void Load_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void LoadFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt||";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                textBox_textOpen.Text = reader.ReadToEnd();
                reader.Close();
                button_edit.Enabled = true;
                EditText_ToolStripMenuItem.Enabled = true;
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(textBox_textOpen.Text);
            form2.ShowDialog();


        }
    }
}
