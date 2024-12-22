namespace ThueXe
{
    partial class FormKhachHang
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvKH = new DataGridView();
            MaKH = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            CMND = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            ofd = new OpenFileDialog();
            label1 = new Label();
            txtTimkiem = new TextBox();
            btnTimKiem = new Button();
            btnHuyTimKiem = new Button();
            panel8 = new Panel();
            panel6 = new Panel();
            titleTable = new Label();
            panel4 = new Panel();
            txtMaKH = new Label();
            txtCMND = new TextBox();
            panelUpdate = new Panel();
            btnSua = new Button();
            btnXoa = new Button();
            panel5 = new Panel();
            btnReset = new Button();
            btnThem = new Button();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            label9 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtTen = new TextBox();
            label4 = new Label();
            lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panelUpdate.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKH
            // 
            dgvKH.AllowUserToResizeColumns = false;
            dgvKH.BackgroundColor = Color.White;
            dgvKH.BorderStyle = BorderStyle.None;
            dgvKH.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKH.Columns.AddRange(new DataGridViewColumn[] { MaKH, TenKH, CMND, DiaChi, SDT });
            dgvKH.EnableHeadersVisualStyles = false;
            dgvKH.GridColor = SystemColors.Desktop;
            dgvKH.Location = new Point(0, 117);
            dgvKH.Margin = new Padding(3, 4, 3, 4);
            dgvKH.MultiSelect = false;
            dgvKH.Name = "dgvKH";
            dgvKH.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKH.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKH.RowHeadersVisible = false;
            dgvKH.RowHeadersWidth = 51;
            dgvKH.RowTemplate.Height = 30;
            dgvKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKH.Size = new Size(712, 631);
            dgvKH.TabIndex = 28;
            dgvKH.Click += dgvKH_Click;
            // 
            // MaKH
            // 
            MaKH.HeaderText = "Mã KH";
            MaKH.MinimumWidth = 6;
            MaKH.Name = "MaKH";
            MaKH.ReadOnly = true;
            MaKH.Width = 125;
            // 
            // TenKH
            // 
            TenKH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenKH.HeaderText = "Tên Khách Hàng";
            TenKH.MinimumWidth = 6;
            TenKH.Name = "TenKH";
            TenKH.ReadOnly = true;
            // 
            // CMND
            // 
            CMND.HeaderText = "CMND";
            CMND.MinimumWidth = 6;
            CMND.Name = "CMND";
            CMND.ReadOnly = true;
            CMND.Width = 125;
            // 
            // DiaChi
            // 
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // SDT
            // 
            SDT.HeaderText = "Số điện thoại";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            SDT.ReadOnly = true;
            SDT.Width = 125;
            // 
            // ofd
            // 
            ofd.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 20);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 4;
            label1.Text = "Nội dung tìm kiếm:";
            // 
            // txtTimkiem
            // 
            txtTimkiem.Font = new Font("Segoe UI", 9F);
            txtTimkiem.Location = new Point(142, 17);
            txtTimkiem.MaximumSize = new Size(331, 50);
            txtTimkiem.MinimumSize = new Size(331, 22);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.PlaceholderText = "Nhập tên khách hàng...";
            txtTimkiem.Size = new Size(331, 27);
            txtTimkiem.TabIndex = 5;
            txtTimkiem.Click += txtTimkiem_Click;
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
            panel8.TabIndex = 25;
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
            panel6.TabIndex = 30;
            // 
            // titleTable
            // 
            titleTable.AutoSize = true;
            titleTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleTable.Location = new Point(9, 8);
            titleTable.Name = "titleTable";
            titleTable.Size = new Size(270, 28);
            titleTable.TabIndex = 14;
            titleTable.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtMaKH);
            panel4.Controls.Add(txtCMND);
            panel4.Controls.Add(panelUpdate);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(txtDiaChi);
            panel4.Controls.Add(txtSDT);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtTen);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(lbl);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(712, 118);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(298, 630);
            panel4.TabIndex = 31;
            // 
            // txtMaKH
            // 
            txtMaKH.AutoSize = true;
            txtMaKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtMaKH.Location = new Point(222, 4);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(0, 20);
            txtMaKH.TabIndex = 36;
            txtMaKH.TextAlign = ContentAlignment.MiddleRight;
            txtMaKH.Visible = false;
            // 
            // txtCMND
            // 
            txtCMND.Location = new Point(123, 67);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(159, 27);
            txtCMND.TabIndex = 35;
            // 
            // panelUpdate
            // 
            panelUpdate.Controls.Add(btnSua);
            panelUpdate.Controls.Add(btnXoa);
            panelUpdate.Location = new Point(3, 204);
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
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(123, 141);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(159, 27);
            txtDiaChi.TabIndex = 29;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(123, 104);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(159, 27);
            txtSDT.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 108);
            label9.Name = "label9";
            label9.Size = new Size(38, 20);
            label9.TabIndex = 24;
            label9.Text = "SDT:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 71);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 16;
            label5.Text = "CMND:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(10, 4);
            label2.Name = "label2";
            label2.Size = new Size(202, 20);
            label2.TabIndex = 9;
            label2.Text = "THÔNG TIN KHÁCH HÀNG:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(123, 29);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(159, 27);
            txtTen.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 145);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 12;
            label4.Text = "Địa chỉ:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(14, 33);
            lbl.Name = "lbl";
            lbl.Size = new Size(114, 20);
            lbl.TabIndex = 10;
            lbl.Text = "Tên khách hàng:";
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 748);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(dgvKH);
            Controls.Add(panel8);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKhachHang";
            FormClosed += FormKhachHang_FormClosed;
            Load += FormKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelUpdate.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvKH;
        private OpenFileDialog ofd;
        private Label label1;
        private TextBox txtTimkiem;
        private Button btnTimKiem;
        private Button btnHuyTimKiem;
        private Panel panel8;
        private Panel panel6;
        private Label titleTable;
        private Panel panel4;
        private Label txtMaKH;
        private TextBox txtCMND;
        private Panel panelUpdate;
        private Button btnSua;
        private Button btnXoa;
        private Panel panel5;
        private Button btnReset;
        private Button btnThem;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private Label label9;
        private Label label5;
        private Label label2;
        private TextBox txtTen;
        private Label label4;
        private Label lbl;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn CMND;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SDT;
    }
}