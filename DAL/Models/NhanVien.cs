//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        public int IDNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> NgayBatDauLam { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }
        public bool IsReceipt { get; set; }
    }
}
