using GDU_Management.IDao;
using GDU_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GDU_Management.DaoImpl
{
    class NganhHocImpl : IDaoNganhHoc
    {
        //tao ket noi database
        GDUDataConnectionsDataContext db = new GDUDataConnectionsDataContext();
        List<NganhHoc> nganhHoc;

        public NganhHoc CreateNganhHoc(NganhHoc nganhHoc)
        {
            //code content
            return null;
        }

        public void DeleteNganhHoc(string maNganhHoc)
        {
            //code content    return null;
        }

        public List<NganhHoc> GetAllNganhhoc()
        {
            //code content
            return null;
        }

        public void UpdateNganhHoc(NganhHoc nganhHoc)
        {
            //code content
        }
    }
}
