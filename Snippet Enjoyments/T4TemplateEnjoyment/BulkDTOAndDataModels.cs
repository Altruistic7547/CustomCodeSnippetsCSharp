namespace GeneratedModels
{
    [Table("PurchaseOrder")]
    public class PurchaseOrderDataModel
    {

        [Column("OrderId")]
        public int OrderId { get; set; }

        [Column("CustomerId")]
        public Guid CustomerId { get; set; }

        [Column("OrderDate")]
        public DateTime OrderDate { get; set; }

        [Column("ShipmentDate")]
        public DateTime? ShipmentDate { get; set; }

        [Column("TotalAmount")]
        public decimal TotalAmount { get; set; }

        [Column("OrderStatus")]
        public string OrderStatus { get; set; }

        [Column("ProductList")]
        public List<string> ProductList { get; set; }

        [Column("IsGiftWrapped")]
        public bool IsGiftWrapped { get; set; }

        [Column("ShippingAddress")]
        public string ShippingAddress { get; set; }

        [Column("TaxAmount")]
        public decimal TaxAmount { get; set; }

        [Column("TransactionId")]
        public Guid TransactionId { get; set; }

        [Column("OrderPriority")]
        public char OrderPriority { get; set; }
    }
}
namespace GeneratedModels
{
    public class PurchaseOrderDTO
    {

        public int OrderId { get; set; }

        public Guid CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? ShipmentDate { get; set; }

        public decimal TotalAmount { get; set; }

        public string OrderStatus { get; set; }

        public List<string> ProductList { get; set; }

        public bool IsGiftWrapped { get; set; }

        public string ShippingAddress { get; set; }

        public decimal TaxAmount { get; set; }

        public Guid TransactionId { get; set; }

        public char OrderPriority { get; set; }
    }
}
namespace GeneratedModels
{
    [Table("Product")]
    public class ProductDataModel
    {

        [Column("ProductId")]
        public int ProductId { get; set; }

        [Column("ProductName")]
        public string ProductName { get; set; }

        [Column("Category")]
        public string Category { get; set; }

        [Column("Price")]
        public decimal Price { get; set; }

        [Column("StockQuantity")]
        public int StockQuantity { get; set; }

        [Column("DateAdded")]
        public DateTime DateAdded { get; set; }

        [Column("DiscountRate")]
        public float DiscountRate { get; set; }

        [Column("Tags")]
        public List<string> Tags { get; set; }

        [Column("SupplierId")]
        public Guid SupplierId { get; set; }

        [Column("IsAvailable")]
        public bool IsAvailable { get; set; }

        [Column("ProductDescription")]
        public string ProductDescription { get; set; }

        [Column("SKU")]
        public string SKU { get; set; }
    }
}
namespace GeneratedModels
{
    public class ProductDTO
    {

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public DateTime DateAdded { get; set; }

        public float DiscountRate { get; set; }

        public List<string> Tags { get; set; }

        public Guid SupplierId { get; set; }

        public bool IsAvailable { get; set; }

        public string ProductDescription { get; set; }

        public string SKU { get; set; }
    }
}
namespace GeneratedModels
{
    [Table("Invoice")]
    public class InvoiceDataModel
    {

        [Column("InvoiceId")]
        public int InvoiceId { get; set; }

        [Column("OrderId")]
        public Guid OrderId { get; set; }

        [Column("InvoiceDate")]
        public DateTime InvoiceDate { get; set; }

        [Column("AmountDue")]
        public decimal AmountDue { get; set; }

        [Column("DueDate")]
        public DateTime DueDate { get; set; }

        [Column("IsPaid")]
        public bool IsPaid { get; set; }

        [Column("PaymentMethod")]
        public string PaymentMethod { get; set; }

        [Column("CustomerId")]
        public Guid CustomerId { get; set; }

        [Column("LineItems")]
        public List<string> LineItems { get; set; }

        [Column("LateFee")]
        public decimal LateFee { get; set; }

        [Column("CurrencyCode")]
        public short CurrencyCode { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }
    }
}
namespace GeneratedModels
{
    public class InvoiceDTO
    {

        public int InvoiceId { get; set; }

        public Guid OrderId { get; set; }

        public DateTime InvoiceDate { get; set; }

        public decimal AmountDue { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsPaid { get; set; }

        public string PaymentMethod { get; set; }

        public Guid CustomerId { get; set; }

        public List<string> LineItems { get; set; }

        public decimal LateFee { get; set; }

        public short CurrencyCode { get; set; }

        public string Notes { get; set; }
    }
}
