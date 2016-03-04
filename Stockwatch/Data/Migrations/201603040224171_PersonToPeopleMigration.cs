namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonToPeopleMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        MarketId = c.Int(nullable: false, identity: true),
                        MarketIndex = c.String(),
                        MarketDescription = c.String(),
                    })
                .PrimaryKey(t => t.MarketId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        StockId = c.Int(nullable: false, identity: true),
                        StockIndex = c.String(),
                        StockDescription = c.String(),
                        StockValue = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.StockId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        Username = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Stocks");
            DropTable("dbo.People");
            DropTable("dbo.Markets");
        }
    }
}
