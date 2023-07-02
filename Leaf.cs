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
    internal class Leaf : IComponent
    {
        private string _LeafName;
        private string _LeafContent;

        public Leaf(string name)
        {
            _LeafName = name;
            _LeafContent = name;
        }
        public void SetText(string Contents)
        {
            _LeafContent = Contents;
            
        }

        public string ReturnText()
        {
            return _LeafContent;
        }



    }
}
