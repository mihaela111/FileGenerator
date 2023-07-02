using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class TextFile :FileFactory
    {
        public override void Save(string Contents)
        {
            TextWriter sw = new StreamWriter(Application.StartupPath + "\\SaveMethodContents.txt");

            try
            {
                sw.Write(Contents);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to save file", MessageBoxButtons.OK);

            }
            finally
            {
                sw.Close();
            }
        }
        public override void SaveComposite(Composite Contents)
        {

            try
            {
                Contents.ComposePdf();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to save file", MessageBoxButtons.OK);

            }

        }

    }
}
