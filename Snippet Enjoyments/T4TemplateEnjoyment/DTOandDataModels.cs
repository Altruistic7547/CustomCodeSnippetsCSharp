

namespace GeneratedModels
{
    public class SupplyChainResourceDTO
    {
        /// <summary>
        /// Supply Id
        /// </summary>
        public int SupplyId { get; set; }

        /// <summary>
        /// Item Name
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// Supplier Name
        /// </summary>
        public string SupplierName { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Unit Price
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Order Date
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Expected Delivery Date
        /// </summary>
        public DateTime ExpectedDeliveryDate { get; set; }

        /// <summary>
        /// Warehouse Location
        /// </summary>
        public string WarehouseLocation { get; set; }

        /// <summary>
        /// Is Delivered
        /// </summary>
        public bool IsDelivered { get; set; }

        /// <summary>
        /// Delivery Date
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Shipment Tracking Number
        /// </summary>
        public string ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        public string Category { get; set; }

    }

    [Table("SupplyChainResource")]
    public class SupplyChainResourceDataModel
    {
        /// <summary>
        /// Supply Id
        /// </summary>
        [Column("Supply_Id")]
        public int SupplyId { get; set; }

        /// <summary>
        /// Item Name
        /// </summary>
        [Column("Item_Name")]
        public string ItemName { get; set; }

        /// <summary>
        /// Supplier Name
        /// </summary>
        [Column("SupplierName")]
        public string SupplierName { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [Column("Qty")]
        public int Quantity { get; set; }

        /// <summary>
        /// Unit Price
        /// </summary>
        [Column("Price_Per_Unit")]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Order Date
        /// </summary>
        [Column("Order_Date")]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Expected Delivery Date
        /// </summary>
        [Column("Expected_Delivery")]
        public DateTime ExpectedDeliveryDate { get; set; }

        /// <summary>
        /// Warehouse Location
        /// </summary>
        [Column("Warehouse_Loc")]
        public string WarehouseLocation { get; set; }

        /// <summary>
        /// Is Delivered
        /// </summary>
        [Column("Is_Delivered")]
        public bool IsDelivered { get; set; }

        /// <summary>
        /// Delivery Date
        /// </summary>
        [Column("Delivery_Date")]
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Shipment Tracking Number
        /// </summary>
        [Column("Tracking_Number")]
        public string ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        [Column("Category_Type")]
        public string Category { get; set; }

    }
}
