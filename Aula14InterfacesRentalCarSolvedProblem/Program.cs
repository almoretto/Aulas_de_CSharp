using System;
using System.Globalization;
using Aula14InterfacesRentalCarSolvedProblem.Entities;
using Aula14InterfacesRentalCarSolvedProblem.Services;

namespace Aula14InterfacesRentalCarSolvedProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double pHour = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);
            Console.Write("Enter price per day: ");
            double pDay = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            //Injection of dependency with BrazilTaxService and TaxService
            RentalServices rentalServices = new RentalServices(pHour, pDay, new BrazilTaxServices());
            
            rentalServices.ProcessInvoice(carRental);
            Console.WriteLine(carRental.Invoice);
        }
    }
}
