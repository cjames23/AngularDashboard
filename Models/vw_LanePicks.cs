//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_LanePicks
    {
        public long Id { get; set; }
        public string Lane { get; set; }
        public Nullable<System.DateTime> Orderdate { get; set; }
        public string Otype { get; set; }
        public Nullable<int> Orders { get; set; }
        public Nullable<double> Units { get; set; }
    }
}
