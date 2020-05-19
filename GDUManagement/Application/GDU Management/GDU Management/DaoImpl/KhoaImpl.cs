using GDU_Management.IDao;
using GDU_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GDU_Management.DaoImpl
{
    class KhoaImpl : IDaoKhoa
    {
        //tạo kết nối database 
        GDUDataConnectionsDataContext db = new GDUDataConnectionsDataContext();
        List<Khoa> khoa;

        public Khoa CreateKhoa(Khoa khoa)
        {
            //code conntent
            return null;
        }

        public void DeleteKhoa(string MaKhoa)
        {
            //code conntent
        }

        public List<Khoa> GetAllKhoa()
        {
            var k = from x in db.Khoas select x;
            khoa = k.ToList();
            return khoa;
            Console.WriteLine("get all khoa");
        }

        public void UpdateKhoa(Khoa khoa)
        {
            //code conntent
        }
    }
}
