//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace L_IckEtS_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class GetTicketsView
    {
        public int code { get; set; }
        public string state { get; set; }
        public string description { get; set; }
        public string priority { get; set; }
        public int admin_id { get; set; }
        public Nullable<int> id_type { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<System.DateTime> closed_at { get; set; }
        public Nullable<int> days { get; set; }
        public int priority_value { get; set; }
    }
}
