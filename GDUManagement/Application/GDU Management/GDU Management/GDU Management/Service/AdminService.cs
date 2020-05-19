using GDU_Management.DaoImpl;
using GDU_Management.IDao;
using GDU_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDU_Management.Service
{
    class AdminService
    {
        IDaoAdmin adminIDao = new AdminImpl();

        //lấy tất cả admin
        public List<Admin> GetAllAdmin()
        {
            return adminIDao.GetAllAdmin();
        }

        //thêm mới một admin
        public Admin CreateAdmin(Admin ad)
        {
            return adminIDao.CreateAdmin(ad);
        }

        //xóa admin
        public void DeleteAdmin(string maAD)
        {
            adminIDao.DeleteAdmin(maAD);
        }

        //cập nhật admin
        public void UpdateAdmin(Admin ad)
        {
            adminIDao.UpdateAdmin(ad);
        }
    }
}
