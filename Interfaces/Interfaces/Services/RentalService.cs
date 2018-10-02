using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Entities;

namespace Interfaces.Services
{
    //Serviço que calcula o preço da hora e do dia
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxService; //Declarando a interface

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService) //No construtor é setado o tipo de Taxa a ser cobrado (Injeção de dependencia)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start); //Subtrair as datas

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); //"Math.Ceiling" arredonda a hora pra cima
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment); //Chama o metodo para calculo da taxa em cima do valor do serviço

            carRental.Invoice = new Invoice(basicPayment, tax); //Processando o Invoice

        }
    }
}
