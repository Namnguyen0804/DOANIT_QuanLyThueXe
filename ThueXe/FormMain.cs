namespace ThueXe
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnKhoXe_Click(object sender, EventArgs e)
        {
            FormXe formXe = new FormXe();
            formXe.ShowDialog();
            this.Hide();
        }

      

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            FormKhachHang formKhachHang = new FormKhachHang();
            formKhachHang.ShowDialog();
            this.Hide();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            FormHopDong formHopDong = new FormHopDong();
            formHopDong.ShowDialog();
            this.Hide();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FormThongKe formThongKe = new FormThongKe();
            formThongKe.ShowDialog();
            this.Hide();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
