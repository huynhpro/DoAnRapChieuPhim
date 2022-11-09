using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        public List<NhanVien> getDSNhanVien()
        {
            List<NhanVien> listnv = new List<NhanVien>();
            NhanVienDAL login = new NhanVienDAL();
            listnv = login.getDsNhanVien();
            return listnv;
        }
        public bool checkDs()
        {
            if (getDSNhanVien().Count > 0)
            {
                return true;
            }
            return false;
        }
        public string getUser(string ten)
        {
            List<NhanVien> listnv = new List<NhanVien>();
            NhanVienDAL login = new NhanVienDAL();
            listnv = login.getDsNhanVien();
            foreach (var item in listnv)
            {
                if (ten == item.TenNhanVien && item.UserName != null)
                {
                    return item.UserName;
                }
            }
            return "Không có username";
        }
        public bool checkLogin(string username, string password)
        {
            List<NhanVien> listnv = new List<NhanVien>();
            NhanVienDAL login = new NhanVienDAL();
            listnv = login.getDsNhanVien();
            foreach (var item in listnv)
            {
                if (item.UserName == username && item.PassWord == password && item.IsDelete == false && item.IsActive == true)
                {
                    return true;
                }

            }
            return false;
        }
        public bool checkLoginAdmin(string username, string password)
        {
            List<NhanVien> listnv = new List<NhanVien>();
            NhanVienDAL login = new NhanVienDAL();
            listnv = login.getDsNhanVien();
            foreach (var item in listnv)
            {
                if (item.UserName == username && item.PassWord == password && item.IsDelete == false && item.IsActive == true && item.IsAdmin == true)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
