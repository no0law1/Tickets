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
    
    public partial class action
    {
        public System.DateTime created_at { get; set; }
        public Nullable<System.DateTime> ended_at { get; set; }
        public string note { get; set; }
        public int ticket_id { get; set; }
        public Nullable<int> admin_id { get; set; }
        public int step_order { get; set; }
        public int id_type { get; set; }
    
        public virtual step step { get; set; }
        public virtual administrator administrator { get; set; }
        public virtual ticket ticket { get; set; }
    }
}