using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace DZ_PT_WinForms_3_3
{
    public partial class Form2 : Form
    {
        public Form2(Form1 form1, string textForEdit)
        {
            InitializeComponent();
            textBox_textEdit.Text = textForEdit;
            timer1.Start();
        }

        public string TText
        {
            get { return textBox_textEdit.Text; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2_Date.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel2_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Простейший текстовый редактор.\nchmilrv@gmail.com", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Save_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Cancel_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button_font_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                textBox_textEdit.Font = fd.Font;
        }

        internal PrintPreviewDialog PrintPreviewDialog1;
        private PrintDocument document = new PrintDocument();

        private void InitializePrintPreviewDialog()
        {
            PrintPreviewDialog1 = new PrintPreviewDialog();
            PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            PrintPreviewDialog1.Location = new System.Drawing.Point(29, 29);
            PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
            PrintPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
            PrintPreviewDialog1.UseAntiAlias = true;
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox_textEdit.Text, textBox_textEdit.Font, System.Drawing.Brushes.Black, 20, 20);
        }

        private void button_PrintPreviewDialog_Click(object sender, EventArgs e)
        {
            InitializePrintPreviewDialog();
            PrintPreviewDialog1.Document = document;
            PrintPreviewDialog1.ShowDialog();
        }

        private void button_PageSetupDialog_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageSetupDialog = new PageSetupDialog();
            pageSetupDialog.PageSettings = new PageSettings();
            pageSetupDialog.PrinterSettings = new PrinterSettings();
            pageSetupDialog.ShowNetwork = false;
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                string[] results = new string[]
                {
                    pageSetupDialog.PageSettings.Margins.ToString(),
                    pageSetupDialog.PageSettings.PaperSize.ToString(),
                    pageSetupDialog.PageSettings.Landscape.ToString(),
                    pageSetupDialog.PrinterSettings.PrinterName.ToString(),
                    pageSetupDialog.PrinterSettings.PrintRange.ToString()
                };
                textBox_textEdit.AutoCompleteCustomSource.AddRange(results);
            }
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }
    }
}
