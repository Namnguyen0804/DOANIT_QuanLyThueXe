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
using ThueXe.Model;
using ThueXe.Properties;

namespace ThueXe
{
    public partial class FormHopDong : Form
    {
        HopDongADO hopDongADO;
        XeMayADO xeMayADO;
        KhachHangADO khachHangADO;

        public FormHopDong()
        {
            InitializeComponent();
        }

        private void FormHopDong_Load(object sender, EventArgs e)
        {
            hopDongADO = new HopDongADO();
            xeMayADO = new XeMayADO();
            khachHangADO = new KhachHangADO();
            LoadListHD();
            LoadCbbXe();
            LoadCbbKhachHang();
        }

        private void LoadCbbXe()
        {
            cbbHangXe.Items.Clear();
            foreach (DataRow r in xeMayADO.LayDanhSachXeMay().Rows)
            {
                if (r["TinhTrang"].ToString().Equals("Đang sẵn xe"))
                {
                    cbbHangXe.Items.Add(r["MaXe"] + " - " + r["HangXe"]);
                }
            }
        }

        private void LoadCbbKhachHang()
        {
            cbbKhachHang.Items.Clear();
            foreach (DataRow r in khachHangADO.LayDanhSachKhachHang().Rows)
            {
                cbbKhachHang.Items.Add(r["MaKH"] + " - " + r["TenKH"]);
            }
        }

