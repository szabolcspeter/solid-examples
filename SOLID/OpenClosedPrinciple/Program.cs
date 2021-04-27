using System;
using OpenClosedPrinciple.Enums;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = 
            {
                new Product("Apple", Color.Green, Size.Small),
                new Product("Tree", Color.Green, Size.Large),
                new Product("House", Color.Blue, Size.Large)
            };

            var bf = new BetterFilter();
            Console.WriteLine("Green products:");
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {p.Name} is green");
            }

            Console.WriteLine("Large blue items:");
            foreach (var p in bf.Filter(
                products,
                new AndSpecification<Product>(
                    new ColorSpecification(Color.Blue),
                    new SizeSpecification(Size.Large)
                )
            ))
            {
                Console.WriteLine($" - {p.Name} is large and blue");
            }
        }
    }
}
