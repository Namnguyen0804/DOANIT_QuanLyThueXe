namespace ThueXe
{
    partial class FormThongKe
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
            label1 = new Label();
            panel1 = new Panel();
            txtSoLuongXe = new Label();
            panel2 = new Panel();
            txtSoLuongKH = new Label();
            label4 = new Label();
            panel3 = new Panel();
            txtTongDoanhThu = new Label();
            label6 = new Label();
            btndoanhthuthang = new Button();
            btnkhachthuenhieunhat = new Button();
            btnxethuenhieunhat = new Button();
            btnxedangsua = new Button();
            btnslxedachothue = new Button();
            dtpTo = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            dtpFrom = new DateTimePicker();
            label9 = new Label();
            dateTimePicker3 = new DateTimePicker();
            listView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(311, 41);
            label1.TabIndex = 0;
            label1.Text = "TỔNG SỐ LƯỢNG XE";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtSoLuongXe);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 5);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 190);
            panel1.TabIndex = 1;
            // 
            // txtSoLuongXe
            // 
            txtSoLuongXe.AutoSize = true;
            txtSoLuongXe.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold);
            txtSoLuongXe.Location = new Point(113, 64);
            txtSoLuongXe.Name = "txtSoLuongXe";
            txtSoLuongXe.Size = new Size(77, 89);
            txtSoLuongXe.TabIndex = 1;
            txtSoLuongXe.Text = "5";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtSoLuongKH);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(343, 5);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 190);
            panel2.TabIndex = 2;
            // 
            // txtSoLuongKH
            // 
            txtSoLuongKH.AutoSize = true;
            txtSoLuongKH.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold);
            txtSoLuongKH.Location = new Point(113, 64);
            txtSoLuongKH.Name = "txtSoLuongKH";
            txtSoLuongKH.Size = new Size(77, 89);
            txtSoLuongKH.TabIndex = 1;
            txtSoLuongKH.Text = "3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 21);
            label4.Name = "label4";
            label4.Size = new Size(220, 41);
            label4.TabIndex = 0;
            label4.Text = "KHÁCH HÀNG";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtTongDoanhThu);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(680, 5);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(324, 190);
            panel3.TabIndex = 3;
            // 
            // txtTongDoanhThu
            // 
            txtTongDoanhThu.AutoSize = true;
            txtTongDoanhThu.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold);
            txtTongDoanhThu.Location = new Point(27, 64);
            txtTongDoanhThu.Name = "txtTongDoanhThu";
            txtTongDoanhThu.Size = new Size(77, 89);
            txtTongDoanhThu.TabIndex = 1;
            txtTongDoanhThu.Text = "3";
            txtTongDoanhThu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 21);
            label6.Name = "label6";
            label6.Size = new Size(296, 41);
            label6.TabIndex = 0;
            label6.Text = "TỔNG DOANH THU";
            // 
            // btndoanhthuthang
            // 
            btndoanhthuthang.Location = new Point(6, 411);
            btndoanhthuthang.Margin = new Padding(3, 4, 3, 4);
            btndoanhthuthang.Name = "btndoanhthuthang";
            btndoanhthuthang.Size = new Size(239, 71);
            btndoanhthuthang.TabIndex = 8;
            btndoanhthuthang.Text = "Doanh thu theo tháng";
            btndoanhthuthang.UseVisualStyleBackColor = true;
            btndoanhthuthang.Click += button1_Click;
            // 
            // btnkhachthuenhieunhat
            // 
            btnkhachthuenhieunhat.Location = new Point(6, 504);
            btnkhachthuenhieunhat.Margin = new Padding(3, 4, 3, 4);
            btnkhachthuenhieunhat.Name = "btnkhachthuenhieunhat";
            btnkhachthuenhieunhat.Size = new Size(239, 71);
            btnkhachthuenhieunhat.TabIndex = 9;
            btnkhachthuenhieunhat.Text = "Khách hàng thuê xe nhiều nhất";
            btnkhachthuenhieunhat.UseVisualStyleBackColor = true;
            btnkhachthuenhieunhat.Click += button2_Click;
            // 
            // btnxethuenhieunhat
            // 
            btnxethuenhieunhat.Location = new Point(6, 583);
            btnxethuenhieunhat.Margin = new Padding(3, 4, 3, 4);
            btnxethuenhieunhat.Name = "btnxethuenhieunhat";
            btnxethuenhieunhat.Size = new Size(239, 71);
            btnxethuenhieunhat.TabIndex = 10;
            btnxethuenhieunhat.Text = "Xe được thuê nhiều nhất";
            btnxethuenhieunhat.UseVisualStyleBackColor = true;
            btnxethuenhieunhat.Click += button3_Click;
            // 
            // btnxedangsua
            // 
            btnxedangsua.Location = new Point(6, 661);
            btnxedangsua.Margin = new Padding(3, 4, 3, 4);
            btnxedangsua.Name = "btnxedangsua";
            btnxedangsua.Size = new Size(239, 71);
            btnxedangsua.TabIndex = 11;
            btnxedangsua.Text = "Danh sách xe đang sửa";
            btnxedangsua.UseVisualStyleBackColor = true;
            btnxedangsua.Click += button4_Click;
            // 
            // btnslxedachothue
            // 
            btnslxedachothue.Location = new Point(6, 281);
            btnslxedachothue.Margin = new Padding(3, 4, 3, 4);
            btnslxedachothue.Name = "btnslxedachothue";
            btnslxedachothue.Size = new Size(239, 71);
            btnslxedachothue.TabIndex = 12;
            btnslxedachothue.Text = "Số lượng xe đã cho thuê";
            btnslxedachothue.UseVisualStyleBackColor = true;
            btnslxedachothue.Click += button5_Click;
            // 
            // dtpTo
            // 
            dtpTo.CustomFormat = "dd/MM/yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Location = new Point(78, 243);
            dtpTo.Margin = new Padding(3, 4, 3, 4);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(166, 27);
            dtpTo.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 249);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 7;
            label8.Text = "Đến ngày";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 212);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 5;
            label7.Text = "Từ ngày";
            // 
            // dtpFrom
            // 
            dtpFrom.CustomFormat = "dd/MM/yyyy";
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Location = new Point(78, 204);
            dtpFrom.Margin = new Padding(3, 4, 3, 4);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(166, 27);
            dtpFrom.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 380);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 14;
            label9.Text = "Năm";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(78, 372);
            dateTimePicker3.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(166, 27);
            dateTimePicker3.TabIndex = 15;
            // 
            // listView1
            // 
            listView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listView1.Location = new Point(262, 204);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.RowHeadersWidth = 51;
            listView1.Size = new Size(735, 528);
            listView1.TabIndex = 16;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 748);
            Controls.Add(listView1);
            Controls.Add(dateTimePicker3);
            Controls.Add(label9);
            Controls.Add(btnslxedachothue);
            Controls.Add(btnxedangsua);
            Controls.Add(btnxethuenhieunhat);
            Controls.Add(btnkhachthuenhieunhat);
            Controls.Add(btndoanhthuthang);
            Controls.Add(label8);
            Controls.Add(dtpTo);
            Controls.Add(label7);
            Controls.Add(dtpFrom);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormThongKe";
            FormClosed += FormThongKe_FormClosed;
            Load += FormThongKe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label txtSoLuongXe;
        private Panel panel2;
        private Label txtSoLuongKH;
        private Label label4;
        private Panel panel3;
        private Label txtTongDoanhThu;
        private Label label6;
        private Button btndoanhthuthang;
        private Button btnkhachthuenhieunhat;
        private Button btnxethuenhieunhat;
        private Button btnxedangsua;
        private Button btnslxedachothue;
        private DateTimePicker dtpTo;
        private Label label8;
        private Label label7;
        private DateTimePicker dtpFrom;
        private Label label9;
        private DateTimePicker dateTimePicker3;
        private DataGridView listView1;
    }
}