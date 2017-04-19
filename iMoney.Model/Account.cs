using System.Collections.Generic;

namespace iMoney.Model
{
    public enum AccountType
    {
        Bank = 1,
        Income = 2,
        Expense = 3
    }

    public class Account
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        AccountType Type { get; set; }
        /*
        public List<Transaction> Debits { get; set; }
        public List<Transaction> Credits { get; set; }
        */
    }
}
