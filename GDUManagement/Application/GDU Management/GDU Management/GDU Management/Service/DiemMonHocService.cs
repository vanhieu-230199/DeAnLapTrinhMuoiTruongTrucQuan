﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDU_Management.DaoImpl;
using GDU_Management.IDao;
using GDU_Management.Model;

namespace GDU_Management.Service
{
    class DiemMonHocService
    {
        IDaoDiemMonHoc diemMonHocIDao = new DiemMonHocImpl();

        //lấy tất cả điểm môn học
        public List<DiemMonHoc> GetAllDiemMonHoc()
        {
            return diemMonHocIDao.GetAllDiemMonHoc();
        }

        //thêm mới một  điểm môn học
        public DiemMonHoc AddDiemMonHoc(DiemMonHoc diemMonHoc)
        {
            return diemMonHocIDao.AddDiemMonHoc(diemMonHoc);
        }

        //xóa điểm môn học
        public void DeleteDiemMonHoc(string maSV, string maDiemMonHoc)
        {
            diemMonHocIDao.DeleteDiemMonHoc(maSV,maDiemMonHoc);
        }


        //cập nhật điểm môn học
        public void UpdateDiemMonHoc(DiemMonHoc diemMonHoc)
        {
            diemMonHocIDao.UpdateDiemMonHoc(diemMonHoc);
        }
    }
}
