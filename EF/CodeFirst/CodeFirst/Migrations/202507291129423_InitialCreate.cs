namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(),
                        PublisherName = c.String(),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.TblBooks",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                        Price = c.Double(nullable: false),
                        YearPublished = c.DateTime(nullable: false),
                        Author_AuthorId = c.Int(),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Authors", t => t.Author_AuthorId)
                .Index(t => t.Author_AuthorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TblBooks", "Author_AuthorId", "dbo.Authors");
            DropIndex("dbo.TblBooks", new[] { "Author_AuthorId" });
            DropTable("dbo.TblBooks");
            DropTable("dbo.Authors");
        }
    }
}
