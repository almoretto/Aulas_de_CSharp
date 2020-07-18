using System;
using System.Globalization;

namespace Aula09FixationExerc01
{
    class Aula09FixationExerc01
    {
        /// <summary>
        /// Ler os dados de um pedido com N itens (N fornecido pelo usuário). Depois, mostrar um sumário 
        /// do pedido conforme exemplo(próxima página). Nota: o instante do pedido deve ser o instante 
        /// do sistema: DateTime.Now
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Order order1 = new Order();
            int n = 0;
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            order1.Client.Name = Console.ReadLine();
            Console.Write("E-mail: ");
            order1.Client.Email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            order1.Client.BirthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Order Status: ");
            order1.Moment = DateTime.Now;
            order1.Status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                Console.Write("Product price: ");
                double pPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int qty = int.Parse(Console.ReadLine());
                Product p = new Product(pName, pPrice);
                OrderItem item = new OrderItem(qty, p);
                order1.AddItens(item);
            }

            
            Console.WriteLine(order1);
           
        }
    }
}
