using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Quan_ly_doan_vien.Models
{
    public class HoatDong
    {
        [Key]
        [DisplayName("Hoạt động ID")]
        public int Id { get; set; }
        [Required, DisplayName("Mã hoạt động")]
        public string Ma_hd { get; set; }
        [Required, DisplayName("Tên hoạt động")]
        public string Ten_hd { get; set; }
        [Required, DisplayName("Thời gian tổ chức")]
        public DateTime Thoi_gian { get; set; }
    }
}