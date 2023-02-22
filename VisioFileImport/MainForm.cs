using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace VisioFileImport
{
    public partial class MainForm : Form
    {
        static List<string> supportedFileTypes;

        public MainForm()
        {
            InitializeComponent();
            supportedFileTypes = new List<string>();
            supportedFileTypes.Add(".svg");
            supportedFileTypes.Add(".png");
            supportedFileTypes.Add(".jpg");
            supportedFileTypes.Add(".jpeg");
            supportedFileTypes.Add(".gif");
            supportedFileTypes.Add(".bmp");
        }



        private void tbInputFolder_TextChanged(object sender, EventArgs e)
        {
            if(Directory.Exists(tb_inputPath.Text) && !File.Exists(tb_outputPath.Text) && tb_outputPath.Text != "")
            {
                btn_generate.Enabled = true;
            }
            else
            {
                btn_generate.Enabled = false;
            }
        }

        private void tbOutputPath_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(tb_inputPath.Text) && !File.Exists(tb_outputPath.Text) && tb_outputPath.Text != "")
            {
                btn_generate.Enabled = true;
            }
            else
            {
                btn_generate.Enabled = false;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Processing p = new Processing();
            int top = this.Top;
            int left = this.Left;
            p.StartPosition = FormStartPosition.Manual;
            p.Location = new System.Drawing.Point(left + 275, top + 50);
            p.Show();
            try
            {
                string fileInputPath = tb_inputPath.Text;
                string outputFile = tb_outputPath.Text;

                Microsoft.Office.Interop.Visio.Application app = new Microsoft.Office.Interop.Visio.Application();
                app.Visible = false;
                Microsoft.Office.Interop.Visio.Document doc = app.Documents.Add("");
                int pageIndex = 1;

                string[] files = Directory.GetFiles(fileInputPath);
                foreach (string file in files)
                {
                    if (SupportedFileType(file))
                    {
                        Microsoft.Office.Interop.Visio.Pages pgs = doc.Pages;
                        pgs[pageIndex].Name = RemoveFileType(Path.GetFileName(file));
                        pgs[pageIndex].Import(file);
                        doc.Pages.Add();
                        pageIndex++;
                    }

                }

                app.ActiveDocument.SaveAs(outputFile);
                doc.Close();
                app.Quit();
                p.Close();
                MessageBox.Show("Visio File Created: " + outputFile,"Success" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SupportedFileType(string filePath)
        {
            foreach(var supportedFileType in supportedFileTypes)
            {
                if (filePath.EndsWith(supportedFileType))
                    return true;
            }

            return false;
        }

        private string RemoveFileType(string fileName)
        {
            foreach(var supportedFileType in supportedFileTypes)
            {
                fileName = fileName.Replace(supportedFileType, "");
            }
            return fileName;
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            fbd_input.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            DialogResult result = fbd_input.ShowDialog();
            if(result == DialogResult.OK)
            {
                tb_inputPath.Text = fbd_input.SelectedPath;
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            fbd_output.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            DialogResult result = fbd_output.ShowDialog();
            string fileName = "visio";
            string fileType = ".vsdx";
            if (tb_inputPath.Text != "")
                fileName = Path.GetFileName(tb_inputPath.Text);
            if(result == DialogResult.OK)
            {
                tb_outputPath.Text = fbd_output.SelectedPath + @"\" + fileName + fileType;
            }

        }
    }
}
