interface ISearchable
{
    List<Product> SearchByPrice(double maxPrice);
    List<Product> SearchByCategory(string category);
}