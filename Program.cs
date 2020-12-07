
using efcorecodefirstapproach.Models;
using System;
using System.Linq;

namespace efcorecodefirstapproach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ContosoDBContext getting initialized.");

            using ContosoDBContext context = new ContosoDBContext();

            Console.WriteLine("initialized..");

            InsertRecord(context);

            Console.WriteLine("Inserted record with the given context.");

            ViewRecord(context);

            Console.WriteLine("Queried record with the given context.");

            UpdateRecord(context);

            Console.WriteLine("Updated record with the given context.");

            DeleteRecord(context);

            Console.WriteLine("Deleted record with the given context.");

            Console.WriteLine("Successfuly executed.");
        }

        public static void InsertRecord(ContosoDBContext context)
        {
            Product product = new Product()
            {
                Name = "mikky3",
                Price = 4.91M
            };
            context.Products.Add(product);
            context.SaveChanges();
        }

        public static void ViewRecord(ContosoDBContext context)
        {
            var products = context.Products.Where(p => p.Price >= 3.00m).OrderBy(p => p.Name);

            foreach (Product p in products)
            {
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Price);
                Console.WriteLine(p.Id);
            }
        }

        public static void DeleteRecord(ContosoDBContext context)
        {
            var product = context.Products.Where(p => p.Name == "mikky1").FirstOrDefault();

            if (product is Product)
            {
                context.Remove(product);
            }
            context.SaveChanges();
        }

        public static void UpdateRecord(ContosoDBContext context)
        {
            var product = context.Products.Where(p => p.Name == "mikky1").FirstOrDefault();

            if (product is Product)
            {
                product.Name = "mikky-updated";
            }
            context.SaveChanges();

        }
    }
}
