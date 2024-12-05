namespace SimplifiedIntelyWarehouse.Core.Entities
{
    /// <summary>
    /// Склад. Отражает состояние товаров на складе
    /// </summary>
    public class Stock 
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; } 
        public DateTime? LastUbdated { get; set; }
    }
}
