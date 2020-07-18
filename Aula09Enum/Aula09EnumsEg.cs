using System;
using Aula09Enum.Entities;
using Aula09Enum.Enums;

namespace Aula09Enum
{
    class Aula09EnumsEg
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
                
        }
    }
}
