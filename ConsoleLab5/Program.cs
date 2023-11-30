using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Store store = new Store();

        store.Products.Add(new Product { Name = "Laptop", Price = 1200, Description = "High-performance laptop", Category = "Electronics" });
        store.Products.Add(new Product { Name = "Smartphone", Price = 500, Description = "Latest smartphone model", Category = "Electronics" });
        store.Products.Add(new Product { Name = "Backpack", Price = 50, Description = "Water-resistant backpack", Category = "Fashion" });
        store.Products.Add(new Product { Name = "Running Shoes", Price = 80, Description = "Comfortable running shoes", Category = "Sports" });

        store.Users.Add(new User { Username = "user1", Password = "pass1" });
        store.Users.Add(new User { Username = "user2", Password = "pass2" });

        User currentUser = store.Users[0];
        Order order = new Order { Products = { store.Products[0] }, Quantity = 2, Status = "Pending" };
        currentUser.PurchaseHistory.Add(order);
        store.Orders.Add(order);

        double maxPrice = 600;
        List<Product> affordableProducts = store.SearchByPrice(maxPrice);
        Console.WriteLine($"Products under {maxPrice:C}:");

        store.DisplayProducts(affordableProducts);

        string category = "Electronics";
        List<Product> electronicProducts = store.SearchByCategory(category);
        Console.WriteLine($"\n{category} Products:");

        store.DisplayProducts(electronicProducts);

        Console.WriteLine($"\nPurchase history for {currentUser.Username}:");
        store.DisplayPurchaseHistory(currentUser);

    }
}
