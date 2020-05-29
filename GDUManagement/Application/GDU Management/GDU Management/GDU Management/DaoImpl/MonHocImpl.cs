using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.IDao;
using GDU_Management.Model;

namespace GDU_Management.DaoImpl
{
    class MonHocImpl: IDaoMonHoc
    {
        //tao ket noi database
        GDUDataConnectionsDataContext db = new GDUDataConnectionsDataContext();
        List<MonHoc> monHoc;

        public SinhVien CreateMonHoc(MonHoc monHoc)
        {
            //code content
            return null;
        }

        public void DeleteMonHoc(string maMonHoc)
        {
            //code content
        }

        public List<MonHoc> GetAllMonHoc()
        {
            var mh = from x in db.MonHocs select x;
            monHoc = mh.ToList();
            return monHoc;
        }

        public void UpdateMonHoc(MonHoc monHoc)
        {
           //code content
        }
    }
}
