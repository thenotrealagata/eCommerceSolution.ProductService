namespace eCommerce.BusinessLogic.DTO
{
    public record ProductResponse
    {
        public Guid ProductId { get; set; }
        public required string ProductName { get; set; }
        public required string Category { get; set; }
        public double? UnitPrice { get; set; }
        public int? QuantityInStock { get; set; }
    }
}
