namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Uruns", "Kampanya", c => c.Boolean(nullable: false));
            AddColumn("dbo.Uruns", "KampanyaOrani", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Uruns", "KampanyaOrani");
            DropColumn("dbo.Uruns", "Kampanya");
        }
    }
}
