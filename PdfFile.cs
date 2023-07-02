using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class PdfFile : FileFactory
    {
        public override void Save(string Contents)
        {
            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
            try
            {
                PdfWriter.GetInstance(doc, new System.IO.FileStream("Contents.pdf", FileMode.Create));
                doc.Open();
                doc.Add(new iTextSharp.text.Paragraph(Contents));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to save file", MessageBoxButtons.OK);

            }
            finally
            {
                doc.Close();
            }
        }


    }
}

