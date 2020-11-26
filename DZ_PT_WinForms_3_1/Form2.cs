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

namespace DZ_PT_WinForms_3_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_Date.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void button_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = false;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                comboBox_folder.Text = folderDialog.SelectedPath;
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            listBox_searchedFiles.Items.Clear();
            if (!String.IsNullOrEmpty(comboBox_folder.Text))
            {
                if (!comboBox_folder.Items.Contains(comboBox_folder.Text))
                    comboBox_folder.Items.Add(comboBox_folder.Text);
            }
            if (!String.IsNullOrEmpty(comboBox_fileTypes.Text))
            {
                if (!comboBox_fileTypes.Items.Contains(comboBox_fileTypes.Text))
                    comboBox_fileTypes.Items.Add(comboBox_fileTypes.Text);
            }
            try
            {
                string path = comboBox_folder.Text;
                string pattern = comboBox_fileTypes.Text;
                SearchOption searchOption;
                if (checkBox_AllDirectories.Checked)
                    searchOption = SearchOption.AllDirectories;
                else
                    searchOption = SearchOption.TopDirectoryOnly;
                int count = 0;
                string[] files = Directory.GetFiles(path, pattern, searchOption);
                foreach (string file in files)
                {
                    count++;
                    listBox_searchedFiles.Items.Add(count + ". " + file.Remove(0, file.LastIndexOf('\\') + 1));
                }
                toolStripStatusLabel_count_int.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
