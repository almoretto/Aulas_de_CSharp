using Aula10Exerc1FIx.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula10Exerc1FIx
{
    /// <summary>
    /// Fazer um programa para ler os dados de N produtos (N fornecido pelo usuário). 
    /// Ao final, mostrar a etiqueta de preço de cada produto na mesma ordem em que foram digitados. 
    /// Todo produto possui nome e preço.Produtos importados possuem uma taxa de alfândega, e produtos usados possuem data de fabricação.
    /// Estes dados específicos devem ser acrescentados na etiqueta de preço conforme
    /// exemplo (próxima página). Para produtos importados, a taxa e alfândega deve ser acrescentada ao preço final do produto.
    /// Favor implementar o programa conforme projeto ao lado.
    /// </summary>
    class Aula10Exerc1FIx
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            char productType;
            List<Product> products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                productType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (productType == 'c' || productType == 'C')
                {
                    products.Add(new Product(name, price));
                }
                else if (productType == 'u' || productType == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (productType == 'i' || productType == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                {
                    Console.WriteLine("Invalid!!");
                    break;
                }    

            }//fim for

            Console.WriteLine("");
            Console.WriteLine("Price Tags: ");
            Console.WriteLine("");
            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceTag());

            }//fim Foreach

        }//fim main

    }//fim class

}//fim namespace
