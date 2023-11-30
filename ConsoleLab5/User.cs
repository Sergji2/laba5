﻿class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public List<Order> PurchaseHistory { get; set; } = new List<Order>();

    public override string ToString()
    {
        return $"User: {Username}";
    }
}