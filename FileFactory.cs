using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class FileFactory
    {
        private string FileName { get; set; }
        private string Contents { get; set; }
        public virtual void Save( string Contents)
        {

        }
    }
}
