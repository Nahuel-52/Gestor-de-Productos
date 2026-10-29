public interface IproductRepository
{
    void Add(Product product);
    List<Product> getAll();
    Product getById(int id);
    List<Product> searchByCategory(string category);
}