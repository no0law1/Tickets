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
    
    public partial class ticket
    {
        public ticket()
        {
            this.history = new HashSet<history>();
            this.request = new HashSet<request>();
            this.action = new HashSet<action>();
        }
    
        public int code { get; set; }
        public string STATE { get; set; }
        public string description { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<System.DateTime> closed_at { get; set; }
        public string priority { get; set; }
        public Nullable<System.DateTime> deleted_at { get; set; }
        public int admin_id { get; set; }
        public int client_id { get; set; }
        public Nullable<int> id_type { get; set; }
    
        public virtual administrator administrator { get; set; }
        public virtual client client { get; set; }
        public virtual ICollection<history> history { get; set; }
        public virtual ICollection<request> request { get; set; }
        public virtual type type { get; set; }
        public virtual ICollection<action> action { get; set; }
    }
}
