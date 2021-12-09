using System;
using System.Windows.Forms;
using Aspose.Pdf;
using System.Diagnostics;
using System.IO;
using Microsoft.Office.Interop.Word;
using MaterialSkin;

namespace Arka_s_PDOCX_Solutions
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        
        public Form1()
        {
            InitializeComponent();
           
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange500, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Green500, Accent.Red700, MaterialSkin.TextShade.BLACK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorProgressBar1.Value = 0;
            lblStatus.Text = " ";
            lblPercentage.Text = " ";
            PDFTODOCXtexts();
            DOCXTOPDFtexts();
        }

        private void colorProgressBar1_Click(object sender, EventArgs e)
        {
            MaterialMessageBox.Show("Not everything in the world is meant to be clicked!!!", "Arka's PDOCX-Solutions.", MessageBoxButtons.OK);
        }

        OpenFileDialog fd1 = new OpenFileDialog();
        private void btnBrowsePDF_Click(object sender, EventArgs e)
        {
            fd1.Filter = "PDF Files.|*.pdf";
            fd1.InitialDirectory = "C:\\Users\\" + Environment.UserName + "\\Documents";
            fd1.Title = "Arka's PDOCX-Solutions";
            if (fd1.ShowDialog() == DialogResult.OK)
            {
                txtPDF.Text = fd1.FileName.ToString();
            }
        }

        FolderBrowserDialog fd2 = new FolderBrowserDialog();
        private void btnSave_Click(object sender, EventArgs e)
        {
            string pdffilename = Path.GetFileNameWithoutExtension(txtPDF.Text);
            if (fd2.ShowDialog() == DialogResult.OK)
            {
                txtSave.Text = fd2.SelectedPath.ToString() + "\\" + pdffilename + ".docx";
                lblStatus.Text = "Waiting for conversion to begin...";
                lblPercentage.Text = "0 %";
            }
        }

        private void btnConvert2_Click(object sender, EventArgs e)
        {
            if (txtPDF.Text != String.Empty && txtSave.Text != String.Empty)
            {


                try
                {
                    //Converting pdf to docx...


                    var pdfile = new Aspose.Pdf.Document(txtPDF.Text);
                    pdfile.Save(txtSave.Text, SaveFormat.DocX);


                }
                catch (Exception ex)
                {
                    MaterialMessageBox.Show(ex.ToString(),"Exception",MessageBoxButtons.OK);
                }

                //Deleting the Trial version message for Aspose.pdf...


                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document doc = app.Documents.Open(txtSave.Text);
                var textToFind = "Evaluation Only. Created with Aspose.PDF. Copyright 2002-2020 Aspose Pty Ltd.";
                var textToReplace = "";
                var matchCase = true;
                var matchWholeWord = true;
                var matchWildcards = false;
                var matchSoundsLike = false;
                var matchAllWordForms = false;
                var forward = true;
                var wrap = 1;
                var format = false;
                var replace = 2;

                app.Selection.Find.Execute(
                    textToFind,
                    matchCase,
                    matchWholeWord,
                    matchWildcards,
                    matchSoundsLike,
                    matchAllWordForms,
                    forward,
                    wrap,
                    format,
                    textToReplace,
                    replace);
                doc.Close();
                app.Quit();

                colorProgressBar1.Invoke((Action)delegate
                {
                    string zipfilename = Path.GetFileNameWithoutExtension(txtPDF.Text);
                    lblStatus.Text = "Conversion of " + zipfilename + ".pdf completed...";
                    colorProgressBar1.Minimum = 0;
                    colorProgressBar1.Maximum = 100;
                    colorProgressBar1.Value = 100;
                    lblPercentage.Text = colorProgressBar1.Value.ToString() + " %";
                });


                //Starting the converted docx file...
                Process.Start(txtSave.Text);
            }
            else
                MaterialMessageBox.Show("Please select some files first!!!", "Arka's PDOCX-Solutions.", MessageBoxButtons.OK);
        }


        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            colorProgressBar1.Value = 0;
            lblPercentage.Text = " ";
            lblStatus.Text = " ";
            txtPDF.Clear();
            txtSave.Clear();
            PDFTODOCXtexts();
            MaterialMessageBox.Show("All fields are cleared.", "Arka's PDOCX-Solutions", MessageBoxButtons.OK);
        }

        OpenFileDialog fd3 = new OpenFileDialog();
        private void btnBrowseDOCX_Click(object sender, EventArgs e)
        {
            fd3.Filter = "Word documents (.doc)|*.docx;*.doc";
            fd3.InitialDirectory = "C:\\Users\\" + Environment.UserName + "\\Documents";
            fd3.Title = "Arka's PDOCX-Solutions";
            if (fd3.ShowDialog() == DialogResult.OK)
            {
                txtDOCX.Text = fd3.FileName.ToString();
            }
        }

        FolderBrowserDialog fd4 = new FolderBrowserDialog();
        private void btnSave2_Click(object sender, EventArgs e)
        {
            string docxfilename = Path.GetFileNameWithoutExtension(txtDOCX.Text);
            if (fd4.ShowDialog() == DialogResult.OK)
            {
                txtsave2.Text = fd4.SelectedPath.ToString() + "\\" + docxfilename + ".pdf";
                lblStatus.Text = "Waiting for conversion to begin...";
                lblPercentage.Text = "0 %";
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtDOCX.Text != String.Empty && txtsave2.Text != String.Empty)
            {


                Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
                wordDocument = appWord.Documents.Open(txtDOCX.Text);


                try
                {
                    string ext = System.IO.Path.GetExtension(txtsave2.Text);
                    switch (ext)
                    {
                        case ".pdf":
                            wordDocument.ExportAsFixedFormat(txtsave2.Text, WdExportFormat.wdExportFormatPDF);
                            break;
                        case ".docx":
                            wordDocument.ExportAsFixedFormat(txtsave2.Text, WdExportFormat.wdExportFormatPDF);
                            break;
                    }

                    colorProgressBar1.Invoke((Action)delegate
                    {
                        string docxfilename = Path.GetFileNameWithoutExtension(txtsave2.Text);
                        lblStatus.Text = "Conversion of " + docxfilename + ".docx completed...";
                        colorProgressBar1.Minimum = 0;
                        colorProgressBar1.Maximum = 100;
                        colorProgressBar1.Value = 100;
                        lblPercentage.Text = colorProgressBar1.Value.ToString() + " %";
                    });

                    wordDocument.Close();
                    appWord.Quit();

                }
                catch (Exception ex)
                {
                    MaterialMessageBox.Show(ex.ToString(),"Exception",MessageBoxButtons.OK);
                }
                System.Diagnostics.Process.Start(txtsave2.Text);
            }
            else
                MaterialMessageBox.Show("Please select some files first!!!", "Arka's PDOCX-Solutions.", MessageBoxButtons.OK);
        }

        public Microsoft.Office.Interop.Word.Document wordDocument { get; set; }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            colorProgressBar1.Value = 0;
            lblPercentage.Text = " ";
            lblStatus.Text = " ";
            txtDOCX.Clear();
            txtsave2.Clear();
            DOCXTOPDFtexts();
            MaterialMessageBox.Show("All fields are cleared.", "Arka's PDOCX-Solutions", MessageBoxButtons.OK);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MaterialMessageBox.Show("Do you really want to exit?","Arka's PDOCX-Solutions",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel = true;
            }


        }

        private void PDFTODOCXtexts()
        {
            txtPDF.Hint = "Browse PDF files...";
            txtSave.Hint = "Browse save location...";
        }

        private void DOCXTOPDFtexts()
        {
            txtDOCX.Hint = "Browse DOCX files...";
            txtsave2.Hint = "Browse save location...";
        }

        private void txtPDF_Click(object sender, EventArgs e)
        {
            txtPDF.Enabled = false;
            MaterialMessageBox.Show("Could not select text field!", "Arka's PDOCX-Solutions.", MessageBoxButtons.OK);
            txtPDF.Enabled = true;
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            txtSave.Enabled = false;
            MaterialMessageBox.Show("Could not select text field!", "Arka's PDOCX-Solutions.", MessageBoxButtons.OK);
            txtSave.Enabled= true;
        }

        private void txtDOCX_Click(object sender, EventArgs e)
        {
            txtDOCX.Enabled = false;
            MaterialMessageBox.Show("Could not select text field!", "Arka's PDOCX-Solutions.", MessageBoxButtons.OK);
            txtDOCX.Enabled = true;
        }

        private void txtsave2_Click(object sender, EventArgs e)
        {
            txtsave2.Enabled = false;
            MaterialMessageBox.Show("Could not select text field!", "Arka's PDOCX-Solutions.", MessageBoxButtons.OK);
            txtsave2.Enabled = true;
        }

        private void colorcolorProgressBar1_Click(object sender, EventArgs e)
        {
            MaterialMessageBox.Show("Not everything in the world is meant to be clicked!!!", "Arka's PDOCX-Solutions.", MessageBoxButtons.OK);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MaterialMessageBox.Show("Made in C# .NET Framework for conversions in PDF and Word (DOCX) format.\n Made by : Arkadip Nandan.", "Arka's PDOCX-Solutions | v1.0", MessageBoxButtons.OK);
        }
    }

}
