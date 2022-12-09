using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace CryptoClearAPIBackend.DbModels
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public double LiquidCash { get; set; }
        public List<Transaction>? Transactions { get; set; }

    }
}
