namespace ThueXe
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            btnKhoXe = new Button();
            btnKhachHang = new Button();
            btnHopDong = new Button();
            btnThongKe = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnKhoXe
            // 
            btnKhoXe.BackColor = Color.Orange;
            btnKhoXe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKhoXe.Location = new Point(12, 169);
            btnKhoXe.Margin = new Padding(3, 4, 3, 4);
            btnKhoXe.Name = "btnKhoXe";
            btnKhoXe.Size = new Size(213, 100);
            btnKhoXe.TabIndex = 0;
            btnKhoXe.Text = "KHO XE";
            btnKhoXe.UseVisualStyleBackColor = false;
            btnKhoXe.Click += btnKhoXe_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.Orange;
            btnKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKhachHang.Location = new Point(247, 169);
            btnKhachHang.Margin = new Padding(3, 4, 3, 4);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(213, 100);
            btnKhachHang.TabIndex = 1;
            btnKhachHang.Text = "KHÁCH HÀNG";
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnHopDong
            // 
            btnHopDong.BackColor = Color.Orange;
            btnHopDong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHopDong.Location = new Point(486, 169);
            btnHopDong.Margin = new Padding(3, 4, 3, 4);
            btnHopDong.Name = "btnHopDong";
            btnHopDong.Size = new Size(213, 100);
            btnHopDong.TabIndex = 2;
            btnHopDong.Text = "HỢP ĐỒNG";
            btnHopDong.UseVisualStyleBackColor = false;
            btnHopDong.Click += btnHopDong_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.Orange;
            btnThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongKe.Location = new Point(731, 169);
            btnThongKe.Margin = new Padding(3, 4, 3, 4);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(213, 100);
            btnThongKe.TabIndex = 3;
            btnThongKe.Text = "THỐNG KÊ";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(310, 46);
            label1.Name = "label1";
            label1.Size = new Size(340, 60);
            label1.TabIndex = 4;
            label1.Text = "Quản Lý Chung";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(956, 303);
            Controls.Add(label1);
            Controls.Add(btnThongKe);
            Controls.Add(btnHopDong);
            Controls.Add(btnKhachHang);
            Controls.Add(btnKhoXe);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thuê xe";
            FormClosed += FormMain_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKhoXe;
        private Button btnKhachHang;
        private Button btnHopDong;
        private Button btnThongKe;
        private Label label1;
    }
}
