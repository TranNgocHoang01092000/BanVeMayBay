//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightTicket.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HangVeCuaChuyenBay
    {
        public int MaCB { get; set; }
        public int MaHangVe { get; set; }
        public Nullable<int> Soluongghe { get; set; }
    
        public virtual ChuyenBay ChuyenBay { get; set; }
        public virtual HangVe HangVe { get; set; }
    }
}
