using GDU_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDU_Management.IDao
{
    interface IDaoKhoaHoc
    {
        List<KhoaHoc> GetAllKhoaHoc();
        KhoaHoc CreateKhoaHoc(KhoaHoc khoaHoc);
        void DeleteKhoaHoc(string maKhoaHoc);
        void UpdateKhoaHoc(KhoaHoc khoaHoc);
    }
}
