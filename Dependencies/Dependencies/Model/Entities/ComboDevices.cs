using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencies.Model.Entities
{
    class ComboDevices : Device, IPrinter, IScanner
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Processing ComboDevice "+doc);
        }
        public void Print(string doc)
        {
            Console.WriteLine("Printer ComboDevice "+doc);
        }
        public string Scan()
        {
            return "Scanning ComboDevice ";
        }
    }
}
