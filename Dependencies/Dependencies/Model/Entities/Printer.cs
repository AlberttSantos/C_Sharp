using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencies.Model.Entities
{
    internal class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Printer processing " + doc);
        }
        public void Print(string doc)
        {
            Console.WriteLine(SerialNumber+" Printer print "+doc);
        }
    }
}
