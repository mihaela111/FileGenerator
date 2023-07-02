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
    public partial class FileGenerator : Form
    {
        public FileGenerator()
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
                Leaf nameLeaf = new Leaf("name");
                Leaf numberLeaf = new Leaf("number");
                Leaf detailsLeaf = new Leaf("details");
                nameLeaf.SetText(textBox1.Text);
                numberLeaf.SetText(textBox2.Text);
                detailsLeaf.SetText(textBox3.Text);

                Composite composite = new Composite("Composite");

                //add leafs to composite
                composite.Components.Add(nameLeaf);
                composite.Components.Add(numberLeaf);
                composite.Components.Add(detailsLeaf);

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
