using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        public List<NhanVien> getDsNhanVien()
        {
            List<NhanVien> listNV = new List<NhanVien>();
            using (var db = new RapChieuPhimEntities())
            {
                var tb = from nv in db.NhanViens
                         select nv;
                foreach (var item in tb)
                {
                    NhanVien temp = new NhanVien();
                    temp.IDNhanVien = item.IDNhanVien;
                    temp.TenNhanVien = item.TenNhanVien;
                    temp.NgaySinh = item.NgaySinh;
                    temp.SDT = item.SDT;
                    temp.DiaChi = item.DiaChi;
                    temp.Email = item.Email;
                    temp.UserName = item.UserName;
                    temp.PassWord = item.PassWord;
                    temp.IsAdmin = item.IsAdmin;
                    temp.IsActive = item.IsActive;
                    temp.IsDelete = item.IsDelete;
                    temp.IsReceipt = item.IsReceipt;
                    listNV.Add(temp);
                }
            }
            return listNV;
        }
    }
}
