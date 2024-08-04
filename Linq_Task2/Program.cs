using System.Linq;

namespace Linq_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Customers> customers = new List<Customers>()
        {
            new Customers {
                Id = 1,
                Name = "Ahmed Saleh",
                Email = "ahmed.saleh@gmail.com",
                Phone = 1234567890,
                City = "Jerusalem",
                PurchasedProducts = new List<Product>
                {
                    new Product { ProductId = 101, ProductName = "Laptop", Price = 1200.50 },
                    new Product { ProductId = 102, ProductName = "Smartphone", Price = 800.75 }
                }
            },
            new Customers {
                Id = 2,
                Name = "Fatima Ali",
                Email = "fatima.ali@gmail.com",
                Phone = 1234567891,
                City = "Nablus",
                PurchasedProducts = new List<Product>
                {
                    new Product { ProductId = 103, ProductName = "Tablet", Price = 400.99 }
                }
            },
            new Customers {
                Id = 3,
                Name = "Hassan Yassin",
                Email = "hassan.yassin@gmail.com",
                Phone = 1234567892,
                City = "Ramallah",
                PurchasedProducts = new List<Product>
                {
                    new Product { ProductId = 104, ProductName = "Smartwatch", Price = 199.99 }
                }
            },
            new Customers {
                Id = 4,
                Name = "Layla Hamed",
                Email = "layla.hamed@gmail.com",
                Phone = 1234567893,
                City = "Hebron",
                PurchasedProducts = new List<Product>
                {
                    new Product { ProductId = 105, ProductName = "Headphones", Price = 99.99 }
                }
            },
            new Customers {
                Id = 5,
                Name = "Omar Khaled",
                Email = "omar.khaled@gmail.com",
                Phone = 1234567894,
                City = "Bethlehem",
                PurchasedProducts = new List<Product>
                {
                    new Product { ProductId = 106, ProductName = "Monitor", Price = 300.00 }
                }
            },
            new Customers {
                Id = 6,
                Name = "Nadia Zaid",
                Email = "nadia.zaid@gmail.com",
                Phone = 1234567895,
                City = "Jenin",
                PurchasedProducts = new List<Product>
                {
                    new Product { ProductId = 107, ProductName = "Keyboard", Price = 49.99 },
                    new Product { ProductId = 108, ProductName = "Mouse", Price = 29.99 }
                }
            },
            new Customers {
                Id = 7,
                Name = "Samir Fadi",
                Email = "samir.fadi@gmail.com",
                Phone = 1234567896,
                City = "Nablus",
                PurchasedProducts = new List<Product>
                {
                    new Product { ProductId = 109, ProductName = "Printer", Price = 150.00 }
                }
            },
            new Customers {
                Id = 8,
                Name = "Hiba Omar",
                Email = "hiba.omar@gmail.com",
                Phone = 1234567897,
                City = "Qalqilia",
                PurchasedProducts = new List<Product>
                {
                    new Product { ProductId = 110, ProductName = "Router", Price = 79.99 }
                }
            },
            new Customers {
                Id = 9,
                Name = "Bilal Hasan",
                Email = "bilal.hasan@gmail.com",
                Phone = 1234567898,
                City = "Jerusalem",
                PurchasedProducts = new List<Product>
                {
                    new Product { ProductId = 111, ProductName = "External Hard Drive", Price = 129.99 }
                }
            },
            new Customers {
                Id = 10,
                Name = "Mona Jaber",
                Email = "mona.jaber@gmail.com",
                Phone = 1234567899,
                City = "Jerusalem",
                PurchasedProducts = new List<Product>
                {
                    new Product { ProductId = 112, ProductName = "USB Flash Drive", Price = 19.99 }
                }
            },
            new Customers {
                Id = 11,
                Name = "Adnan Musa",
                Email = "adnan.musa@gmail.com",
                Phone = 1234567800,
                City = "Jerusalem",
                PurchasedProducts = new List<Product>
                {
                    new Product { ProductId = 113, ProductName = "Camera", Price = 500.00 }
                }
            },
            new Customers {
                Id = 12,
                Name = "Yara Kamal",
                Email = "yara.kamal@gmail.com",
                Phone = 1234567801,
                City = "Jenin",
                PurchasedProducts = new List<Product>
                {
                    new Product { ProductId = 114, ProductName = "Microphone", Price = 79.99 }
                }
            },
            new Customers {
                Id = 13,
                Name = "Zainab Issa",
                Email = "zainab.issa@gmail.com",
                Phone = 1234567802,
                City = "Nablus",
                PurchasedProducts = new List<Product>
                {
                    new Product { ProductId = 115, ProductName = "Speakers", Price = 99.99 }
                }
            },
            new Customers {
                Id = 14,
                Name = "Tariq Ahmad",
                Email = "tariq.ahmad@gmail.com",
                Phone = 1234567803,
                City = "Nablus",
                PurchasedProducts = new List<Product>
                {
                    new Product { ProductId = 116, ProductName = "Graphics Card", Price = 299.99 }
                }
            },
            new Customers {
                Id = 15,
                Name = "Sara Hussein",
                Email = "sara.hussein@gmail.com",
                Phone = 1234567804,
                City = "Jenin",
                PurchasedProducts = new List<Product>
                {
                    new Product { ProductId = 117, ProductName = "Power Bank", Price = 49.99 }
                }
            }
        };


            // 1. Customers who live in Nablus
            var result = customers.Where(customer => customer.City == "Nablus").Select(customer => customer);
            Console.WriteLine("1. Customers who live in Nablus");
            foreach (var customer in result)
            {
                Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}, Email: {customer.Email}, Phone: {customer.Phone}.");
            }

            Console.WriteLine(" ");
            Console.WriteLine("===================================");
            Console.WriteLine(" ");

            // 2. Customers Names

            var result2 = customers.Select(customer => customer.Name);
            Console.WriteLine("2. Customers Names");
            foreach (var customer in result2)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine(" ");
            Console.WriteLine("===================================");
            Console.WriteLine(" ");

            // 3. Sort Customers Assending 

            var result3 = customers.OrderBy(customer => customer.Name);
            Console.WriteLine("3. Sort Customers Assending");
            foreach (var customer in result3)
            {
                Console.WriteLine(customer.Name);
            }

            Console.WriteLine(" ");
            Console.WriteLine("===================================");
            Console.WriteLine(" ");


            // 4. First Customer in List

            var result4 = customers.First();
            Console.WriteLine("4. First Customer in List");
            Console.WriteLine(result4.Name);

            Console.WriteLine(" ");
            Console.WriteLine("===================================");
            Console.WriteLine(" ");

            // 5. Customer With id = 1

            var result5 = customers.Where(customer => customer.Id == 1).First();
            Console.WriteLine("5. Customer With id = 1");
            Console.WriteLine($"ID: {result5.Id}, Name: {result5.Name}, Email: {result5.Email}, Phone: {result5.Phone}, City: {result5.City}");

            Console.WriteLine(" ");
            Console.WriteLine("===================================");
            Console.WriteLine(" ");

            // 6. Calculate the total prices of the products purchased by all customers.

            double productsSum = 0;
            var result6 = customers.Select(customer => customer.PurchasedProducts);
            Console.WriteLine("6. Calculate the total prices of the products purchased by all customers.");

            foreach(var product in result6)
            {
                // Console.WriteLine(product.Sum(prod => prod.Price));
                productsSum += product.Sum(prod => prod.Price);
            }
            Console.WriteLine($"The total prices = {productsSum}");

            Console.WriteLine(" ");
            Console.WriteLine("===================================");
            Console.WriteLine(" ");

            // 7. Check if there are any customers from Qalqilia.


            var result7 = customers.Where(customer => customer.City == "Qalqilia").Any();
            Console.WriteLine("7. Check if there are any customers from Qalqilia.");
            Console.WriteLine(result7);

            Console.WriteLine(" ");
            Console.WriteLine("===================================");
            Console.WriteLine(" ");


            // 8. Grouping customers by City.

            var result8 = customers.GroupBy(customers => customers.City);
            Console.WriteLine("8. Grouping customers by City.");
            foreach (var city in result8)
            {
                Console.WriteLine($"- { city.Key}");
                foreach (var customer in city)
                {
                    Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}, Email: {customer.Email}, Phone: {customer.Phone}.");
                }
                Console.WriteLine(" ");

            }

            Console.WriteLine(" ");
            Console.WriteLine("===================================");
            Console.WriteLine(" ");


            // 9. First three customers.

            var result9 = customers.Take(3);
            Console.WriteLine("9. First three customers.");
            foreach (var customer in result9)
            {
              Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}, Email: {customer.Email}, Phone: {customer.Phone}.");
            }

            Console.WriteLine(" ");
            Console.WriteLine("===================================");
            Console.WriteLine(" ");

        }
    }
}
