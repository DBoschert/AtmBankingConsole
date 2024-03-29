﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtmBankingConsole.Models
{
    public class Transaction
    {

        public int Id { get; set; }
        public int AccountId { get; set; }
        public virtual Account? Account { get; set; }
        public decimal PreviousBalance { get; set; }
        public string TransactionType { get; set; } = string.Empty;
        public decimal NewBalance { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;


    }
}
