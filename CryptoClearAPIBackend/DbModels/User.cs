﻿using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace CryptoClearAPIBackend.DbModels
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double LiquidCash { get; set; }
        public List<Transaction>? Transactions { get; set; }

    }
}