        private void LoadListHD()
        {
            try
            {
                dgvHD.AutoGenerateColumns = false;
                dgvHD.AllowUserToAddRows = false;
                DataTable dt = hopDongADO.LayDanhSachHopDong();
                dgvHD.DataSource = dt;

                BindingDataGridViewUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void BindingDataGridViewUI()
        {
            dgvHD.Columns["MaHD"].DataPropertyName = "MaHD";
            dgvHD.Columns["MaXe"].DataPropertyName = "MaXe";
            dgvHD.Columns["MaKH"].DataPropertyName = "MaKH";
            dgvHD.Columns["NgayThue"].DataPropertyName = "NgayThue";
            dgvHD.Columns["NgayTra"].DataPropertyName = "NgayTra";
            dgvHD.Columns["TongTien"].DataPropertyName = "TongTien";
            dgvHD.Columns["TrangThai"].DataPropertyName = "TrangThai";
        }

        private void dgvHD_Click(object sender, EventArgs e)
        {
            var row = dgvHD.CurrentRow;
            txtMaHD.Text = row.Cells[0].Value.ToString();
            LoadThongTinKhachHang((int)row.Cells[1].Value);
            LoadThongTinXe((int)row.Cells[2].Value);
            dtpNgayThue.Value = DateTime.Parse(row.Cells[3].Value.ToString());
            dtpNgayTra.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            txtTongTien.Text = row.Cells[5].Value.ToString();
            cbbTrangThai.Text = row.Cells[6].Value.ToString();
            panelUpdate.Visible = true;
            if (cbbTrangThai.Text == "Đã thanh toán")
            {
                dtpNgayThue.Enabled = dtpNgayTra.Enabled = cbbTrangThai.Enabled = btnSua.Visible = false;
            }
            else
            {
                dtpNgayThue.Enabled = dtpNgayTra.Enabled = cbbTrangThai.Enabled = btnSua.Visible = true;
            }
            cbbHangXe.Enabled = false;
            cbbKhachHang.Enabled = false;
            txtGiaThue.Enabled = false;
        }

        private void LoadThongTinKhachHang(int value)
        {
            KhachHang r = khachHangADO.LayKhachHangTheoMa(value);
            cbbKhachHang.Text = r.MaKH + " - " + r.TenKH;
        }

        private void LoadThongTinXe(int value)
        {
            XeMay x = xeMayADO.LayXeMayTheoMa(value);
            picXe.BackgroundImage = Image.FromFile(x.AnhXe);
            cbbHangXe.Text = x.MaXe + " - " + x.HangXe;
            txtGiaThue.Text = x.GiaThue.ToString();
        }

        private void cbbHangXe_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadThongTinXe(int.Parse(cbbHangXe.Text.Split(" - ")[0]));
        }

        public void Reset()
        {
            cbbHangXe.Text = "";
            cbbKhachHang.Text = "";
            cbbTrangThai.Text = "";
            txtGiaThue.Text = "";
            dtpNgayThue.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
            txtTongTien.Text = "";
            dtpNgayThue.Enabled = dtpNgayTra.Enabled = cbbTrangThai.Enabled = btnSua.Visible = true;
            picXe.BackgroundImage = Resources.motocycle;
            cbbHangXe.Enabled = true;
            panelUpdate.Visible = false;
            cbbKhachHang.Enabled = true;
            dgvHD.ClearSelection();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CheckFromToDay();
            ValidateForm();
            HopDong hd = new HopDong();
            hd.MaHD = int.Parse(txtMaHD.Text);
            hd.MaXe = int.Parse(cbbHangXe.Text.Split(" - ")[0]);
            hd.MaKH = int.Parse(cbbKhachHang.Text.Split(" - ")[0]);
            hd.NgayTra = dtpNgayTra.Value;
            hd.NgayThue = dtpNgayThue.Value;
            hd.TongTien = decimal.Parse(txtTongTien.Text.Trim());
            hd.TrangThai = cbbTrangThai.Text;
            hopDongADO.CapNhatHopDong(hd);
            LoadListHD();
            if (hd.TrangThai == "Đã thanh toán")
            {
                SetStatusXe(hd.MaXe, "Đang sẵn xe");
                LoadCbbXe();
            }
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim().Length > 0)
            {
                var dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin hợp đồng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    hopDongADO.XoaHopDong(int.Parse(txtMaHD.Text.Trim()));
                    LoadListHD();
                    Reset();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CheckFromToDay();
            ValidateForm();
            HopDong hd = new HopDong();
            hd.MaXe = int.Parse(cbbHangXe.Text.Split(" - ")[0]);
            hd.MaKH = int.Parse(cbbKhachHang.Text.Split(" - ")[0]);
            hd.NgayThue = dtpNgayThue.Value;
            hd.NgayTra = dtpNgayTra.Value;
            hd.TongTien = decimal.Parse(txtTongTien.Text.Trim());
            hd.TrangThai = "Mới lập";
            hopDongADO.ThemHopDong(hd);
            SetStatusXe(hd.MaXe, "Đã được thuê");
            LoadListHD();
            Reset();
        }

        private void SetStatusXe(int maXe, string stt)
        {
            xeMayADO.CapNhatTinhTrangXe(maXe, stt);
        }

        private void FormHopDong_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormMain form = new FormMain();
            form.Show();
        }

        private void dtpNgayThue_ValueChanged(object sender, EventArgs e)
        {
            CalculateTongTien();
        }

        private void CalculateTongTien()
        {
            try
            {
                txtTongTien.Text = (decimal.Parse(txtGiaThue.Text.Trim()) * (decimal)(dtpNgayTra.Value - dtpNgayThue.Value).TotalDays).ToString("0");
            }
            catch (Exception ex)
            {

            }
        }

        private void CheckFromToDay()
        {
            if (dtpNgayThue.Value >= dtpNgayTra.Value)
            {
                MessageBox.Show("Ngày thuê/trả không hợp lệ!");
                return;
            }
        }

        private void dtpNgayTra_ValueChanged(object sender, EventArgs e)
        {
            CheckFromToDay();
            CalculateTongTien();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvHD.CurrentCell = null;
            foreach (DataGridViewRow row in dgvHD.Rows)
            {
                row.Visible = (int)row.Cells[0].Value == int.Parse(txtTimkiem.Text);
            }
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            Reset();
            LoadListHD();
        }

        private void ValidateForm()
        {
            if (cbbHangXe.Text == "" ||
                cbbKhachHang.Text == "" ||
                cbbTrangThai.Text == ""
                )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }
        }

    }
}
