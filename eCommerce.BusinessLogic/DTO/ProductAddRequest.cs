namespace eCommerce.DataAccess.Entities
{
    public class ProductAddRequest
    {
        public required string ProductName { get; set; }
        public required string Category { get; set; }
        public double? UnitPrice { get; set; }
        public int? QuantityInStock { get; set; }
    }
}
