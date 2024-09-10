using System;
using System.Collections;
using System.Collections.Generic;

namespace Alogithms_Quan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recursive recursive = new Recursive();
            MenuData menuData = new MenuData();


            Print("Test Funtion findProduct(\"MAIN\")");
            printProduct(Database.Instance.findProduct("MAIN"));
            Print("Test Funtion findProductByCategory()");
            printProducts(Database.Instance.findProductByCategory(4));
            Print("Test Funtion findProductByCategory()");
            printListName(Database.Instance.findProductByPrice(90));
            Print("Test Funtion sortByPrice()");
            printProducts(Database.Instance.sortByPrice());
            Print("Test Funtion sortByName()");
            printProducts(Database.Instance.sortByName());

            Print("Test Funtion sortByCategoryId()");
            printProducts(Database.Instance.sortByCategoryName());




            Print("Test Funtion mapProductByCategory()");
            printProducts(Database.Instance.mapProductByCategory(CategoryType.Memory));

            Print("Test Funtion minByPrice()");
            printProduct(Database.Instance.minByPrice());

            Print("Test Funtion maxByPrice()");
            printProduct(Database.Instance.maxByPrice());




            float salary = 100;
            int n = 10;
            Console.WriteLine($"TestCalSalaryNonRecursive(): {recursive.calSalaryNonRecursive(salary, n)}");
            Console.WriteLine($"TestCalSalaryRecursive(): {recursive.calSalaryRecursive(salary, n)}");


            Console.WriteLine($"calMonthNonRecursive(): {recursive.calMonthNonRecursive(1000, 10)}");
            Console.WriteLine($"calMonthRecursive(): {recursive.calMonthRecursive(1000, 10)}");




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
    }
}
