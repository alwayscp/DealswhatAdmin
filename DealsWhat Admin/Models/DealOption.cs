//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DealsWhat_Admin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DealOption
    {
        public DealOption()
        {
            this.DealAttributes = new HashSet<DealAttribute>();
        }
    
        public System.Guid Id { get; set; }
        public string ShortTitle { get; set; }
        public double RegularPrice { get; set; }
        public double SpecialPrice { get; set; }
        public Nullable<System.Guid> Deal_Id { get; set; }
    
        public virtual ICollection<DealAttribute> DealAttributes { get; set; }
        public virtual Deal Deal { get; set; }
    }
}