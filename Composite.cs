using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Composite : IComponent
    {
        public List<IComponent> Components = new List<IComponent>();
        private string _PdfCompositeName;
        private string _ComponentData;

        public Composite(string name)
        {
            _PdfCompositeName = name;
            _ComponentData=name;
        }

        public string ReturnText()
        {
            return _PdfCompositeName;
        }
        public void ComposePdf ()
        {
            TextWriter sw = new StreamWriter(Application.StartupPath + "\\Contents.txt");
            foreach (IComponent component in Components)
            {
                sw.WriteLine(component.ReturnText());
            }
            sw.Close();
        }

        public void SetText(string data)
        {
            throw new NotImplementedException();
        }
    }
}
