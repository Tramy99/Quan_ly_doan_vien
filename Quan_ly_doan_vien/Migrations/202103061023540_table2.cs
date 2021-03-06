namespace Quan_ly_doan_vien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class table2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.XepLoais",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Năm_hoc = c.Int(nullable: false),
                        Nhan_xet = c.String(nullable: false),
                        Xep_loai = c.String(nullable: false),
                        DoanVien_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DoanViens", t => t.DoanVien_Id, cascadeDelete: true)
                .Index(t => t.DoanVien_Id);
            
            CreateTable(
                "dbo.HoatDongs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ma_hd = c.String(nullable: false),
                        Ten_hd = c.String(nullable: false),
                        Thoi_gian = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.XepLoais", "DoanVien_Id", "dbo.DoanViens");
            DropIndex("dbo.XepLoais", new[] { "DoanVien_Id" });
            DropTable("dbo.HoatDongs");
            DropTable("dbo.XepLoais");
        }
    }
}
