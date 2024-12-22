using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThueXe.ADO
{
    public class ThongKeADO
    {
        public DataTable ThongKeSoLuongXeDaThue(DateTime tuNgay, DateTime denNgay)
        {
            string sql = "SELECT COUNT(*) AS SoLuongXeDaThue " +
                         "FROM HopDong " +
                         "WHERE NgayThue >= @TuNgay AND NgayThue <= @DenNgay";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@TuNgay", tuNgay),
            new SqlParameter("@DenNgay", denNgay)
            };

            return DataHelper.ExecuteDataTable(sql, parameters);
        }

        public DataTable ThongKeTongDoanhThuTheoThang(int nam)
        {
            string sql = "SELECT MONTH(NgayThue) AS Thang, SUM(TongTien) AS TongDoanhThu " +
                         "FROM HopDong " +
                         "WHERE YEAR(NgayThue) = @Nam " +
                         "GROUP BY MONTH(NgayThue)";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Nam", nam)
            };

            return DataHelper.ExecuteDataTable(sql, parameters);
        }

        public DataTable ThongKeKhachHangThueXeNhieuNhat()
        {
            string sql = "SELECT TOP 1 WITH TIES kh.MaKH, kh.TenKH, kh.SDT, kh.DiaChi, COUNT(*) AS SoLanThue " +
                         "FROM HopDong hd " +
                         "JOIN KhachHang kh ON hd.MaKH = kh.MaKH " +
                         "GROUP BY kh.MaKH, kh.TenKH, kh.SDT, kh.DiaChi " +
                         "ORDER BY SoLanThue DESC";

            return DataHelper.ExecuteDataTable(sql);
        }
        public DataTable ThongKeLoaiXeDuocThueNhieuNhat()
        {
            string sql = "SELECT TOP 1 WITH TIES xm.HangXe, xm.MauXe, xm.GiaThue, xm.TinhTrang, COUNT(*) AS SoLanThue " +
                         "FROM HopDong hd " +
                         "JOIN XeMay xm ON hd.MaXe = xm.MaXe " +
                         "GROUP BY xm.HangXe, xm.MauXe, xm.GiaThue, xm.TinhTrang " +
                         "ORDER BY SoLanThue DESC";

            return DataHelper.ExecuteDataTable(sql);
        }
        public DataTable ThongKeXeDangSuaChua()
        {
            string sql = "SELECT MaXe, BienSo, HangXe, MauXe " +
                         "FROM XeMay " +
                         "WHERE TinhTrang LIKE N'Đang sửa chữa'";

            return DataHelper.ExecuteDataTable(sql);
        }

    }
}
