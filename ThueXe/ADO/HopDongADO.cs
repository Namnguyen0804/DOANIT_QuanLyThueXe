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
    public class HopDongADO
    {
        // Create
            public int ThemHopDong(HopDong hd)
            {
                string sql = "INSERT INTO HopDong (MaKH, MaXe, NgayThue, NgayTra, TongTien, TrangThai) " +
                             "VALUES (@MaKH, @MaXe, @NgayThue, @NgayTra, @TongTien, @TrangThai)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@MaKH", hd.MaKH),
                new SqlParameter("@MaXe", hd.MaXe),
                new SqlParameter("@NgayThue", hd.NgayThue),
                new SqlParameter("@NgayTra", hd.NgayTra == null ? DBNull.Value : hd.NgayTra),
                new SqlParameter("@TongTien", hd.TongTien),
                new SqlParameter("@TrangThai", hd.TrangThai)
                };
                return DataHelper.ExecuteNonQuery(sql, parameters);
            }

        // Read
        public DataTable LayDanhSachHopDong()
        {
            string sql = "SELECT * FROM HopDong";
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

        public HopDong LayHopDongTheoMa(int maHD)
        {
            string sql = "SELECT * FROM HopDong WHERE MaHD = @MaHD";
            SqlParameter[] parameter = new SqlParameter[] { new SqlParameter("@MaHD", maHD) };
            HopDong hd = null;

            using (SqlDataReader reader = DataHelper.ExecuteReader(sql, parameter))
            {
                if (reader.Read())
                {
                    hd = new HopDong();
                    hd.MaHD = reader.GetInt32(0);
                    hd.MaKH = reader.GetInt32(1);
                    hd.MaXe = reader.GetInt32(2);
                    hd.NgayThue = reader.GetDateTime(3);
                    hd.NgayTra = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    hd.TongTien = reader.GetDecimal(5);
                }
            }
            return hd;
        }

        // Update
        public int CapNhatHopDong(HopDong hd)
        {
            string sql = "UPDATE HopDong SET MaKH = @MaKH, MaXe = @MaXe, " +
                         "NgayThue = @NgayThue, NgayTra = @NgayTra, TongTien = @TongTien, TrangThai = @TrangThai " +
                         "WHERE MaHD = @MaHD";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@MaKH", hd.MaKH),
            new SqlParameter("@MaXe", hd.MaXe),
            new SqlParameter("@NgayThue", hd.NgayThue),
            new SqlParameter("@NgayTra", hd.NgayTra == null ? DBNull.Value : hd.NgayTra),
            new SqlParameter("@TongTien", hd.TongTien),
            new SqlParameter("@TrangThai", hd.TrangThai),
            new SqlParameter("@MaHD", hd.MaHD)
            };
            return DataHelper.ExecuteNonQuery(sql, parameters);
        }

        // Delete
        public int XoaHopDong(int maHD)
        {
            string sql = "DELETE FROM HopDong WHERE MaHD = @MaHD";
            SqlParameter[] parameter = new SqlParameter[] { new SqlParameter("@MaHD", maHD) };
            return DataHelper.ExecuteNonQuery(sql, parameter);
        }
        public int UpdateTrangThaiHopDong(int maHD, string trangThai)
        {
            string sql = "UPDATE HopDong SET TrangThai = @TrangThai WHERE MaHD = @MaHD";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TrangThai", trangThai),
                new SqlParameter("@MaHD", maHD)
            };

            return DataHelper.ExecuteNonQuery(sql, parameters);
        }
    }
}
