using L_IckEtS.data.entity;
using L_IckEtS.model;
using L_IckEtS_EF.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace L_IckEtS_EF
{
    public partial class TicketDetails : Form
    {
        public delegate void RemovedEventHandler(object sender, EventArgs e);

        public event RemovedEventHandler Changed;

        protected virtual void OnTicketChanged(EventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }

        private Ticket ticket;

        private L_IckEtS.model.Type ticketType;

        private Admin admin;

        private IEnumerable<Request> requests;

        private IEnumerable<L_IckEtS.model.Action> actions;

        public TicketDetails(Ticket ticket, L_IckEtS.model.Type type,
                                Admin admin, IEnumerable<Request> requests,
                                IEnumerable<L_IckEtS.model.Action> actions)
        {
            InitializeComponent();
            this.ticket = ticket;
            this.ticketType = type;
            this.admin = admin;
            this.requests = requests;
            this.actions = actions;
            UpdateUI();
        }
        private void UpdateUI()
        {
            // DETAILS
            this.Text = "Ticket " + ticket.code;
            state.Text = ticket.STATE;
            priority.Text = ticket.priority;
            type.Text = ticketType == null ? "" : ticketType.name;
            description.Text = ticket.description;
            created.Text = ticket.created_at.ToShortDateString();
            closed.Text = ticket.closed_at.HasValue ? ticket.closed_at.GetValueOrDefault().ToShortDateString() : "";

            // REQUESTS
            foreach (Request req in requests)
            {
                string response_date = req.response_date.HasValue ? req.response_date.Value.ToShortDateString() : "";
                string[] row = { req.id.ToString(), req.created_at.ToShortDateString(), response_date, req.admin_id.ToString() };
                var listViewItem = new ListViewItem(row);
                info_requests.Items.Add(listViewItem);
            }

            // ACTIONS
            action_type.Text = ticketType == null ? "" : ticketType.name;
            foreach (L_IckEtS.model.Action action in actions)
            {
                string[] row = { action.note, action.admin_id.ToString(), action.step_order.ToString(), action.ended_at == null ? "" : true.ToString() };
                var listViewItem = new ListViewItem(row);
                actions_list.Items.Add(listViewItem);
            }

            // RESOLVE
            if (!ticket.STATE.Equals("In Progress"))
            {
                this.tabControl1.TabPages.Remove(ticket_resolve);
            }
            else
            {
                state_list.SetSelected(0, true);
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            //client c = null;
            //administrator admin = null;
            //IEnumerable<action> actions = null;
            //using (ticket_systemEntities db = new ticket_systemEntities())
            //{
            //    c = new TicketSystemDBQueryable().getClientById(db, t.client_id);
            //    admin = new TicketSystemDBQueryable().getAdminById(db, t.admin_id);
            //    if (t.id_type != null)
            //        tp = new TicketSystemDBQueryable().getTypeById(db, t.id_type);
            //    actions = new TicketSystemDBQueryable().getActionsByTicketId(db, t.code);

            //    XElement ticket_xml = XMLUtils.ticketToXml(t);
            //    ticket_xml.Add(XMLUtils.ownerToXml(c));
            //    ticket_xml.Add(XMLUtils.supervisorToXml(admin));
            //    ticket_xml.Add(new XElement("description", t.description));
            //    ticket_xml.Add(XMLUtils.typeToXml(tp));
            //    ticket_xml.Add(XMLUtils.actionsToXml(actions));

            //    XDocument final = new XDocument(new XDeclaration("1.0", "utf-8", null), ticket_xml);

            //    //StringWriter returns encoding utf-16. No worries :)
            //    var wr = new StringWriter();
            //    //TODO: Save into file
            //    final.Save(wr);
            //    Console.Write(wr.GetStringBuilder().ToString());
            //}
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (TicketDAO.removeTicket(null, ticket.code))
            {
                MessageBox.Show("Ticket successfully removed");
                OnTicketChanged(EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Error");
            }
            Close();
        }

        private void submit_action_Click(object sender, EventArgs e)
        {
            AskAdminID admin = new AskAdminID();
            admin.ShowDialog();

            int admin_id = admin.id;
            if (state_list.SelectedItem.ToString().Equals(ticket.STATE))
            {
                int order = actions_list.Items.Count + 1;
            //                db.CreateAction(note.Text, t.code, admin_id, order, t.id_type);
            }
            else
            {
            if (actions != null)
            {
                    if (ticket.admin_id == admin_id)
                    {
                        //db.CloseTicket(t.code);
                        OnTicketChanged(EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("You cannot close this ticket");
                    }
            }
            else
            {
                MessageBox.Show("This ticket has no Actions");
            }
        }
        }
    }
}