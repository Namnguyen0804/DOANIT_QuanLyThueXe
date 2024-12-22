using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThueXe.ADO;

namespace ThueXe
{
    public partial class FormThongKe : Form
    {
        XeMayADO xeMayADO;
        KhachHangADO khachHangADO;
        HopDongADO hopDongADO;
        ThongKeADO thongKeADO;
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            xeMayADO = new XeMayADO();
            khachHangADO = new KhachHangADO();
            hopDongADO = new HopDongADO();
            thongKeADO = new ThongKeADO();
            LoadSoLieu();
        }

        private void LoadSoLieu()
        {
            txtSoLuongXe.Text = xeMayADO.LayDanhSachXeMay().Rows.Count.ToString();
            txtSoLuongKH.Text = khachHangADO.LayDanhSachKhachHang().Rows.Count.ToString();
            decimal tongDoanhThu = 0;
            foreach (DataRow r in hopDongADO.LayDanhSachHopDong().Rows)
            {
                tongDoanhThu += decimal.Parse(r["TongTien"].ToString());
            }
            txtTongDoanhThu.Text = tongDoanhThu.ToString("0");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpFrom.Value;
            DateTime denNgay = dtpTo.Value;
            DataTable dtSoLuongXe = thongKeADO.ThongKeSoLuongXeDaThue(tuNgay, denNgay);
            HienThiKetQuaThongKe(listView1, dtSoLuongXe);
        }
        private void HienThiKetQuaThongKe(DataGridView listView, DataTable dt)
        {

            listView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = dateTimePicker3.Value.Year;
            DataTable dtDoanhThuNam = thongKeADO.ThongKeTongDoanhThuTheoThang(year);
            HienThiKetQuaThongKe(listView1, dtDoanhThuNam);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dtKhachHang = thongKeADO.ThongKeKhachHangThueXeNhieuNhat();
            HienThiKetQuaThongKe(listView1, dtKhachHang);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dtLoaiXe = thongKeADO.ThongKeLoaiXeDuocThueNhieuNhat();
            HienThiKetQuaThongKe(listView1, dtLoaiXe);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dSXeSC = thongKeADO.ThongKeXeDangSuaChua();
            HienThiKetQuaThongKe(listView1, dSXeSC);
        }

        private void FormThongKe_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormMain form = new FormMain();
            form.Show();
        }
    }
}
