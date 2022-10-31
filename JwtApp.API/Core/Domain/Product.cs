namespace JwtApp.API.Core.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CayegoryId { get; set; }
        public Category Category { get; set; }
        public Product()
        {
            Category = new Category();
        }
    }
}
