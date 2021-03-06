﻿using System;
using Aula14InterfacesRentalCarSolvedProblem.Entities;

namespace Aula14InterfacesRentalCarSolvedProblem.Services
{
    //Especific class where the business rules is placed.
    class RentalServices
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        //instance of the service --==Interface==--
        private ITaxService _taxServices;
        public RentalServices(double pricePerHour, double pricePerDay, ITaxService taxService/*The parameter to the Interface*/)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxServices = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0d;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxServices.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
