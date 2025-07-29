namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedauthortype : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "AuthorType");
        }
    }
}
