class Store : ISearchable
{
    public List<Product> Products { get; set; } = new List<Product>();
    public List<User> Users { get; set; } = new List<User>();
    public List<Order> Orders { get; set; } = new List<Order>();

    public List<Product> SearchByPrice(double maxPrice)
    {
        return Products.Where(p => p.Price <= maxPrice).ToList();
    }

    public List<Product> SearchByCategory(string category)
    {
        return Products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public void DisplayProducts(List<Product> productList)
    {
        foreach (var product in productList)
        {
            Console.WriteLine(product);
        }
    }

    public void DisplayOrders()
    {
        foreach (var order in Orders)
        {
            Console.WriteLine(order);
        }
    }

    public void DisplayUsers()
    {
        foreach (var user in Users)
        {
            Console.WriteLine(user);
        }
    }

    public void DisplayPurchaseHistory(User user)
    {
        foreach (var order in user.PurchaseHistory)
        {
            Console.WriteLine(order);
        }
    }
}