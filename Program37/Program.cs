using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program37
{
    public class Product
    {
        public string Product_Name;
        public int Product_price;
        public int Product_qty;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> prd = new List<Product>()
            {
                new Product{Product_Name="Oil",Product_price=30000,Product_qty=20},
                new Product{ Product_Name="Almond",Product_price=30000,Product_qty=20},
                new Product{ Product_Name="Cashew",Product_price=5000,Product_qty=10},
                new Product{ Product_Name="Allo",Product_price=2000,Product_qty=10},
                new Product{ Product_Name="Wallnut",Product_price=2000,Product_qty=10},
                new Product{ Product_Name="Redchilipowder",Product_price=200,Product_qty=10},
                new Product{ Product_Name="Turmeric Powder",Product_price=200,Product_qty=10},
                new Product{Product_Name="Shampoo",Product_price=150,Product_qty=20},
                new Product{Product_Name="Shop",Product_price=200,Product_qty=30},
               new Product{Product_Name="Wafers",Product_price=150,Product_qty=20},
            };
            foreach (var item in prd)
            {
                Console.WriteLine("Product Name:" + item.Product_Name);
                Console.WriteLine("Product Price" + item.Product_price);
                Console.WriteLine("Prosuct qty" + item.Product_qty);

            }
            Console.Write("Total");
            int total = prd.Sum(sal => sal.Product_price * sal.Product_qty);
            Console.WriteLine("Total Pay:" + total);


            Console.Read();

        }
    }
}
