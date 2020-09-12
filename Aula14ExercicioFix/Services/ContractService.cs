using Aula14ExercicioFix.Entities;
using System;

namespace Aula14ExercicioFix.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double baseValue = contract.TotalValue / months;
            for (int i = 1; i < months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = baseValue + _onlinePaymentService.Interest(baseValue, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(baseValue);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }

    }
}
