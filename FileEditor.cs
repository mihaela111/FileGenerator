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
            //create obj of Factory class
            FileFactory saveFile;

             if(radTxt.Checked)
            {
                //use subclass to redefine which object is instantiated
                saveFile = new TextFile();

                //leaf  & composite objects for composite pattern
                Leaf leaf1 = new Leaf("element 1");
                Leaf leaf2 = new Leaf("element 2");
                leaf1.SetText(textBox1.Text);
                leaf2.SetText(textBox1.Text);

                Composite composite = new Composite("Composite");

                //add leafs to composite
                composite.Components.Add(leaf1);
                composite.Components.Add(leaf2);

                saveFile.SaveComposite(composite);

                saveFile.Save(textBox1.Text);

            }
             else
            {


                saveFile = new PdfFile();
                saveFile.Save(textBox1.Text);

            }

        }
    }
}
