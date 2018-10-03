using Dependencies.Model.Entities;
using Dependencies.Model.Enums;

namespace Dependencies
{
    class Program
    {
        static void Main(string[] args)
        {
            //IShape circle = new Circle() { Radius = 2.0, Color = Color.White }; //Definir valores sem utilizar contrutor
            //System.Console.WriteLine(circle);

            Scanner scanner = new Scanner() { SerialNumber = 1080 };
            scanner.ProcessDoc("My doc");
            System.Console.WriteLine(scanner.Scan());

            Printer printer = new Printer() { SerialNumber = 1090 };
            printer.ProcessDoc("My printer");
            printer.Print("My printer");

            ComboDevices cb = new ComboDevices() { SerialNumber = 1010 };
            cb.ProcessDoc("My combo ");
            cb.Print("My print combo ");
            System.Console.WriteLine(cb.Scan());

        }
    }
}
