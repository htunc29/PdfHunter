using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PdfHunter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] pdfDosyalari;
        string directory;
        private void PdfOkuVeAra(string dosyaYolu, string kelime)
        {
            using (PdfReader reader = new PdfReader(dosyaYolu))
            {
                using (PdfDocument pdfDoc = new PdfDocument(reader))
                {
                    for (int i = 1; i <= pdfDoc.GetNumberOfPages(); i++)
                    {
                        string text = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(i));

                        if (text.Contains(kelime))
                        {
                            this.Invoke((Action)(() =>
                            {
                                listBox1.Items.Add($"{Path.GetFileName(dosyaYolu)} - {kelime} bulundu!");
                            }));
                        }
                    }
                }
            }
        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
           
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                listBox2.Items.Clear();
                directory = dialog.SelectedPath;
                guna2TextBox2.Text = directory;
                pdfDosyalari = Directory.GetFiles(directory, "*.pdf");
                guna2ProgressBar1.Maximum = pdfDosyalari.Length;
                guna2ProgressBar1.Value = 0;
                listBox2.Items.AddRange(pdfDosyalari);
                MessageBox.Show("Tüm dosyalar getirildi!", "Bitti");
            }
        }

        private async void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(pdfDosyalari==null|| pdfDosyalari.Length==0)
            {
                MessageBox.Show("Lütfen önce bir klasör seçin ve içinde pdf dosyalarının olduğundan emin olun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listBox1.Items.Clear();
            guna2ProgressBar1.Value = 0;
            guna2ProgressBar1.Maximum = pdfDosyalari.Length;
            guna2TaskBarProgress1.Value = 0;
            guna2TaskBarProgress1.Maximum=pdfDosyalari.Length;
            string arananKelime = guna2TextBox1.Text;
            List<Task> tasks = new List<Task>();
            foreach (string dosya in pdfDosyalari)
            {
                tasks.Add(Task.Run(() => PdfOkuVeAra(dosya, arananKelime)));
                guna2ProgressBar1.Value += 1;
                guna2TaskBarProgress1.Value += 1;
            }
            await Task.WhenAll(tasks);
            MessageBox.Show("Tüm dosyalar tarandı!", "Bitti");
        }
    }
}
