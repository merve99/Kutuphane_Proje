//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kutuphane.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class cezalar
    {
        public int id { get; set; }
        public Nullable<System.DateTime> baslangic { get; set; }
        public Nullable<System.DateTime> bitis { get; set; }
        public Nullable<decimal> para { get; set; }
        public Nullable<int> uyeid { get; set; }
        public Nullable<int> hareketid { get; set; }
    
        public virtual hareket hareket { get; set; }
        public virtual uyeler uyeler { get; set; }
    }
}
