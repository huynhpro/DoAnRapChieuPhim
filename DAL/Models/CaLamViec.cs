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
    
    public partial class CaLamViec
    {
        public int IDCaLamViec { get; set; }
        public string TenCaLamViec { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.TimeSpan> GioBatdau { get; set; }
        public Nullable<System.TimeSpan> GioKetThuc { get; set; }
    }
}