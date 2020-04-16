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
    public partial class frmQuanLySinhVien : Form
    {
        public frmQuanLySinhVien()
        {
            InitializeComponent();
            NgayGio();
        }

        public void NgayGio()
        {
            //get ngày
            DateTime ngay = DateTime.Now;
            lblDay.Text = ngay.ToString("dd/MM/yyyy");
            lblDay2.Text = ngay.ToString("dd/MM/yyyy");

            //get thời gian
            timerTime_QLSV.Start();
        }

        private void btnTroaiMenuChinhKhoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            GDUManagement gdu = new GDUManagement();
            gdu.ShowDialog();
        }

        private void btnTroLaiMenuChinhNganh_Click(object sender, EventArgs e)
        {
            this.Hide();
            GDUManagement gdu = new GDUManagement();
            gdu.ShowDialog();
        }

        private void btnDSNganh_Click(object sender, EventArgs e)
        {
            frmDanhSachNganh frmDSNganh = new frmDanhSachNganh();
            frmDSNganh.ShowDialog();
        }

        private void btnXemDanhSachLop_Click(object sender, EventArgs e)
        {
            frmDanhSachLop frmDSLop = new frmDanhSachLop();
            frmDSLop.ShowDialog();
        }

        private void timerTime_QLSV_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblTime2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
