using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDU_Management
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public void checkLogin()
        {
            if (string.IsNullOrEmpty(txtPassword.Text)  || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Vui Lòng điền đầy đủ thông tinUssername và pasword", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            else
            {
                btnLogin.Enabled = true;
            }
        }

     
        private void lblReset_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            //btnLogin.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            GDUManagement gduManagement = new GDUManagement();
            gduManagement.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }          
        }
    }
}
