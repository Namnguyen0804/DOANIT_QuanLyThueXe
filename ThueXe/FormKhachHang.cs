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

namespace ThueXe
{
    public partial class FormKhachHang : Form
    {
        KhachHangADO khachHangADO;
        List<KhachHang> khachHangs;
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            khachHangADO = new KhachHangADO();
            khachHangs = new List<KhachHang>();
            LoadListKhachHang();
        }

        private void LoadListKhachHang()
        {
            try
            {
                dgvKH.AutoGenerateColumns = false;
                dgvKH.AllowUserToAddRows = false;
                DataTable dt = khachHangADO.LayDanhSachKhachHang();
                dgvKH.DataSource = dt;
                BindingDataGridViewUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void BindingDataGridViewUI()
        {
            dgvKH.Columns["MaKH"].DataPropertyName = "MaKH";
            dgvKH.Columns["TenKH"].DataPropertyName = "TenKH";
            dgvKH.Columns["CMND"].DataPropertyName = "CMND";
            dgvKH.Columns["DiaChi"].DataPropertyName = "DiaChi";
            dgvKH.Columns["SDT"].DataPropertyName = "SDT";
        }

        private void dgvKH_Click(object sender, EventArgs e)
        {
            var row = dgvKH.CurrentRow;
            txtMaKH.Text = row.Cells[0].Value.ToString();
            txtTen.Text = row.Cells[1].Value.ToString();
            txtCMND.Text = row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells[3].Value.ToString();
            txtSDT.Text = row.Cells[4].Value.ToString();
            panelUpdate.Visible = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ValidateForm();
            KhachHang kh = new KhachHang();
            kh.MaKH = int.Parse(txtMaKH.Text);
            kh.TenKH = txtTen.Text;
            kh.CMND = txtCMND.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.SDT = txtSDT.Text;
            khachHangADO.CapNhatKhachHang(kh);
            LoadListKhachHang();
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim().Length > 0)
            {
                var dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin khách hàng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    khachHangADO.XoaKhachHang(int.Parse(txtMaKH.Text.Trim()));
                    LoadListKhachHang();
                    Reset();
                }
            }
        }

        private void Reset()
        {
            txtMaKH.Text = "";
            txtTen.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTimkiem.Text = "";
            dgvKH.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ValidateForm();
            KhachHang kh = new KhachHang();
            kh.TenKH = txtTen.Text;
            kh.CMND = txtCMND.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.SDT = txtSDT.Text;
            khachHangADO.ThemKhachHang(kh);
            LoadListKhachHang();
            Reset();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void ValidateForm()
        {
            if (txtTen.Text == "" ||
                txtCMND.Text == "" ||
                txtDiaChi.Text == "" ||
                txtSDT.Text == ""
                ) { MessageBox.Show("Vui lòng nhập đủ thông tin."); return; }
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvKH.CurrentCell = null;
            foreach (DataGridViewRow row in dgvKH.Rows)
            {
                row.Visible = row.Cells[1].Value.ToString().ToLower().Contains(txtTimkiem.Text.ToLower());
            }
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            Reset();
            LoadListKhachHang();
        }

        private void FormKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormMain form = new FormMain();
            form.Show();
        }
    }
}
