﻿
using System.Collections.Generic;

namespace Aula14ExercicioFix.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;
        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
        public double Interest(double amount, int month)
        {
            return amount * MonthlyInterest * month;
        }
    }
}
