namespace IcebreakersWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CocktailSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlcaholCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Cocktails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ImageSource = c.String(),
                        Category_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AlcaholCategories", t => t.Category_ID)
                .Index(t => t.Category_ID);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cocktails", "Category_ID", "dbo.AlcaholCategories");
            DropIndex("dbo.Cocktails", new[] { "Category_ID" });
            DropTable("dbo.Ingredients");
            DropTable("dbo.Cocktails");
            DropTable("dbo.AlcaholCategories");
        }
    }
}
