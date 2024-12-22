namespace ThueXe
{
    partial class FormHopDong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel8 = new Panel();
            btnHuyTimKiem = new Button();
            btnTimKiem = new Button();
            txtTimkiem = new TextBox();
            label1 = new Label();
            panel6 = new Panel();
            titleTable = new Label();
            panel4 = new Panel();
            cbbTrangThai = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            txtTongTien = new Label();
            cbbKhachHang = new ComboBox();
            cbbHangXe = new ComboBox();
            label9 = new Label();
            dtpNgayTra = new DateTimePicker();
            label5 = new Label();
            dtpNgayThue = new DateTimePicker();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtMaHD = new Label();
            label6 = new Label();
            panelUpdate = new Panel();
            btnSua = new Button();
            btnXoa = new Button();
            panel5 = new Panel();
            btnReset = new Button();
            btnThem = new Button();
            txtGiaThue = new TextBox();
            btnChangeImage = new Button();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            picXe = new PictureBox();
            dgvHD = new DataGridView();
            MaHD = new DataGridViewTextBoxColumn();
            MaKH = new DataGridViewTextBoxColumn();
            MaXe = new DataGridViewTextBoxColumn();
            NgayThue = new DataGridViewTextBoxColumn();
            NgayTra = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panelUpdate.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picXe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.Controls.Add(btnHuyTimKiem);
            panel8.Controls.Add(btnTimKiem);
            panel8.Controls.Add(txtTimkiem);
            panel8.Controls.Add(label1);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(0, 20, 6, 0);
            panel8.Size = new Size(1010, 67);
            panel8.TabIndex = 21;
            // 
            // btnHuyTimKiem
            // 
            btnHuyTimKiem.BackColor = Color.Transparent;
            btnHuyTimKiem.BackgroundImageLayout = ImageLayout.Zoom;
            btnHuyTimKiem.FlatAppearance.BorderSize = 0;
            btnHuyTimKiem.FlatStyle = FlatStyle.Flat;
            btnHuyTimKiem.Image = Properties.Resources.clear2;
            btnHuyTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyTimKiem.Location = new Point(863, 13);
            btnHuyTimKiem.MaximumSize = new Size(143, 35);
            btnHuyTimKiem.MinimumSize = new Size(143, 35);
            btnHuyTimKiem.Name = "btnHuyTimKiem";
            btnHuyTimKiem.Padding = new Padding(10, 0, 10, 0);
            btnHuyTimKiem.Size = new Size(143, 35);
            btnHuyTimKiem.TabIndex = 7;
            btnHuyTimKiem.Text = "Hủy tìm kiếm";
            btnHuyTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnHuyTimKiem.UseVisualStyleBackColor = false;
            btnHuyTimKiem.Click += btnHuyTimKiem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(480, 17);
            btnTimKiem.MaximumSize = new Size(117, 35);
            btnTimKiem.MinimumSize = new Size(117, 29);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Padding = new Padding(6, 0, 6, 0);
            btnTimKiem.Size = new Size(117, 32);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Font = new Font("Segoe UI", 9F);
            txtTimkiem.Location = new Point(142, 17);
            txtTimkiem.MaximumSize = new Size(331, 50);
            txtTimkiem.MinimumSize = new Size(331, 22);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.PlaceholderText = "Nhập mã hợp đồng...";
            txtTimkiem.Size = new Size(331, 27);
            txtTimkiem.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 21);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 4;
            label1.Text = "Nội dung tìm kiếm:";
            // 
            // panel6
            // 
            panel6.Controls.Add(titleTable);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 67);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 8, 6, 0);
            panel6.Size = new Size(1010, 51);
            panel6.TabIndex = 23;
            // 
            // titleTable
            // 
            titleTable.AutoSize = true;
            titleTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleTable.Location = new Point(3, 11);
            titleTable.Name = "titleTable";
            titleTable.Size = new Size(245, 28);
            titleTable.TabIndex = 14;
            titleTable.Text = "DANH SÁCH HỢP ĐỒNG";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(cbbTrangThai);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(txtTongTien);
            panel4.Controls.Add(cbbKhachHang);
            panel4.Controls.Add(cbbHangXe);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(dtpNgayTra);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(dtpNgayThue);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txtMaHD);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(panelUpdate);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(txtGiaThue);
            panel4.Controls.Add(btnChangeImage);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(picXe);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(712, 118);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(298, 630);
            panel4.TabIndex = 24;
            // 
            // cbbTrangThai
            // 
            cbbTrangThai.FormattingEnabled = true;
            cbbTrangThai.Items.AddRange(new object[] { "Mới lập", "Đang hoạt động", "Đã thanh toán" });
            cbbTrangThai.Location = new Point(77, 411);
            cbbTrangThai.Margin = new Padding(3, 4, 3, 4);
            cbbTrangThai.Name = "cbbTrangThai";
            cbbTrangThai.Size = new Size(211, 28);
            cbbTrangThai.TabIndex = 51;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 415);
            label11.Name = "label11";
            label11.Size = new Size(51, 20);
            label11.TabIndex = 50;
            label11.Text = "T.Thái:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label12.Location = new Point(245, 448);
            label12.Name = "label12";
            label12.Size = new Size(40, 20);
            label12.TabIndex = 49;
            label12.Text = "VNĐ";
            // 
            // txtTongTien
            // 
            txtTongTien.AutoSize = true;
            txtTongTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtTongTien.ImageAlign = ContentAlignment.MiddleRight;
            txtTongTien.Location = new Point(150, 448);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(18, 20);
            txtTongTien.TabIndex = 48;
            txtTongTien.Text = "0";
            txtTongTien.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbbKhachHang
            // 
            cbbKhachHang.FormattingEnabled = true;
            cbbKhachHang.Location = new Point(75, 333);
            cbbKhachHang.Margin = new Padding(3, 4, 3, 4);
            cbbKhachHang.Name = "cbbKhachHang";
            cbbKhachHang.Size = new Size(211, 28);
            cbbKhachHang.TabIndex = 47;
       
            // 
            // cbbHangXe
            // 
            cbbHangXe.FormattingEnabled = true;
            cbbHangXe.Location = new Point(74, 221);
            cbbHangXe.Margin = new Padding(3, 4, 3, 4);
            cbbHangXe.Name = "cbbHangXe";
            cbbHangXe.Size = new Size(211, 28);
            cbbHangXe.TabIndex = 46;
            cbbHangXe.SelectedValueChanged += cbbHangXe_SelectedValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(159, 379);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 45;
            label9.Text = "N.Trả:";
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            dtpNgayTra.Format = DateTimePickerFormat.Custom;
            dtpNgayTra.Location = new Point(211, 372);
            dtpNgayTra.Margin = new Padding(3, 4, 3, 4);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(76, 27);
            dtpNgayTra.TabIndex = 44;
            dtpNgayTra.ValueChanged += dtpNgayTra_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 379);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 43;
            label5.Text = "N.Thuê:";
            // 
            // dtpNgayThue
            // 
            dtpNgayThue.CustomFormat = "dd/MM/yyyy";
            dtpNgayThue.Format = DateTimePickerFormat.Custom;
            dtpNgayThue.Location = new Point(75, 371);
            dtpNgayThue.Margin = new Padding(3, 4, 3, 4);
            dtpNgayThue.Name = "dtpNgayThue";
            dtpNgayThue.Size = new Size(76, 27);
            dtpNgayThue.TabIndex = 42;
            dtpNgayThue.ValueChanged += dtpNgayThue_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(74, 449);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 41;
            label10.Text = "Tổng tiền";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 337);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 40;
            label8.Text = "K.Hàng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(57, 303);
            label7.Name = "label7";
            label7.Size = new Size(202, 20);
            label7.TabIndex = 38;
            label7.Text = "THÔNG TIN KHÁCH HÀNG:";
            // 
            // txtMaHD
            // 
            txtMaHD.AutoSize = true;
            txtMaHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtMaHD.Location = new Point(222, 4);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(0, 20);
            txtMaHD.TabIndex = 36;
            txtMaHD.TextAlign = ContentAlignment.MiddleRight;
            txtMaHD.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label6.Location = new Point(209, 267);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 34;
            label6.Text = "VNĐ/Ngày";
            // 
            // panelUpdate
            // 
            panelUpdate.Controls.Add(btnSua);
            panelUpdate.Controls.Add(btnXoa);
            panelUpdate.Location = new Point(0, 473);
            panelUpdate.Margin = new Padding(3, 4, 3, 4);
            panelUpdate.Name = "panelUpdate";
            panelUpdate.Size = new Size(296, 84);
            panelUpdate.TabIndex = 33;
            panelUpdate.Visible = false;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.write;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(184, 16);
            btnSua.Name = "btnSua";
            btnSua.Padding = new Padding(10, 0, 10, 0);
            btnSua.Size = new Size(101, 51);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.clear2;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(10, 16);
            btnXoa.Name = "btnXoa";
            btnXoa.Padding = new Padding(10, 0, 10, 0);
            btnXoa.Size = new Size(101, 51);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnReset);
            panel5.Controls.Add(btnThem);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 547);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(296, 81);
            panel5.TabIndex = 32;
            // 
            // btnReset
            // 
            btnReset.Image = Properties.Resources.circular;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(184, 16);
            btnReset.Name = "btnReset";
            btnReset.Padding = new Padding(10, 0, 10, 0);
            btnReset.Size = new Size(101, 51);
            btnReset.TabIndex = 33;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.MiddleRight;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.add;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(10, 16);
            btnThem.Name = "btnThem";
            btnThem.Padding = new Padding(10, 0, 10, 0);
            btnThem.Size = new Size(101, 51);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtGiaThue
            // 
            txtGiaThue.Enabled = false;
            txtGiaThue.Location = new Point(74, 263);
            txtGiaThue.Name = "txtGiaThue";
            txtGiaThue.Size = new Size(126, 27);
            txtGiaThue.TabIndex = 29;
            // 
            // btnChangeImage
            // 
            btnChangeImage.Image = Properties.Resources.circular;
            btnChangeImage.Location = new Point(350, 268);
            btnChangeImage.Margin = new Padding(23, 28, 23, 28);
            btnChangeImage.Name = "btnChangeImage";
            btnChangeImage.Padding = new Padding(10, 0, 10, 0);
            btnChangeImage.Size = new Size(43, 43);
            btnChangeImage.TabIndex = 26;
            btnChangeImage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(95, 4);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 9;
            label2.Text = "THÔNG TIN XE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 268);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 12;
            label4.Text = "Giá thuê:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 225);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 10;
            label3.Text = "Hãng xe:";
            // 
            // picXe
            // 
            picXe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picXe.BackgroundImage = Properties.Resources.motocycle;
            picXe.BackgroundImageLayout = ImageLayout.Zoom;
            picXe.BorderStyle = BorderStyle.FixedSingle;
            picXe.Location = new Point(10, 28);
            picXe.Margin = new Padding(3, 4, 3, 4);
            picXe.MaximumSize = new Size(277, 253);
            picXe.MinimumSize = new Size(277, 133);
            picXe.Name = "picXe";
            picXe.Size = new Size(277, 178);
            picXe.TabIndex = 14;
            picXe.TabStop = false;
            // 
            // dgvHD
            // 
            dgvHD.AllowUserToResizeColumns = false;
            dgvHD.BackgroundColor = Color.White;
            dgvHD.BorderStyle = BorderStyle.None;
            dgvHD.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHD.Columns.AddRange(new DataGridViewColumn[] { MaHD, MaKH, MaXe, NgayThue, NgayTra, TongTien, TrangThai });
            dgvHD.Dock = DockStyle.Fill;
            dgvHD.EnableHeadersVisualStyles = false;
            dgvHD.GridColor = SystemColors.Desktop;
            dgvHD.Location = new Point(0, 118);
            dgvHD.Margin = new Padding(3, 4, 3, 4);
            dgvHD.MultiSelect = false;
            dgvHD.Name = "dgvHD";
            dgvHD.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvHD.RowHeadersVisible = false;
            dgvHD.RowHeadersWidth = 51;
            dgvHD.RowTemplate.Height = 30;
            dgvHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHD.Size = new Size(712, 630);
            dgvHD.TabIndex = 25;
            dgvHD.Click += dgvHD_Click;
            // 
            // MaHD
            // 
            MaHD.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MaHD.DefaultCellStyle = dataGridViewCellStyle2;
            MaHD.HeaderText = "Mã HD";
            MaHD.MinimumWidth = 6;
            MaHD.Name = "MaHD";
            MaHD.ReadOnly = true;
            MaHD.Width = 84;
            // 
            // MaKH
            // 
            MaKH.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            MaKH.HeaderText = "Mã KH";
            MaKH.MinimumWidth = 6;
            MaKH.Name = "MaKH";
            MaKH.ReadOnly = true;
            MaKH.Width = 82;
            // 
            // MaXe
            // 
            MaXe.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            MaXe.HeaderText = "Mã Xe";
            MaXe.MinimumWidth = 6;
            MaXe.Name = "MaXe";
            MaXe.ReadOnly = true;
            MaXe.Width = 79;
            // 
            // NgayThue
            // 
            NgayThue.HeaderText = "Ngày Thuê";
            NgayThue.MinimumWidth = 6;
            NgayThue.Name = "NgayThue";
            NgayThue.ReadOnly = true;
            NgayThue.Width = 125;
            // 
            // NgayTra
            // 
            NgayTra.HeaderText = "Ngày trả";
            NgayTra.MinimumWidth = 6;
            NgayTra.Name = "NgayTra";
            NgayTra.ReadOnly = true;
            NgayTra.Width = 125;
            // 
            // TongTien
            // 
            TongTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 65;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            // 
            // TrangThai
            // 
            TrangThai.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TrangThai.HeaderText = "Trạng Thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.Width = 98;
            // 
            // FormHopDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 748);
            Controls.Add(dgvHD);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel8);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormHopDong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHopDong";
            FormClosed += FormHopDong_FormClosed;
            Load += FormHopDong_Load;
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelUpdate.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picXe).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel8;
        private Button btnHuyTimKiem;
        private Button btnTimKiem;
        private Label label1;
        private Panel panel6;
        private Label titleTable;
        private Panel panel4;
        private Label txtMaHD;
        private Label label6;
        private Panel panelUpdate;
        private Button btnSua;
        private Button btnXoa;
        private Panel panel5;
        private Button btnReset;
        private Button btnThem;
        private TextBox txtGiaThue;
        private Button btnChangeImage;
        private Label label2;
        private Label label4;
        private Label label3;
        private PictureBox picXe;
        private DataGridView dgvHD;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label9;
        private DateTimePicker dtpNgayTra;
        private Label label5;
        private DateTimePicker dtpNgayThue;
        private Label txtTongTien;
        private ComboBox cbbKhachHang;
        private ComboBox cbbHangXe;
        private Label label12;
        private ComboBox cbbTrangThai;
        private Label label11;
        private TextBox txtTimkiem;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn MaXe;
        private DataGridViewTextBoxColumn NgayThue;
        private DataGridViewTextBoxColumn NgayTra;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn TrangThai;
    }
}