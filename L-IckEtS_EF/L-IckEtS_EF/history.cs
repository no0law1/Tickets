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
    
    public partial class history
    {
        public int id { get; set; }
        public System.DateTime created_at { get; set; }
        public string sql_command { get; set; }
        public string db_user { get; set; }
        public int ticket_id { get; set; }
    
        public virtual ticket ticket { get; set; }
    }
}