using iTextSharp.text;
using iTextSharp.text.pdf;
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

namespace WindowsFormsApp1
{
    public partial class FileEditor : Form
    {
        public FileEditor()
        {
            InitializeComponent();
        }



        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //create obj of base class
            FileFactory newFile;

             if(radTxt.Checked)
            {
                //call save text subclass
                newFile = new SaveTextFile();
                newFile.Save(textBox1.Text);

            }
             else
            {
                newFile = new SavePdfFile();
                newFile.Save(textBox1.Text);
                /*  saveFile = new SavePdfFile();
                   using (SaveFileDialog sfd = new SaveFileDialog(){ Filter = "PDF file|*.pdf", ValidateNames = true })
                   {
                       if (sfd.ShowDialog() == DialogResult.OK)
                       {
                           //iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                           //try
                           //{
                           //    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                           //    doc.Open();
                           //    doc.Add(new iTextSharp.text.Paragraph(richTextBox.Text));
                           //}
                           //catch (Exception ex)
                           //{
                           //    MessageBox.Show(ex.Message, "Unable to save file", MessageBoxButtons.OK);

                           //}
                           //finally
                           //{
                           //    doc.Close();
                           //}


                       }
                   }*/
            }

        }
    }
}
