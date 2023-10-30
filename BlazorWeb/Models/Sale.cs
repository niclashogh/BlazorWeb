namespace BlazorWeb.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public List<Customer>? Buyers { get; set; }
    }
}
