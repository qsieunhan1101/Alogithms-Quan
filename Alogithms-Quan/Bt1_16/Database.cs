using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace Alogithms_Quan
{
    public enum CategoryType
    {
        Computer = 0,
        Memory = 1,
        Card = 2,
        Acesory = 3,
    }

    internal class Database
    {
        /// <summary>
        /// Singleton Design Pattern cho Database
        /// </summary>
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
        /// <summary>
        /// Bang Product
        /// </summary>
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
            new Product("CASE", 120, 28, 4),
        };
        /// <summary>
        /// Bang Category
        /// </summary>
        private List<Category> categoryTable = new List<Category>()
        {
            new Category(1, "Computer"),
            new Category(2, "Memory"),
            new Category(3, "Card"),
            new Category(4, "Acesory"),
        };
        /// <summary>
        /// Thuc hien viec tra ve Product tuong ung theo ten
        /// </summary>
        /// <param name="nameProduct">Ten cua Product can tim</param>
        /// <returns>Tra ve Product trong mang neu dung</returns>
        public Product findProduct(string nameProduct)
        {
            for (int i = 0; i < productTable.Count; i++)
            {
                if (productTable[i].Name == nameProduct)
                {
                    return productTable[i];
                }
            }
            return new Product();
        }
        /// <summary>
        /// Tra ve danh sach Product theo categoryId tuong ung
        /// </summary>
        /// <param name="categoryId">Gia tri category can tim</param>
        /// <returns>tra ve sanh sach cac Product tuong ung</returns>
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
        /// <summary>
        /// Tra ve danh sach Product co price nho hon price truyen vao
        /// </summary>
        /// <param name="price">gia tri price truyen vao</param>
        /// <returns></returns>
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
        /// <summary>
        /// Tra ve danh sach Product co price thap den cao, thuat toan Bubble
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// tra ve danh sach Product co Name tu dai den ngan, thuat toan Insertion
        /// </summary>
        /// <returns></returns>
        public List<Product> sortByName()
        {
            List<Product> sortedProducts = productTable;
            Product key;
            int j;
            for (int i = 1; i < sortedProducts.Count; i++)
            {
                key = sortedProducts[i];
                j = i;
                while (j > 0 && sortedProducts[j - 1].Name.Length < key.Name.Length)
                {
                    sortedProducts[j] = sortedProducts[j - 1];
                    j--;
                }
                if (j != i)
                {
                    sortedProducts[j] = key;
                }
            }
            return sortedProducts;
        }
        /// <summary>
        /// Tra ve danh sach Product sap xep theo Category.Name Alphabet
        /// </summary>
        /// <returns></returns>
        public List<Product> sortByCategoryName()
        {
            List<Product> sortedProducts = productTable;
            Product key;
            int j;
            for (int i = 1; i < sortedProducts.Count; i++)
            {
                key = sortedProducts[i];
                j = i;
                while (j > 0 && getCategoryNameById(key).CompareTo(getCategoryNameById(sortedProducts[j-1])) < 0)
                {
                    sortedProducts[j] = sortedProducts[j - 1];
                    j--;
                }
                if (j != i)
                {
                    sortedProducts[j] = key;
                }
            }
            return sortedProducts;
        }
        /// <summary>
        /// Tra ve danh sach Product theo Category tuong ung theo categoryId
        /// </summary>
        /// <param name="categoryType">Enum Category name muon tim</param>
        /// <returns></returns>
        public List<Product> mapProductByCategory(CategoryType categoryType)
        {
            List<Product> products = new List<Product>();
            int id = 0;
            for (int i = 0; i < categoryTable.Count; i++)
            {
                if (categoryTable[i].Name == categoryType.ToString())
                {
                    id = categoryTable[i].Id;
                }
            }
            for (int i = 0; i < productTable.Count; i++)
            {
                if (productTable[i].CategoryId == id)
                {
                    products.Add(productTable[i]);
                }
            }
            return products;
        }
        /// <summary>
        /// Tra ve Product co gia tri nho nhat
        /// </summary>
        /// <returns></returns>
        public Product minByPrice()
        {
            Product minProduct = productTable[0];

            for (int i = 0; i < productTable.Count; i++)
            {
                if (minProduct.Price > productTable[i].Price)
                {
                    minProduct = productTable[i];
                }
            }
            return minProduct;
        }
        /// <summary>
        /// Tra ve Product co gia tri lon nhat
        /// </summary>
        /// <returns></returns>
        public Product maxByPrice()
        {
            Product maxProduct = productTable[0];

            for (int i = 0; i < productTable.Count; i++)
            {
                if (maxProduct.Price < productTable[i].Price)
                {
                    maxProduct = productTable[i];
                }
            }
            return maxProduct;
        }
        /// <summary>
        /// Lay Name cua Category dua tren Product
        /// </summary>
        private string getCategoryNameById(Product product)
        {
            string name = "";
            for (int i =0; i< categoryTable.Count; i++)
            {
                if (product.CategoryId == categoryTable[i].Id)
                {
                    name = categoryTable[i].Name;
                }
            }
            return name;
        }
        

    }
}
