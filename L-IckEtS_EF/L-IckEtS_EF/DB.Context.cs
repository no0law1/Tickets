﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ticket_systemEntities : DbContext
    {
        public ticket_systemEntities()
            : base("name=ticket_systemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<administrator> administrator { get; set; }
        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<history> history { get; set; }
        public virtual DbSet<request> request { get; set; }
        public virtual DbSet<step> step { get; set; }
        public virtual DbSet<ticket> ticket { get; set; }
        public virtual DbSet<type> type { get; set; }
        public virtual DbSet<ticket> GetTicketsView { get; set; }
        public virtual DbSet<action> action { get; set; }
    
        public virtual int CloseAction(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CloseAction", idParameter);
        }
    
        public virtual int CloseTicket(Nullable<int> code)
        {
            var codeParameter = code.HasValue ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CloseTicket", codeParameter);
        }
    
        public virtual int CreateAction(string note, Nullable<int> ticket_id, Nullable<int> admin_id, Nullable<int> step_order, Nullable<int> id_type)
        {
            var noteParameter = note != null ?
                new ObjectParameter("note", note) :
                new ObjectParameter("note", typeof(string));
    
            var ticket_idParameter = ticket_id.HasValue ?
                new ObjectParameter("ticket_id", ticket_id) :
                new ObjectParameter("ticket_id", typeof(int));
    
            var admin_idParameter = admin_id.HasValue ?
                new ObjectParameter("admin_id", admin_id) :
                new ObjectParameter("admin_id", typeof(int));
    
            var step_orderParameter = step_order.HasValue ?
                new ObjectParameter("step_order", step_order) :
                new ObjectParameter("step_order", typeof(int));
    
            var id_typeParameter = id_type.HasValue ?
                new ObjectParameter("id_type", id_type) :
                new ObjectParameter("id_type", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateAction", noteParameter, ticket_idParameter, admin_idParameter, step_orderParameter, id_typeParameter);
        }
    
        public virtual int CreateAdmin(string name, string email, ObjectParameter res)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateAdmin", nameParameter, emailParameter, res);
        }
    
        public virtual int CreateClient(string name, string email)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateClient", nameParameter, emailParameter);
        }
    
        public virtual int CreateRequest(Nullable<int> ticket_id, Nullable<int> client_id)
        {
            var ticket_idParameter = ticket_id.HasValue ?
                new ObjectParameter("ticket_id", ticket_id) :
                new ObjectParameter("ticket_id", typeof(int));
    
            var client_idParameter = client_id.HasValue ?
                new ObjectParameter("client_id", client_id) :
                new ObjectParameter("client_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateRequest", ticket_idParameter, client_idParameter);
        }
    
        public virtual int CreateStep(Nullable<int> id_type, string description)
        {
            var id_typeParameter = id_type.HasValue ?
                new ObjectParameter("id_type", id_type) :
                new ObjectParameter("id_type", typeof(int));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateStep", id_typeParameter, descriptionParameter);
        }
    
        public virtual int CreateTicket(Nullable<int> client_id, string description)
        {
            var client_idParameter = client_id.HasValue ?
                new ObjectParameter("client_id", client_id) :
                new ObjectParameter("client_id", typeof(int));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateTicket", client_idParameter, descriptionParameter);
        }
    
        public virtual int CreateType(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateType", nameParameter);
        }
    
        public virtual int DeleteAdmin(Nullable<int> id, ObjectParameter res)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteAdmin", idParameter, res);
        }
    
        public virtual int DeleteClient(Nullable<int> id, string name, string email)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteClient", idParameter, nameParameter, emailParameter);
        }
    
        public virtual int DeleteStep(Nullable<int> num_order, Nullable<int> id_type)
        {
            var num_orderParameter = num_order.HasValue ?
                new ObjectParameter("num_order", num_order) :
                new ObjectParameter("num_order", typeof(int));
    
            var id_typeParameter = id_type.HasValue ?
                new ObjectParameter("id_type", id_type) :
                new ObjectParameter("id_type", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteStep", num_orderParameter, id_typeParameter);
        }
    
        public virtual int DeleteTicket(Nullable<int> code)
        {
            var codeParameter = code.HasValue ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteTicket", codeParameter);
        }
    
        public virtual int DeleteType(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteType", idParameter);
        }
    
        public virtual ObjectResult<GetPriorityTickets_Result> GetPriorityTickets(Nullable<int> rows)
        {
            var rowsParameter = rows.HasValue ?
                new ObjectParameter("rows", rows) :
                new ObjectParameter("rows", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPriorityTickets_Result>("GetPriorityTickets", rowsParameter);
        }
    
        public virtual int GetRandomAdmin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetRandomAdmin");
        }
    
        public virtual int RemoveTicket(Nullable<int> code, ObjectParameter res)
        {
            var codeParameter = code.HasValue ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RemoveTicket", codeParameter, res);
        }
    
        public virtual int RespondRequest(Nullable<int> ticket_id, Nullable<int> client_id, Nullable<int> id, Nullable<int> admin_id, string response)
        {
            var ticket_idParameter = ticket_id.HasValue ?
                new ObjectParameter("ticket_id", ticket_id) :
                new ObjectParameter("ticket_id", typeof(int));
    
            var client_idParameter = client_id.HasValue ?
                new ObjectParameter("client_id", client_id) :
                new ObjectParameter("client_id", typeof(int));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var admin_idParameter = admin_id.HasValue ?
                new ObjectParameter("admin_id", admin_id) :
                new ObjectParameter("admin_id", typeof(int));
    
            var responseParameter = response != null ?
                new ObjectParameter("response", response) :
                new ObjectParameter("response", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RespondRequest", ticket_idParameter, client_idParameter, idParameter, admin_idParameter, responseParameter);
        }
    
        public virtual int SetClientEMail(Nullable<int> id, string email)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SetClientEMail", idParameter, emailParameter);
        }
    
        public virtual int SetClientName(Nullable<int> id, string name)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SetClientName", idParameter, nameParameter);
        }
    
        public virtual int SetTicketPriority(Nullable<int> code, string priority)
        {
            var codeParameter = code.HasValue ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(int));
    
            var priorityParameter = priority != null ?
                new ObjectParameter("priority", priority) :
                new ObjectParameter("priority", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SetTicketPriority", codeParameter, priorityParameter);
        }
    
        public virtual int SetTicketState(Nullable<int> code, string state)
        {
            var codeParameter = code.HasValue ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(int));
    
            var stateParameter = state != null ?
                new ObjectParameter("state", state) :
                new ObjectParameter("state", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SetTicketState", codeParameter, stateParameter);
        }
    
        public virtual int SetTicketType(Nullable<int> code, Nullable<int> id_type)
        {
            var codeParameter = code.HasValue ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(int));
    
            var id_typeParameter = id_type.HasValue ?
                new ObjectParameter("id_type", id_type) :
                new ObjectParameter("id_type", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SetTicketType", codeParameter, id_typeParameter);
        }
    
        public virtual ObjectResult<ShowTicketInfo_Result> ShowTicketInfo(Nullable<int> code)
        {
            var codeParameter = code.HasValue ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ShowTicketInfo_Result>("ShowTicketInfo", codeParameter);
        }
    
        public virtual int UpdateAdmin(Nullable<int> id, string name, ObjectParameter res)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateAdmin", idParameter, nameParameter, res);
        }
    
        public virtual int UpdateClient(Nullable<int> id, string name, string email)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateClient", idParameter, nameParameter, emailParameter);
        }
    
        public virtual int UpdateTicket(Nullable<int> code, string state, Nullable<System.DateTime> closed_at, string priority, Nullable<int> id_type)
        {
            var codeParameter = code.HasValue ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(int));
    
            var stateParameter = state != null ?
                new ObjectParameter("state", state) :
                new ObjectParameter("state", typeof(string));
    
            var closed_atParameter = closed_at.HasValue ?
                new ObjectParameter("closed_at", closed_at) :
                new ObjectParameter("closed_at", typeof(System.DateTime));
    
            var priorityParameter = priority != null ?
                new ObjectParameter("priority", priority) :
                new ObjectParameter("priority", typeof(string));
    
            var id_typeParameter = id_type.HasValue ?
                new ObjectParameter("id_type", id_type) :
                new ObjectParameter("id_type", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateTicket", codeParameter, stateParameter, closed_atParameter, priorityParameter, id_typeParameter);
        }
    
        public virtual int UpdateTicketPriority(Nullable<int> code)
        {
            var codeParameter = code.HasValue ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateTicketPriority", codeParameter);
        }
    }
}
