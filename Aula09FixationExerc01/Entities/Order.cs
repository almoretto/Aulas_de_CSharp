using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula09FixationExerc01
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; } = new Client();
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItens(OrderItem item)
        {
            OrderItems.Add(item);
        }
        public void RemoveItems(OrderItem item)
        {
            OrderItems.Remove(item);
        }
        public double Total()
        {
            double total = 0.0;
            foreach (OrderItem item in OrderItems)
            {
                total += item.SubTotal();
            }
            return total;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine("***********************************************************");
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (");
            sb.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.Append(") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("======================================");
            sb.AppendLine("Order items:");
            foreach (OrderItem item in OrderItems)
            {
                sb.Append(item.Product.Name);
                sb.Append(", ");
                sb.Append(item.Price.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                sb.Append(", Quantity: ");
                sb.Append(item.Quantity);
                sb.Append(", Subtotal: ");
                sb.AppendLine(item.SubTotal().ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            }
            sb.Append("Total price: ");
            sb.AppendLine(Total().ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            sb.AppendLine("***********************************************************");
            return sb.ToString();
        }
    }
}

/*ORDER SUMMARY:
Order moment: 20/04/2018 11:25:09
Order status: Processing
Client: Alex Green (15/03/1985) - alex@gmail.com
Order items:
TV, $1000.00, Quantity: 1, Subtotal: $1000.00
Mouse, $40.00, Quantity: 2, Subtotal: $80.00
Total price: $1080.00

 ToString("C",CultureInfo.CreateSpecificCulture("pt-BR"))*/
