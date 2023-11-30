﻿class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Price:C} - {Category}";
    }
}