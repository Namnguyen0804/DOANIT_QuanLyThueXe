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
    public partial class FormXe : Form
    {
        XeMayADO xeMayADO;
        List<XeMay> xeMays;
        private string currentFilePath;
        private bool isImageSelected;

        public FormXe()
        {
            InitializeComponent();
        }

        private void FormXe_Load(object sender, EventArgs e)
        {
            xeMayADO = new XeMayADO();
            xeMays = new List<XeMay>();
            LoadListXe();
        }

        private void LoadListXe()
        {
            try
            {
                dgvXe.AutoGenerateColumns = false;
                dgvXe.AllowUserToAddRows = false;
                DataTable dt = xeMayADO.LayDanhSachXeMay();
                dgvXe.DataSource = dt;

                BindingDataGridViewUI();
                LoadImage(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void LoadImage(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].ToString().Length < 1) { ((DataGridViewImageCell)dgvXe.Rows[i].Cells[0]).Value = Resources.motocycle; continue; }
                ((DataGridViewImageCell)dgvXe.Rows[i].Cells[0]).Value = Image.FromFile(dt.Rows[i][1].ToString());
            }
        }

        private void BindingDataGridViewUI()
        {
            dgvXe.Columns["PathAnh"].DataPropertyName = "AnhXe";
            dgvXe.Columns["MaXe"].DataPropertyName = "MaXe";
            dgvXe.Columns["HangXe"].DataPropertyName = "HangXe";
            dgvXe.Columns["MauXe"].DataPropertyName = "MauXe";
            dgvXe.Columns["BienSo"].DataPropertyName = "BienSo";
            dgvXe.Columns["GiaThue"].DataPropertyName = "GiaThue";
            dgvXe.Columns["TinhTrang"].DataPropertyName = "TinhTrang";
        }

        private void dgvXe_Click(object sender, EventArgs e)
        {
            var row = dgvXe.CurrentRow;
            picXe.BackgroundImage = row.Cells[0].Value as Image;
            currentFilePath = row.Cells[1].Value.ToString();
            txtMaXe.Text = row.Cells[2].Value.ToString();
            txtTen.Text = row.Cells[3].Value.ToString();
            txtBienSo.Text = row.Cells[4].Value.ToString();
            txtMauXe.Text = row.Cells[5].Value.ToString();
            txtGiaThue.Text = row.Cells[6].Value.ToString();
            cbbTinhTrang.Text = row.Cells[7].Value.ToString();
            panelUpdate.Visible = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ValidateForm();
            var xe = new XeMay();
            xe.MaXe = int.Parse(txtMaXe.Text.Trim());
            xe.HangXe = txtTen.Text.Trim();
            xe.MauXe = txtMauXe.Text.Trim();
            xe.AnhXe = currentFilePath;
            xe.BienSo = txtBienSo.Text.Trim();
            xe.GiaThue = decimal.Parse(txtGiaThue.Text.Trim());
            xe.TinhTrang = cbbTinhTrang.Text.Trim();
            xeMayADO.CapNhatXeMay(xe);
            LoadListXe();
            Reset();
        }

        private void btnChangeImg_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                string trailFile = ofd.FileName.Substring(ofd.FileName.Length - 3, 3);
                if (trailFile == "jpg" || trailFile == "png" || trailFile == "jpeg")
                {
                    currentFilePath = ofd.FileName;
                    picXe.BackgroundImageLayout = ImageLayout.Stretch;
                    picXe.BackgroundImage = Image.FromFile(currentFilePath);
                    isImageSelected = true;
                }
                else
                {
                    MessageBox.Show("Định dạng file ảnh chưa đúng. (Phải bao gồm: .png, .jpg, .jpeg) ");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ValidateForm();
            var xe = new XeMay();
            xe.HangXe = txtTen.Text.Trim();
            xe.MauXe = txtMauXe.Text.Trim();
            xe.AnhXe = currentFilePath;
            xe.BienSo = txtBienSo.Text.Trim();
            xe.GiaThue = decimal.Parse(txtGiaThue.Text.Trim());
            xe.TinhTrang = cbbTinhTrang.Text.Trim();
            xeMayADO.ThemXeMay(xe);
            LoadListXe();
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaXe.Text.Trim().Length > 0)
            {
                var dr = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin chiếc xe này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    xeMayADO.XoaXeMay(int.Parse(txtMaXe.Text.Trim()));
                    LoadListXe();
                    Reset();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            picXe.BackgroundImage = Resources.motocycle;
            picXe.BackgroundImageLayout = ImageLayout.Stretch;
            currentFilePath = "";
            txtMaXe.Text = "";
            txtTen.Text = "";
            txtBienSo.Text = "";
            txtMauXe.Text = "";
            txtGiaThue.Text = "";
            cbbTinhTrang.Text = "";
            txtTimkiem.Text = "";
            panelUpdate.Visible = false;
            dgvXe.ClearSelection();
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            Reset();
            LoadListXe();
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void ValidateForm()
        {
            if (txtTen.Text == "" ||
                txtBienSo.Text == "" ||
                txtMauXe.Text == "" ||
                txtGiaThue.Text == "" ||
                cbbTinhTrang.Text == "") { MessageBox.Show("Vui lòng nhập đủ thông tin."); return; }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvXe.CurrentCell = null;
            foreach (DataGridViewRow row in dgvXe.Rows)
            {
                row.Visible = row.Cells[3].Value.ToString().ToLower().Contains(txtTimkiem.Text.ToLower());
            }
        }

        private void FormXe_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormMain form = new FormMain();
            form.Show();
        }

        
    }
}
