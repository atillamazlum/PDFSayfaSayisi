using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;

namespace PDFSayfaSayisi
{
    public partial class PDFSayfa : Form
    {
        public PDFSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string targetDirectory = @TextDizin.Text;
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
            {
                PdfReader pdfReader = new PdfReader(fileName);
                int numberOfPages = pdfReader.NumberOfPages;
                if (int.TryParse(label1.Text, out int currentNumber))
                {
                    label1.Text = (currentNumber + numberOfPages).ToString();
                }
                else
                {
                    label1.Text = numberOfPages.ToString();
                }
            }
        }

        private void BtnGozat_MouseClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog fbdKlasorler = new FolderBrowserDialog();

            fbdKlasorler.ShowDialog();

            string secilenDizin = fbdKlasorler.SelectedPath;

            TextDizin.Text = secilenDizin;

        }
    }
}
