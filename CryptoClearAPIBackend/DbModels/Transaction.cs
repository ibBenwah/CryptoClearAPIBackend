namespace CryptoClearAPIBackend.DbModels
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string CoinSymbol { get; set; }
        public decimal Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
    }
}

