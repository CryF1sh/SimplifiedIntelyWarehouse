namespace SimplifiedIntelyWarehouse.Core.Entities
{
    /// <summary>
    /// Товар. Хранение информации о товаре.
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; } //Артикул товара
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
