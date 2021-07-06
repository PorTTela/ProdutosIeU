using System;
using ProdutosIeU.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ProdutosIeU
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Quantos produtos serão cadastrados? ");
            int nProdutos = int.Parse(Console.ReadLine());
            for(int n = 0; n < nProdutos; n++)
            {
                Console.WriteLine($"Produto #{n+1}:");
                Console.Write("Produto Comum, Usado ou Importado (C/U/I)? ");
                char tipoProduto = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipoProduto == 'I' || tipoProduto == 'i')
                {
                    Console.Write("Taxa de Envio: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                } 
                else if(tipoProduto == 'U' || tipoProduto == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    list.Add(new Product(name, price));
                }

            }
            
            Console.WriteLine("");
            Console.WriteLine("PREÇOS:");
            foreach(Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
