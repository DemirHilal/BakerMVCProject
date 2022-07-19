namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seco : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AltKategoris", newName: "altKategori");
            RenameTable(name: "dbo.Kategoris", newName: "kategori");
            RenameTable(name: "dbo.Uruns", newName: "urun");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.urun", newName: "Uruns");
            RenameTable(name: "dbo.kategori", newName: "Kategoris");
            RenameTable(name: "dbo.altKategori", newName: "AltKategoris");
        }
    }
}
