namespace Lambda_Linq;

public class ProductGrouping
{
    public static void Run()
    {
        Console.WriteLine("Average Price by Category");

        List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics", Price = 60000 },
                new Product { Name = "Mobile", Category = "Electronics", Price = 30000 },
                new Product { Name = "Shirt", Category = "Clothing", Price = 1500 },
                new Product { Name = "Jeans", Category = "Clothing", Price = 2500 },
                new Product { Name = "Mixer", Category = "Home Appliances", Price = 4000 }
        };

        var averagePriceByCategory = products
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    AveragePrice = g.Average(p => p.Price)
                });

        foreach (var item in averagePriceByCategory)
        {
            Console.WriteLine($"{item.Category} : Average Price = {item.AveragePrice}");
         
        }

        Console.WriteLine();
    }
}
