namespace IMoney.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Timestamp = c.DateTime(nullable: false),
                        Amount = c.Double(nullable: false),
                        DebitId = c.Int(nullable: false),
                        CreditId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.CreditId, cascadeDelete: false)
                .ForeignKey("dbo.Accounts", t => t.DebitId, cascadeDelete: false)
                .Index(t => t.DebitId)
                .Index(t => t.CreditId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "DebitId", "dbo.Accounts");
            DropForeignKey("dbo.Transactions", "CreditId", "dbo.Accounts");
            DropIndex("dbo.Transactions", new[] { "CreditId" });
            DropIndex("dbo.Transactions", new[] { "DebitId" });
            DropTable("dbo.Transactions");
            DropTable("dbo.Accounts");
        }
    }
}
