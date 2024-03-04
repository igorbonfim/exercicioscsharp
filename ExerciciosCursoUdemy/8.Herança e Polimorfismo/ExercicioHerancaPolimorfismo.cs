﻿using ExerciciosCursoUdemy._8.Herança_e_Polimorfismo.Entities;
using System.Globalization;

namespace ExerciciosCursoUdemy._8.Herança_e_Polimorfismo;
class ExercicioHerancaPolimorfismo
{
    public void Exercicio()
    {
        List<Product> products = new List<Product>();

        Console.Write("Enter the number of products: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Product #{i} data:");
            Console.Write("Common, used or imported? (c/u/i) : ");
            char response = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (response == 'u')
            {
                Console.Write("Manufactured date (DD/MM/YYYY): ");
                DateTime dt = DateTime.Parse(Console.ReadLine());
                products.Add(new UsedProduct(name, price, dt));
            }
            else if(response == 'i')
            {
                Console.Write("Customs Fee: ");
                double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                products.Add(new ImportedProduct(name, price, customsFee));
            }
            else
            {
                products.Add(new Product(name, price));
            }
        }

        Console.WriteLine();
        Console.WriteLine("PRICE TAGS:");
        foreach (Product item in products)
        {
            Console.WriteLine(item.PriceTag());
        }      
    }
}
