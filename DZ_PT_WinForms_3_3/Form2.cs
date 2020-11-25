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
    public partial class Form2 : Form
    {
        public Form2(string textForEdit)
        {
            InitializeComponent();
            textBox_textEdit.Text = textForEdit;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2_Date.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel2_Time.Text = DateTime.Now.ToShortTimeString();
        }

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Простейший текстовый редактор.\nchmilrv@gmail.com", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveText()
        {
            


            SaveFileDialog save = new SaveFileDialog();//создали экземпляр
            save.DefaultExt = "txt";
            save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.Write(textBox_textEdit.Text); //записываем в файл содержимое поля
                writer.Close();//закрываем writer
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBox_textEdit.Font = fd.Font;
                MessageBox.Show(fd.Font.ToString(), "Вы выбрали шрифт: ");
            }
        }
    }
}
