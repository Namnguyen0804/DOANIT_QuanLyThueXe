using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThueXe.Model
{
    public class HopDong
    {
        public int MaHD { get; set; }
        public int MaKH { get; set; }
        public int MaXe { get; set; }
        public DateTime NgayThue { get; set; }
        public DateTime? NgayTra { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
    }
}
