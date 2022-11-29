using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CryptoClearAPIBackend.DbModels
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]        
        public int UserId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string CoinId { get; set; }
        public decimal Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
    }
}

