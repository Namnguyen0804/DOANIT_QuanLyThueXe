using Microsoft.Data.SqlClient;
using System.Data;
using ThueXe.Model;

namespace ThueXe.ADO
{
    public class XeMayADO
    {
        //themxe
        public int ThemXeMay(XeMay xm)
        {
            string sql = "INSERT INTO XeMay (BienSo, HangXe, MauXe, GiaThue, TinhTrang, AnhXe) " +
                         "VALUES (@BienSo, @HangXe, @MauXe, @GiaThue, @TinhTrang, @AnhXe)";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@BienSo", xm.BienSo),
            new SqlParameter("@HangXe", xm.HangXe),
            new SqlParameter("@MauXe", xm.MauXe),
            new SqlParameter("@GiaThue", xm.GiaThue),
            new SqlParameter("@TinhTrang", xm.TinhTrang),
            new SqlParameter("@AnhXe", xm.AnhXe)
            };
            return DataHelper.ExecuteNonQuery(sql, parameters);
        }

        // Read
        public DataTable LayDanhSachXeMay()
        {
            string sql = "SELECT * FROM XeMay";
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

        public XeMay LayXeMayTheoMa(int maXe)
        {
            string sql = "SELECT * FROM XeMay WHERE MaXe = @MaXe";
            SqlParameter[] parameter = new SqlParameter[] { new SqlParameter("@MaXe", maXe) };
            XeMay xm = null;

            using (SqlDataReader reader = DataHelper.ExecuteReader(sql, parameter))
            {
                if (reader.Read())
                {
                    xm = new XeMay();
                    xm.MaXe = reader.GetInt32(0);
                    xm.BienSo = reader.GetString(4);
                    xm.HangXe = reader.GetString(2);
                    xm.MauXe = reader.GetString(3);
                    xm.GiaThue = reader.GetDecimal(5);
                    xm.TinhTrang = reader.GetString(6);
                    xm.AnhXe = reader.GetString(1);
                }
            }
            return xm;
        }

        // Update
        public int CapNhatXeMay(XeMay xm)
        {
            string sql = "UPDATE XeMay SET BienSo = @BienSo, HangXe = @HangXe, " +
                         "MauXe = @MauXe, GiaThue = @GiaThue, TinhTrang = @TinhTrang, AnhXe = @AnhXe " +
                         "WHERE MaXe = @MaXe";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@BienSo", xm.BienSo),
            new SqlParameter("@HangXe", xm.HangXe),
            new SqlParameter("@MauXe", xm.MauXe),
            new SqlParameter("@GiaThue", xm.GiaThue),
            new SqlParameter("@TinhTrang", xm.TinhTrang),
            new SqlParameter("@AnhXe", xm.AnhXe),
            new SqlParameter("@MaXe", xm.MaXe)
            };
            return DataHelper.ExecuteNonQuery(sql, parameters);
        }

        // Delete
        public int XoaXeMay(int maXe)
        {
            string sql = "DELETE FROM XeMay WHERE MaXe = @MaXe";
            SqlParameter[] parameter = new SqlParameter[] { new SqlParameter("@MaXe", maXe) };
            return DataHelper.ExecuteNonQuery(sql, parameter);
        }
        // tinhtrang
        public int CapNhatTinhTrangXe(int maXe, string tinhTrang)
        {
            string sql = "UPDATE XeMay SET TinhTrang = @TinhTrang WHERE MaXe = @MaXe";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TinhTrang", tinhTrang),
                new SqlParameter("@MaXe", maXe)
            };

            return DataHelper.ExecuteNonQuery(sql, parameters);
        }
    }
}
