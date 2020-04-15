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
            helloAdmin();
        }

        //DANH SÁCH HÀM
        
            //hàm lấy ngày giờ
        public void NgayGio()
        {
            //get day
            DateTime ngay =  DateTime.Now;
            lblDay.Text = ngay.ToString("dd/MM/yyyy");

            //get thời gian
            timerTime.Start();
        }

        //hàm hello admin
        public void helloAdmin()
        {
            lblTitle.Text = "Hello Admin...!!! ^...^";
            timerHelloAdmin.Enabled = true;
        }

        //hàm vào form QLSV
        public void goToQLSV()
        {
            this.Hide();
            frmQuanLySinhVien frmQlsv = new frmQuanLySinhVien();
            frmQlsv.ShowDialog();
        }

        // KẾT THÚC DS HÀM
  

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
            }       
        }

        private void pnQuanLySinhVien_MouseClick(object sender, MouseEventArgs e)
        {
            goToQLSV();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            goToQLSV();
        }

        private void lblQLSV_Click_1(object sender, EventArgs e)
        {
            goToQLSV();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

    }
}
