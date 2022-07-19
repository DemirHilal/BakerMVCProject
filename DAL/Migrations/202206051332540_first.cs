namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AltKategoris",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoris", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.KategoriId);
            
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Uruns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AltKategoriId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AltKategoris", t => t.AltKategoriId, cascadeDelete: true)
                .Index(t => t.AltKategoriId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Uruns", "AltKategoriId", "dbo.AltKategoris");
            DropForeignKey("dbo.AltKategoris", "KategoriId", "dbo.Kategoris");
            DropIndex("dbo.Uruns", new[] { "AltKategoriId" });
            DropIndex("dbo.AltKategoris", new[] { "KategoriId" });
            DropTable("dbo.Uruns");
            DropTable("dbo.Kategoris");
            DropTable("dbo.AltKategoris");
        }
    }
}
