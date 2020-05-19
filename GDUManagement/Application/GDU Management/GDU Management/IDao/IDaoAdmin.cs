using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.Model;

namespace GDU_Management.IDao
{
    interface IDaoAdmin
    {
        List<Admin> GetAllAdmin();
        Admin CreateAdmin(Admin ad);
        void DeleteAdmin(string maAD );
        void UpdateAdmin(Admin ad);
    }
}
