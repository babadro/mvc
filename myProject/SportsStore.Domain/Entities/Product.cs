
namespace SportsStore.Domain.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public decimal Price { get; set; }
        public string Describe { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
    }
}
