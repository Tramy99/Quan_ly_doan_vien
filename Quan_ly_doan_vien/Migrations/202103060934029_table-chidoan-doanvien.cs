namespace Quan_ly_doan_vien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablechidoandoanvien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiDoans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ma_cd = c.String(nullable: false),
                        Ten_cd = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DoanViens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ma_dv = c.String(nullable: false),
                        Ten_dv = c.String(nullable: false),
                        Ngay_sinh = c.DateTime(nullable: false),
                        Que_quan = c.String(nullable: false),
                        Dan_toc = c.String(nullable: false),
                        Ngay_vao_doan = c.DateTime(nullable: false),
                        ChiDoan_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ChiDoans", t => t.ChiDoan_Id, cascadeDelete: true)
                .Index(t => t.ChiDoan_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DoanViens", "ChiDoan_Id", "dbo.ChiDoans");
            DropIndex("dbo.DoanViens", new[] { "ChiDoan_Id" });
            DropTable("dbo.DoanViens");
            DropTable("dbo.ChiDoans");
        }
    }
}
