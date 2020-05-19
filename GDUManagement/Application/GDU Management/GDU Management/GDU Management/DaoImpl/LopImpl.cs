using GDU_Management.IDao;
using GDU_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GDU_Management.DaoImpl
{
    class LopImpl : IDaoLop
    {
        //tạo kết nối database 
        GDUDataConnectionsDataContext db = new GDUDataConnectionsDataContext();
        List<Lop> lop;
        public Lop CreateLop(Lop lop)
        {
            //code content
            return null;
        }

        public void DeleteLop(string maLop)
        {
           //code content
        }

        public List<Lop> getAllLop()
        {
            //code content
            return null;
        }

        public void UpdateLop(Lop lop)
        {
            //code content
        }
    }
}
