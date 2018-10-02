using System;
using System.Globalization;
using Interfaces.Entities;
using Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/mm/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture); //Pegar a data digitada
            Console.Write("Return (dd/mm/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double PriceperHour = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            Console.Write("Enter price per day: ");
            double PriceperDay = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture); 

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(PriceperHour, PriceperDay, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental); //Processar a fatura
            Console.WriteLine(carRental.Invoice); //Exibir na tela com toString

            
        }
    }
}
