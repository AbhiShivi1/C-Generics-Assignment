using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
     class Inventory
    {
        static void Main(string[] args)
        {
            Product p1 = new Product()
            {
                Name = "lettuce",
                Price = 10.5,
                Quantity = 50,
                Type = "Leafy green"
            };
            Product p2 = new Product()
            {
                Name = "cabbage",
                Price = 20,
                Quantity = 100,
                Type = "Cruciferous"
            };
            Product p3 = new Product()
            {
                Name = "pumpkin",
                Price = 30,
                Quantity = 30,
                Type = "Marrow"
            };
            Product p4 = new Product()
            {
                Name = "cauliflower",
                Price = 10,
                Quantity = 25,
                Type = "Cruciferous"
            };
            Product p5 = new Product()
            {
                Name = "zucchini",
                Price = 20.5,
                Quantity = 50,
                Type = "Marrow"
            };
            Product p6 = new Product()
            {
                Name = "yam",
                Price = 30,
                Quantity = 50,
                Type = "Root"
            };
            Product p7 = new Product()
            {
                Name = "spinach",
                Price = 10,
                Quantity = 100,
                Type = "Leafy green"
            };
            Product p8 = new Product()
            {
                Name = "broccoli",
                Price = 20.2,
                Quantity = 70,
                Type = "Cruciferous"
            };
            Product p9 = new Product()
            {
                Name = "garlic",
                Price = 30,
                Quantity = 20,
                Type = "Leafy green"
            };
            Product p10 = new Product()
            {
                Name = "silverbeet",
                Price = 10,
                Quantity = 50,
                Type = "Marrow"
            };

            List<Product> l = new List<Product>() { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 };
            Console.WriteLine($"Total Number of items are : { l.Count}");


            
            Product p11 = new Product()     //New product Created
            {
                Name = "potato",
                Price = 10,
                Quantity = 50,
                Type = "Root"
            };

            l.Add(p11);                     //New product added
            Console.WriteLine("The list of Products are :");
            foreach (var items in l)
            {
                Console.WriteLine(items.Name);
            }

            Console.WriteLine($"Total Number of items are : { l.Count}");

            Console.WriteLine("Products that are Leafy green Type are :");

            

            foreach (var items in l)
            {
                if(items.Type.Equals("Leafy green"))
                Console.WriteLine(items.Name);
                
            }
            l[1].Quantity = l[1].Quantity + 50;
            Console.WriteLine("New Quantity of Cabbage is : "+l[1].Quantity);
            l.RemoveAt(9);
            Console.WriteLine("Garlic sold out");
            Console.WriteLine($"Total Number of items are : { l.Count}");
            double Amount = 0;
            Amount = (l[0].Price * 1) + (l[4].Price * 2) + (l[7].Price * 1);
            Console.WriteLine($"Total amount to be paid by user  {(int)Amount}");
            Console.ReadLine();
        }
    }
    public class Product
    {
        public String Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public String Type { get; set; }

    }


}
