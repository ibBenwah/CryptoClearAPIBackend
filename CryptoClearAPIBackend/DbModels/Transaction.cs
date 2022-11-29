namespace CryptoClearAPIBackend.DbModels
{
    public class Portfolio
    {
        public string User { get; set; }
        public decimal Balance { get; set; }
        public string Coin { get; set; }
        public decimal Profitablity  { get; set; }
        public DateTime Transaction { get; set; }
    }
}

