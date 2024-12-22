using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThueXe.Model;

namespace ThueXe.ADO
{
    public class KhachHangADO
    {
        // Create
        public int ThemKhachHang(KhachHang kh)
        {
            string sql = "INSERT INTO KhachHang (TenKH, CMND, DiaChi, SDT) " +
                         "VALUES (@TenKH, @CMND, @DiaChi, @SDT)";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@TenKH", kh.TenKH),
            new SqlParameter("@CMND", kh.CMND),
            new SqlParameter("@DiaChi", kh.DiaChi),
            new SqlParameter("@SDT", kh.SDT)
            };
            return DataHelper.ExecuteNonQuery(sql, parameters);
        }

        // Read
        public DataTable LayDanhSachKhachHang()
        {
            string sql = "SELECT * FROM KhachHang";
            DataTable dt = new DataTable();

            using (SqlConnection connection = DataHelper.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public KhachHang LayKhachHangTheoMa(int maKH)
        {
            string sql = "SELECT * FROM KhachHang WHERE MaKH = @MaKH";
            SqlParameter[] parameter = new SqlParameter[] { new SqlParameter("@MaKH", maKH) };
            KhachHang kh = null;

            using (SqlDataReader reader = DataHelper.ExecuteReader(sql, parameter))
            {
                if (reader.Read())
                {
                    kh = new KhachHang();
                    kh.MaKH = reader.GetInt32(0);
                    kh.TenKH = reader.GetString(1);
                    kh.CMND = reader.GetString(2);
                    kh.DiaChi = reader.GetString(3);
                    kh.SDT = reader.GetString(4);
                }
            }
            return kh;
        }

        // Update
        public int CapNhatKhachHang(KhachHang kh)
        {
            string sql = "UPDATE KhachHang SET TenKH = @TenKH, CMND = @CMND, " +
                         "DiaChi = @DiaChi, SDT = @SDT WHERE MaKH = @MaKH";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@TenKH", kh.TenKH),
            new SqlParameter("@CMND", kh.CMND),
            new SqlParameter("@DiaChi", kh.DiaChi),
            new SqlParameter("@SDT", kh.SDT),
            new SqlParameter("@MaKH", kh.MaKH)
            };
            return DataHelper.ExecuteNonQuery(sql, parameters);
        }

        // Delete
        public int XoaKhachHang(int maKH)
        {
            string sql = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
            SqlParameter[] parameter = new SqlParameter[] { new SqlParameter("@MaKH", maKH) };
            return DataHelper.ExecuteNonQuery(sql, parameter);
        }
    }
}
