using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iMoney.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public double Amount { get; set; }

        [Required]
        public Account Debit { get; set; }
        public int DebitId { get; set; }
        [Required]
        public Account Credit { get; set; }
        public int CreditId { get; set; }
    }
}
