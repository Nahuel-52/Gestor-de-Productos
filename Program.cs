IproductRepository repo = new productRepository();

Console.WriteLine("Lista de productos:");
var all = repo.getAll();
foreach (var p in all)
{
    Console.WriteLine($"ID: {p.Id} | Nombre {p.Name} | Precio: {p.Price} | Category: {p.Category} | Activo: {p.State}");
}

Console.WriteLine("Ingrese el ID del producto que desea buscar:");
int idInput = int.Parse(Console.ReadLine());
var product = repo.getById(idInput);

if (product != null)
{
    Console.WriteLine($"Producto encontrado: ID: {product.Id} | Nombre: {product.Name} | Precio: {product.Price} | Categoria: {product.Category} | Activo: {product.State}");
}
else
{
    Console.WriteLine("Producto no encontrado.");
}

Console.WriteLine ("\n--- Agregando nuevo Producto ---");
var newproduct = new Product
{
    Id = 4,
    Name = "Pelota de tenis",
    Price = 8000,
    Category = "Deporte",
    State = true
};

repo.Add(newproduct);

Console.WriteLine("\n--- Lista de productos actualizada ---");
foreach (var p in repo.getAll())
{
    Console.WriteLine($"ID: {p.Id} | Nombre: {p.Name} | Precio: {p.Price} | Categoria: {p.Category} | Activo: {p.State}");
}