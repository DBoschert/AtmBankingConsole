﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtmBankingConsole.Models
{
    public class Customer
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CardCode { get; set; }
        public int PinCode { get; set; }
        public DateTime? LastTransactionDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }

    }
}
