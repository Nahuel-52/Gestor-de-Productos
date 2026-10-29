public class productRepository : IproductRepository
{
    private readonly List<Product> _products;

    public productRepository()
    {
        _products = new List<Product>()
        {
            new Product { Id = 1, Name = "Pelota de futbol", Price = 10000, Category = "Deporte", State = true },
            new Product { Id = 2, Name = "Pelota de basquet", Price = 15000, Category = "Deporte", State = true },
            new Product { Id = 3, Name = "Pelota de voley", Price = 12000, Category = "Deporte", State = false },
        };
    }

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public List<Product> getAll()
    {
        return _products;
    }

    public Product getById(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }

    public List<Product> searchByCategory(string category)
    {
        return _products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
