namespace SimplifiedIntelyWarehouse.Core.Entities
{
    /// <summary>
    /// Транзакция. Необходима для учёта операций с товарами. Это могут быть поступления, расход, возврат и корректировка.
    /// </summary>
    public class Transaction
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
    }
}
