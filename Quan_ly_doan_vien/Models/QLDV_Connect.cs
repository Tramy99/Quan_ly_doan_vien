using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Quan_ly_doan_vien.Models
{
    public partial class QLDV_Connect : DbContext
    {
        public DbSet<ChiDoan> ChiDoans { get; set; }
        public DbSet<DoanVien> DoanViens { get; set; }
        public DbSet<HoatDong> HoatDongs { get; set; }
        public DbSet<XepLoai> XepLoais { get; set; }

        public QLDV_Connect()
            : base("name=QLDV_Connect")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
