class Order
{
    public List<Product> Products { get; set; } = new List<Product>();
    public int Quantity { get; set; }
    public double TotalPrice => Products.Sum(p => p.Price * Quantity);
    public string Status { get; set; }

    public override string ToString()
    {
        return $"Order Total: {TotalPrice:C} - Status: {Status}";
    }
}