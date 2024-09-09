using System;
using System.Collections.Generic;

namespace Alogithms_Quan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print("Test Funtion findProduct()");
            printProduct(Database.Instance.findProduct("MAIN"));
            Print("Test Funtion findProductByCategory()");
            printProducts(Database.Instance.findProductByCategory(4));
            Print("Test Funtion findProductByCategory()");
            printListName(Database.Instance.findProductByPrice(90));
            Print("Test Funtion sortByPrice()");
            printProducts(Database.Instance.sortByPrice());
            Print("Test Funtion sortByName()");
            printProducts(Database.Instance.sortByName());




            testSortString("gefacb");
        }

        static void printProducts(List<Product> entitys)
        {
            for (int i = 0; i < entitys.Count; i++)
            {
                Product product = entitys[i];
                Console.WriteLine($"Name: {product.Name} Price: {product.Price} Quantity: {product.Quantity} CategoryId: {product.CategoryId}");
            }
            Console.WriteLine("\n \n");
        }

        static void printProduct(Product product)
        {
            
            Console.WriteLine($"Name: {product.Name} Price: {product.Price} Quantity: {product.Quantity} CategoryId: {product.CategoryId}");
            Console.WriteLine("\n \n");

        }

        static void printListName(List<string> listName)
        {
            
            Console.Write("List Name: ");
            for (int i = 0; i < listName.Count; i++)
            {
                Console.Write($"{listName[i]} ,");
            }
            Console.WriteLine("\n \n");
        }

        static void Print(string text)
        {
            Console.WriteLine(text);
        }



        static void testSortString(string text)
        {
            char[] chars = text.ToCharArray();
            Array.Sort(chars);
            Console.WriteLine(new string(chars));
        }
    }
}
