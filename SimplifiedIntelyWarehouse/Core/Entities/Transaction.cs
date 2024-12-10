using SimplifiedIntelyWarehouse.Core.Enums;

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
        public TransactionType Type { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Status Status { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Notes { get; set; }
    }
}
