
using GDU_Management.Model;
using GDU_Management.Service;
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
            LoadDanhSachSinhVienToDatagridview();
            LoadDanhSachKhoaToDatagridview();
        }


        //Khai bao cac service 
        SinhVienService sinhVienService = new SinhVienService();
        KhoaService khoaService = new KhoaService();
        KhoaHocService khoaHocService = new KhoaHocService();

        //DS HÀM PUBLIC
        public void NgayGio()
        {
            //get ngày
            DateTime ngay = DateTime.Now;
            lblDay.Text = ngay.ToString("dd/MM/yyyy");
            lblDay2.Text = ngay.ToString("dd/MM/yyyy");

            //get thời gian
            timerTime_QLSV.Start();
        }

        //hàm trở lại menu chính
        void goToGDUmanagement()
        {
            this.Hide();
            GDUManagement gdu = new GDUManagement();
            gdu.ShowDialog();
        }

        //load danh sach sinh viên lên datagridview
        public void LoadDanhSachSinhVienToDatagridview()
        {
            dgvDSSV.DataSource = sinhVienService.GetAllSinhVien();
        }

        //laod danh sach khoa lên datagridview
        public void LoadDanhSachKhoaToDatagridview()
        {
            dgvDanhSachKhoa.DataSource = khoaService.GetAllKhoa();
        }

        //hàm show dữ liệu dgvKhoa lên textbox
        public void ShowDataKhoaToTextBox()
        {
            txtMaKhoa.DataBindings.Clear();
            txtMaKhoa.DataBindings.Add("text", dgvDanhSachKhoa.DataSource, "MaKhoa");
            txtTenKhoa.DataBindings.Clear();
            txtTenKhoa.DataBindings.Add("text", dgvDanhSachKhoa.DataSource, "TenKhoa");
        }

        public bool checkDataKHOA()
        {
            if (string.IsNullOrEmpty(txtTenKhoa.Text))
            {
                MessageBox.Show("Tên Khoa Không được bỏ trống, vui lòng kiểm tra lại...");
                txtTenKhoa.Focus();
                return false;
            }
            return true;
        }
        //KẾT THÚC DS HÀM PUBLIC



        private void timerTime_QLSV_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblTime2.Text = DateTime.Now.ToLongTimeString();

            int giay_qlk = Convert.ToInt32(lblGiay_QLK.Text);
            int phut_qlk = Convert.ToInt32(lblPhut_QLK.Text);

            int giay_qlkh = Convert.ToInt32(lblGiay_QLKH.Text);
            int phut_qlkh = Convert.ToInt32(lblPhut_QLKH.Text);
            giay_qlk++;
            giay_qlkh++;
            if (giay_qlk > 59 & giay_qlkh > 59)
            {
                giay_qlk = 0;
                phut_qlk++;

                giay_qlkh = 0;
                phut_qlkh++;
            }

            if (giay_qlk < 10  & giay_qlkh <10)
            {
                lblGiay_QLK.Text = "0" + giay_qlk;
                lblGiay_QLKH.Text = "0" + giay_qlkh;
            }
            else
            {
                lblGiay_QLK.Text = "" + giay_qlk;
                lblGiay_QLKH.Text = "" + giay_qlkh;
            }
            if (phut_qlk < 10 & phut_qlkh < 10)
            {
                lblPhut_QLK.Text = "0" + phut_qlk;
                lblPhut_QLKH.Text = "0" + phut_qlkh;
            }
            else
            {
                lblPhut_QLK.Text = "" + phut_qlk;
                lblPhut_QLKH.Text = "" + phut_qlkh;
            }
            if (giay_qlk % 2 == 0  & giay_qlkh % 2 == 0)
            {
                lblAnimation1_QKL.Text = "(^_^)";
                lblAnimation2_QLK.Text = "(+_+)";
                lblAnimation3_QLK.Text = "(-_^)";

                lblAnimation1_QLKH.Text = "(^_^)";
                lblAnimation2_QLKH.Text = "(+_+)";
                lblAnimation3_QLKH.Text = "(-_^)";
            }
            else if (giay_qlk % 2 != 0 & giay_qlkh % 2 != 0)
            {
                lblAnimation2_QLK.Text = "(^_^)";
                lblAnimation1_QKL.Text = "(+_+)";
                lblAnimation3_QLK.Text = "(^_-)";

                lblAnimation2_QLKH.Text = "(^_^)";
                lblAnimation2_QLKH.Text = "(+_+)";
                lblAnimation3_QLKH.Text = "(^_-)";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

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

        private void btnHome_QLK_Click(object sender, EventArgs e)
        {
            goToGDUmanagement();
        }

        private void btnHome_QLKH_Click(object sender, EventArgs e)
        {
            goToGDUmanagement();
        }

        private void btnExit_QLK_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnExit_QLKH_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHome_SV_Click(object sender, EventArgs e)
        {
            goToGDUmanagement();
        }

        private void dgvDanhSachKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdateKhoa.Enabled = true;
            btnDeleteKhoa.Enabled = true;
            ShowDataKhoaToTextBox();
        }

        private void btnSaveKhoa_Click(object sender, EventArgs e)
        {
            if (checkDataKHOA())
            {
                Khoa khoa = new Khoa();
                khoa.MaKhoa = txtMaKhoa.Text.Trim();
                khoa.TenKhoa = txtTenKhoa.Text.Trim();

                khoaService.CreateKhoa(khoa);
                LoadDanhSachKhoaToDatagridview();
                MessageBox.Show("Thêm Thành Công...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSaveKhoa.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lỗi, Thêm Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewKhoa_Click(object sender, EventArgs e)
        {
            btnSaveKhoa.Enabled = true;
            btnUpdateKhoa.Enabled = false;
            btnDeleteKhoa.Enabled = false;
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
        }

        private void btnUpdateKhoa_Click(object sender, EventArgs e)
        {
            Khoa kh = new Khoa();
            kh.TenKhoa = txtTenKhoa.Text.Trim();
            khoaService.UpdateKhoa(kh);
            MessageBox.Show("Update Thành Công", "Thông Báo", MessageBoxButtons.OK);
            LoadDanhSachKhoaToDatagridview();
        }

        private void btnDeleteKhoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ban co muon xoa khong", "canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string maKhoa;
                maKhoa = txtMaKhoa.Text.Trim();
                if (string.IsNullOrEmpty(txtMaKhoa.Text))
                {
                    MessageBox.Show("xoa that bai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    khoaService.DeleteKhoa(maKhoa);
                    MessageBox.Show("da xoa", "thong bao", MessageBoxButtons.OK);
                    txtMaKhoa.Text = "";
                    txtTenKhoa.Text = "";

                    btnNewKhoa.Enabled = true;
                    LoadDanhSachKhoaToDatagridview();
                }
            }
        }
    }
}
