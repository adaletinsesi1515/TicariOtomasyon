namespace TicariOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Caris", "SatisHareket_SatisID", "dbo.SatisHarekets");
            DropForeignKey("dbo.Personels", "SatisHareket_SatisID", "dbo.SatisHarekets");
            DropForeignKey("dbo.Uruns", "SatisHareket_SatisID", "dbo.SatisHarekets");
            DropIndex("dbo.Caris", new[] { "SatisHareket_SatisID" });
            DropIndex("dbo.Personels", new[] { "SatisHareket_SatisID" });
            DropIndex("dbo.Uruns", new[] { "SatisHareket_SatisID" });
            AddColumn("dbo.SatisHarekets", "Cari_CariID", c => c.Int());
            AddColumn("dbo.SatisHarekets", "Personel_PersonelID", c => c.Int());
            AddColumn("dbo.SatisHarekets", "Urun_UrunID", c => c.Int());
            CreateIndex("dbo.SatisHarekets", "Cari_CariID");
            CreateIndex("dbo.SatisHarekets", "Personel_PersonelID");
            CreateIndex("dbo.SatisHarekets", "Urun_UrunID");
            AddForeignKey("dbo.SatisHarekets", "Cari_CariID", "dbo.Caris", "CariID");
            AddForeignKey("dbo.SatisHarekets", "Personel_PersonelID", "dbo.Personels", "PersonelID");
            AddForeignKey("dbo.SatisHarekets", "Urun_UrunID", "dbo.Uruns", "UrunID");
            DropColumn("dbo.Caris", "SatisHareket_SatisID");
            DropColumn("dbo.Personels", "SatisHareket_SatisID");
            DropColumn("dbo.Uruns", "SatisHareket_SatisID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Uruns", "SatisHareket_SatisID", c => c.Int());
            AddColumn("dbo.Personels", "SatisHareket_SatisID", c => c.Int());
            AddColumn("dbo.Caris", "SatisHareket_SatisID", c => c.Int());
            DropForeignKey("dbo.SatisHarekets", "Urun_UrunID", "dbo.Uruns");
            DropForeignKey("dbo.SatisHarekets", "Personel_PersonelID", "dbo.Personels");
            DropForeignKey("dbo.SatisHarekets", "Cari_CariID", "dbo.Caris");
            DropIndex("dbo.SatisHarekets", new[] { "Urun_UrunID" });
            DropIndex("dbo.SatisHarekets", new[] { "Personel_PersonelID" });
            DropIndex("dbo.SatisHarekets", new[] { "Cari_CariID" });
            DropColumn("dbo.SatisHarekets", "Urun_UrunID");
            DropColumn("dbo.SatisHarekets", "Personel_PersonelID");
            DropColumn("dbo.SatisHarekets", "Cari_CariID");
            CreateIndex("dbo.Uruns", "SatisHareket_SatisID");
            CreateIndex("dbo.Personels", "SatisHareket_SatisID");
            CreateIndex("dbo.Caris", "SatisHareket_SatisID");
            AddForeignKey("dbo.Uruns", "SatisHareket_SatisID", "dbo.SatisHarekets", "SatisID");
            AddForeignKey("dbo.Personels", "SatisHareket_SatisID", "dbo.SatisHarekets", "SatisID");
            AddForeignKey("dbo.Caris", "SatisHareket_SatisID", "dbo.SatisHarekets", "SatisID");
        }
    }
}
