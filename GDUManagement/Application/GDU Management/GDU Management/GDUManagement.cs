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
    public partial class GDUManagement : Form
    {
        public GDUManagement()
        {
            InitializeComponent();
            NgayGio();
        }

        
        public void NgayGio()
        {
            //get day
            DateTime ngay =  DateTime.Now;
            lblDay.Text = ngay.ToString("dd/MM/yyyy");

            // text hello admin
            lblTitle.Text = "Hello Admin...!!! ^...^";
            timerHelloAdmin.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GDUManagement_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private int khoangCach = 5;
        private void timerHelloAdmin_Tick(object sender, EventArgs e)
        {
            lblTitle.Location = new Point(lblTitle.Location.X+khoangCach , lblTitle.Location.Y);
            if(lblTitle.Location.X > 477 || lblTitle.Location.X <= 0)
            {
                  lblTitle.Location = new Point(lblTitle.Location.X - 477 , lblTitle.Location.Y);
                
            }
        }

      

        private void btnThoatChuongTrinh_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn Đăng Xuất khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // Application.Exit();
                this.Hide();
                frmLogin frmlogin = new frmLogin();
                frmlogin.ShowDialog();
            }        }
    }
}
