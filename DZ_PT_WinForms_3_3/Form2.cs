using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_PT_WinForms_3_3
{
    public partial class Form2 : Form
    {
        public Form2(Form1 form1, string textForEdit)
        {
            InitializeComponent();
            textBox_textEdit.Text = textForEdit;
            //textBox_textEdit.
            timer1.Start();

            //comboBox_font.Items.AddRange();
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

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Save_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button_font_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBox_textEdit.Font = fd.Font;
            }
        }

        internal PrintPreviewDialog PrintPreviewDialog1;
        private PrintDocument document = new PrintDocument();

        private void InitializePrintPreviewDialog()
        {
            // Create a new PrintPreviewDialog using constructor.
            this.PrintPreviewDialog1 = new PrintPreviewDialog();

            //Set the size, location, and name.
            this.PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog1.Location = new System.Drawing.Point(29, 29);
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";

            // Associate the event-handling method with the 
            // document's PrintPage event.
            this.document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(document_PrintPage);

            // Set the minimum size the dialog can be resized to.
            this.PrintPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);

            // Set the UseAntiAlias property to true, which will allow the 
            // operating system to smooth fonts.
            this.PrintPreviewDialog1.UseAntiAlias = true;
        }

        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Insert code to render the page here.
            // This code will be called when the PrintPreviewDialog.Show 
            // method is called.

            e.Graphics.DrawString(textBox_textEdit.Text, textBox_textEdit.Font, System.Drawing.Brushes.Black, 20, 20);
        }

        private void button_PrintPreviewDialog_Click(object sender, EventArgs e)
        {
            InitializePrintPreviewDialog();

            document.DocumentName = "Text";

            // Set the PrintPreviewDialog.Document property to
            // the PrintDocument object selected by the user.
            PrintPreviewDialog1.Document = document;

            // Call the ShowDialog method. This will trigger the document's
            //  PrintPage event.
            PrintPreviewDialog1.ShowDialog();



        }

        private void button_PageSetupDialog_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageSetupDialog = new PageSetupDialog();
            // Initialize the dialog's PrinterSettings property to hold user
            // defined printer settings.
            pageSetupDialog.PageSettings = new System.Drawing.Printing.PageSettings();

            // Initialize dialog's PrinterSettings property to hold user
            // set printer settings.
            pageSetupDialog.PrinterSettings = new System.Drawing.Printing.PrinterSettings();

            //Do not show the network in the printer dialog.
            pageSetupDialog.ShowNetwork = false;

            //Show the dialog storing the result.
            DialogResult result = pageSetupDialog.ShowDialog();

            // If the result is OK, display selected settings in
            // ListBox1. These values can be used when printing the
            // document.
            if (result == DialogResult.OK)
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
