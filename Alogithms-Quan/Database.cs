using System.Collections.Generic;

namespace Alogithms_Quan
{
    internal class Database
    {
        private Database() { }
        private static Database instance;
        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }

        private List<Product> productTable = new List<Product>()
        {
            new Product("CPU", 750, 10, 1),
            new Product("RAM", 50, 2, 2),
            new Product("HDD", 70, 1, 2),
            new Product("MAIN", 400, 3, 1),
            new Product("KEYBOARD", 30, 8, 4),
            new Product("MOUSE", 25, 50, 4),
            new Product("VGA", 60, 35, 3),
            new Product("MONITOR", 120, 28, 2),
            new Product("CASE", 120, 28, 5),
        };
        private List<Category> categoryTable = new List<Category>()
        {
            new Category(1, "Computer"),
            new Category(2, "Memory"),
            new Category(3, "Card"),
            new Category(4, "Acesory"),
        };

        public Product findProduct(string nameProduct)
        {
            for (int i = 0; i < productTable.Count; i++)
            {
                if (productTable[i].Name == nameProduct)
                {
                    return productTable[i];
                }
            }
            return null;
        }

        public List<Product> findProductByCategory(int categoryId)
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < productTable.Count; i++)
            {
                if (productTable[i].CategoryId == categoryId)
                {
                    products.Add(productTable[i]);
                }
            }
            return products;
        }

        public List<string> findProductByPrice(int price)
        {
            List<string> listName = new List<string>();
            for (int i = 0; i < productTable.Count; i++)
            {
                if (productTable[i].Price <= price)
                {
                    listName.Add(productTable[i].Name);
                }
            }
            return listName;
        }

        public List<Product> sortByPrice()
        {
            List<Product> sortedProducts = productTable;
            bool haveSwap = false;
            for (int i = 0; i < sortedProducts.Count - 1; i++)
            {
                haveSwap = false;
                for (int j = 0; j < sortedProducts.Count - i - 1; j++)
                {
                    if (sortedProducts[j].Price > sortedProducts[j + 1].Price)
                    {
                        Product p = sortedProducts[j];
                        sortedProducts[j] = sortedProducts[j + 1];
                        sortedProducts[j + 1] = p;
                        haveSwap = true;
                    }
                }

                if (haveSwap == false)
                {
                    break;
                }
            }
            return sortedProducts;
        }

        public List<Product> sortByName()
        {
            List<Product> sortedProducts = productTable;
            Product valueToInsert;
            int holePosition;
            for (int i = 0; i < sortedProducts.Count; i++)
            {
                valueToInsert = sortedProducts[i];
                holePosition = i;
                while (holePosition > 0 && sortedProducts[holePosition - 1].Name.Length < valueToInsert.Name.Length)
                {
                    sortedProducts[holePosition] = sortedProducts[holePosition - 1];
                    holePosition--;
                }
                if (holePosition != i)
                {
                    sortedProducts[holePosition] = valueToInsert;
                }
            }
            return sortedProducts;
        }

        public List<Product> sortByCategoryId()
        {
            return null;
        }
    }
}
