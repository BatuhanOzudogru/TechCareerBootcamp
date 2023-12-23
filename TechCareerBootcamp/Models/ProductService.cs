namespace TechCareerBootcamp.Models
{
    public class ProductService
    {
        public static List<Product> GetProducts()
        {
            var products = new List<Product>();
            products.Add(new Product(1, "Apple", 10, new Category(1, "Fruit")));
            products.Add(new Product(2, "Broccoli", 20, new Category(2, "Vegetable")));
            products.Add(new Product(3, "Banana", 15, new Category(1, "Fruit")));
            products.Add(new Product(4, "Donut", 13, new Category(3, "Junk food")));

            return products;

        }
    }
}
