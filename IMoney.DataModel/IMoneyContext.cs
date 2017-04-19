using System.Data.Entity;
using iMoney.Model;

namespace IMoney.DataModel
{
    public class IMoneyContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
