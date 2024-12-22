namespace ThueXe
{
    partial class FormXe
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
            btnChangeImg = new PictureBox();
            txtMaXe = new Label();
            txtMauXe = new TextBox();
            label6 = new Label();
            panelUpdate = new Panel();
            btnSua = new Button();
            btnXoa = new Button();
            panel5 = new Panel();
            btnReset = new Button();
            btnThem = new Button();
            cbbTinhTrang = new ComboBox();
            label11 = new Label();
            txtGiaThue = new TextBox();
            btnChangeImage = new Button();
            txtBienSo = new TextBox();
            label9 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtTen = new TextBox();
            label4 = new Label();
            label3 = new Label();
            picXe = new PictureBox();
            dgvXe = new DataGridView();
            AnhXe = new DataGridViewImageColumn();
            PathAnh = new DataGridViewTextBoxColumn();
            MaXe = new DataGridViewTextBoxColumn();
            HangXe = new DataGridViewTextBoxColumn();
            BienSo = new DataGridViewTextBoxColumn();
            MauXe = new DataGridViewTextBoxColumn();
            GiaThue = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewTextBoxColumn();
            ofd = new OpenFileDialog();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnChangeImg).BeginInit();
            panelUpdate.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picXe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvXe).BeginInit();
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
            panel8.TabIndex = 20;
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
            txtTimkiem.PlaceholderText = "Nhập hãng xe...";
            txtTimkiem.Size = new Size(331, 27);
            txtTimkiem.TabIndex = 5;
            txtTimkiem.Click += txtTimkiem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 23);
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
            panel6.TabIndex = 22;
            // 
            // titleTable
            // 
            titleTable.AutoSize = true;
            titleTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleTable.Location = new Point(3, 16);
            titleTable.Name = "titleTable";
            titleTable.Size = new Size(209, 28);
            titleTable.TabIndex = 14;
            titleTable.Text = "DANH SÁCH KHO XE";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnChangeImg);
            panel4.Controls.Add(txtMaXe);
            panel4.Controls.Add(txtMauXe);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(panelUpdate);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(cbbTinhTrang);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(txtGiaThue);
            panel4.Controls.Add(btnChangeImage);
            panel4.Controls.Add(txtBienSo);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtTen);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(picXe);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(712, 118);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(298, 630);
            panel4.TabIndex = 23;
            // 
            // btnChangeImg
            // 
            btnChangeImg.BackgroundImage = Properties.Resources.circular;
            btnChangeImg.BackgroundImageLayout = ImageLayout.Center;
            btnChangeImg.BorderStyle = BorderStyle.FixedSingle;
            btnChangeImg.Location = new Point(251, 167);
            btnChangeImg.Margin = new Padding(3, 4, 3, 4);
            btnChangeImg.Name = "btnChangeImg";
            btnChangeImg.Size = new Size(34, 39);
            btnChangeImg.TabIndex = 37;
            btnChangeImg.TabStop = false;
            btnChangeImg.Click += btnChangeImg_Click;
            // 
            // txtMaXe
            // 
            txtMaXe.AutoSize = true;
            txtMaXe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtMaXe.Location = new Point(222, 4);
            txtMaXe.Name = "txtMaXe";
            txtMaXe.Size = new Size(0, 20);
            txtMaXe.TabIndex = 36;
            txtMaXe.TextAlign = ContentAlignment.MiddleRight;
            txtMaXe.Visible = false;
            // 
            // txtMauXe
            // 
            txtMauXe.Location = new Point(74, 264);
            txtMauXe.Name = "txtMauXe";
            txtMauXe.Size = new Size(65, 27);
            txtMauXe.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label6.Location = new Point(209, 315);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 34;
            label6.Text = "VNĐ/Ngày";
            // 
            // panelUpdate
            // 
            panelUpdate.Controls.Add(btnSua);
            panelUpdate.Controls.Add(btnXoa);
            panelUpdate.Location = new Point(0, 415);
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
            // cbbTinhTrang
            // 
            cbbTinhTrang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbTinhTrang.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbTinhTrang.FormattingEnabled = true;
            cbbTinhTrang.Items.AddRange(new object[] { "Đang sẵn xe", "Đã được thuê", "Đang sửa chữa" });
            cbbTinhTrang.Location = new Point(74, 356);
            cbbTinhTrang.Margin = new Padding(3, 4, 3, 4);
            cbbTinhTrang.Name = "cbbTinhTrang";
            cbbTinhTrang.Size = new Size(211, 28);
            cbbTinhTrang.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 361);
            label11.Name = "label11";
            label11.Size = new Size(60, 20);
            label11.TabIndex = 30;
            label11.Text = "T.Trạng:";
            // 
            // txtGiaThue
            // 
            txtGiaThue.Location = new Point(74, 311);
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
            // txtBienSo
            // 
            txtBienSo.Location = new Point(200, 264);
            txtBienSo.Name = "txtBienSo";
            txtBienSo.Size = new Size(85, 27);
            txtBienSo.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(146, 269);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 24;
            label9.Text = "Biển số:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 271);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 16;
            label5.Text = "Màu xe:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(10, 4);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 9;
            label2.Text = "THÔNG TIN XE:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(74, 220);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(211, 27);
            txtTen.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 316);
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
            picXe.Size = new Size(277, 181);
            picXe.TabIndex = 14;
            picXe.TabStop = false;
            // 
            // dgvXe
            // 
            dgvXe.AllowUserToResizeColumns = false;
            dgvXe.BackgroundColor = Color.White;
            dgvXe.BorderStyle = BorderStyle.None;
            dgvXe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXe.Columns.AddRange(new DataGridViewColumn[] { AnhXe, PathAnh, MaXe, HangXe, BienSo, MauXe, GiaThue, TinhTrang });
            dgvXe.Dock = DockStyle.Fill;
            dgvXe.EnableHeadersVisualStyles = false;
            dgvXe.GridColor = SystemColors.Desktop;
            dgvXe.Location = new Point(0, 118);
            dgvXe.Margin = new Padding(3, 4, 3, 4);
            dgvXe.MultiSelect = false;
            dgvXe.Name = "dgvXe";
            dgvXe.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvXe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvXe.RowHeadersVisible = false;
            dgvXe.RowHeadersWidth = 51;
            dgvXe.RowTemplate.Height = 80;
            dgvXe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvXe.Size = new Size(712, 630);
            dgvXe.TabIndex = 24;
            dgvXe.Click += dgvXe_Click;
            // 
            // AnhXe
            // 
            AnhXe.HeaderText = "Ảnh";
            AnhXe.ImageLayout = DataGridViewImageCellLayout.Stretch;
            AnhXe.MinimumWidth = 6;
            AnhXe.Name = "AnhXe";
            AnhXe.Width = 125;
            // 
            // PathAnh
            // 
            PathAnh.HeaderText = "Path";
            PathAnh.MinimumWidth = 2;
            PathAnh.Name = "PathAnh";
            PathAnh.Resizable = DataGridViewTriState.False;
            PathAnh.Visible = false;
            PathAnh.Width = 2;
            // 
            // MaXe
            // 
            MaXe.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MaXe.DefaultCellStyle = dataGridViewCellStyle2;
            MaXe.HeaderText = "Mã số xe";
            MaXe.MinimumWidth = 6;
            MaXe.Name = "MaXe";
            MaXe.ReadOnly = true;
            MaXe.Visible = false;
            MaXe.Width = 125;
            // 
            // HangXe
            // 
            HangXe.HeaderText = "Hãng xe";
            HangXe.MinimumWidth = 6;
            HangXe.Name = "HangXe";
            HangXe.ReadOnly = true;
            HangXe.Width = 125;
            // 
            // BienSo
            // 
            BienSo.HeaderText = "Biển số";
            BienSo.MinimumWidth = 6;
            BienSo.Name = "BienSo";
            BienSo.ReadOnly = true;
            BienSo.Width = 125;
            // 
            // MauXe
            // 
            MauXe.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            MauXe.HeaderText = "Màu xe";
            MauXe.MinimumWidth = 6;
            MauXe.Name = "MauXe";
            MauXe.ReadOnly = true;
            MauXe.Width = 85;
            // 
            // GiaThue
            // 
            GiaThue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GiaThue.HeaderText = "Giá Thuê";
            GiaThue.MinimumWidth = 6;
            GiaThue.Name = "GiaThue";
            GiaThue.ReadOnly = true;
            // 
            // TinhTrang
            // 
            TinhTrang.HeaderText = "Tình Trạng";
            TinhTrang.MinimumWidth = 65;
            TinhTrang.Name = "TinhTrang";
            TinhTrang.ReadOnly = true;
            TinhTrang.Width = 125;
            // 
            // ofd
            // 
            ofd.FileName = "openFileDialog1";
            // 
            // FormXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 748);
            Controls.Add(dgvXe);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel8);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormXe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormXe";
            FormClosed += FormXe_FormClosed;
            Load += FormXe_Load;
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnChangeImg).EndInit();
            panelUpdate.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picXe).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvXe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel8;
        private Button btnHuyTimKiem;
        private Button btnTimKiem;
        private TextBox txtTimkiem;
        private Label label1;
        private Panel panel6;
        private Label titleTable;
        private Panel panel4;
        private Label label6;
        private Panel panelUpdate;
        private Button btnSua;
        private Button btnXoa;
        private Panel panel5;
        private Button btnReset;
        private Button btnThem;
        private ComboBox cbbTinhTrang;
        private Label label11;
        private TextBox txtGiaThue;
        private Button btnChangeImage;
        private TextBox txtBienSo;
        private Label label9;
        private Label label5;
        private Label label2;
        private TextBox txtTen;
        private Label label4;
        private Label label3;
        private PictureBox picXe;
        private DataGridView dgvXe;
        private TextBox txtMauXe;
        private Label txtMaXe;
        private PictureBox btnChangeImg;
        private OpenFileDialog ofd;
        private DataGridViewImageColumn AnhXe;
        private DataGridViewTextBoxColumn PathAnh;
        private DataGridViewTextBoxColumn MaXe;
        private DataGridViewTextBoxColumn HangXe;
        private DataGridViewTextBoxColumn BienSo;
        private DataGridViewTextBoxColumn MauXe;
        private DataGridViewTextBoxColumn GiaThue;
        private DataGridViewTextBoxColumn TinhTrang;
    }
}