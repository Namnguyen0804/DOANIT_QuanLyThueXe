using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThueXe
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txttaikhoan.Text=="nhom20"&&txtmatkhau.Text=="123123")
            {
                FormMain formMain = new FormMain();
                this.Hide();
                formMain.ShowDialog();
            }
            
        }
    }
}
