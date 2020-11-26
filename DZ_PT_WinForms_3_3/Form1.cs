using System;
using System.IO;
using System.Windows.Forms;

namespace DZ_PT_WinForms_3_3
{
    public partial class Form1 : Form
    {

        bool isChanged = false;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1_Date.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel1_Time.Text = DateTime.Now.ToLongTimeString();
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
                SaveFile_ToolStripMenuItem.Enabled = true;
            }
        }

        private void SaveFile()
        {
            SaveFileDialog save = new SaveFileDialog();//создали экземпляр
            save.DefaultExt = "txt";
            save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.Write(textBox_textOpen.Text); //записываем в файл содержимое поля
                writer.Close();//закрываем writer
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this, textBox_textOpen.Text);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                textBox_textOpen.Text=(form2.TText);
                isChanged = true;
            }
        }

        private void SaveFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isChanged)
            {
                if (MessageBox.Show("Документ был изменен.\nСохранить файл?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    SaveFileDialog save = new SaveFileDialog();//создали экземпляр
                    save.DefaultExt = "txt";
                    save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter writer = new StreamWriter(save.FileName);
                        writer.Write(textBox_textOpen.Text); //записываем в файл содержимое поля
                        writer.Close();//закрываем writer
                    }
                }
            }
        }
    }
}
