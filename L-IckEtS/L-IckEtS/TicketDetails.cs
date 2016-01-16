using L_IckEtS.data.entity;
using L_IckEtS.database;
using L_IckEtS.model;
using L_IckEtS_EF.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

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

        private DB database;

        private Ticket ticket;

        private L_IckEtS.model.Type ticketType;

        private Client client;

        private Admin admin;

        private IEnumerable<Request> requests;

        private IEnumerable<L_IckEtS.model.Action> actions;

        private IEnumerable<Step> steps;

        public TicketDetails(DB database, Ticket ticket, L_IckEtS.model.Type type, Client client,
                                Admin admin, IEnumerable<Request> requests,
                                IEnumerable<L_IckEtS.model.Action> actions,
                                IEnumerable<Step> steps)
        {
            InitializeComponent();
            this.database = database;
            this.ticket = ticket;
            this.ticketType = type;
            this.client = client;
            this.admin = admin;
            this.requests = requests;
            this.actions = actions;
            this.steps = steps;
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
                string[] row = { action.note, action.created_at.ToShortDateString(), action.ended_at == null ? "" : true.ToString(), action.admin_id.ToString() };
                var listViewItem = new ListViewItem(row);
                actions_list.Items.Add(listViewItem);
            }

            // RESOLVE
            if (!ticket.STATE.Equals("In Progress"))
            {
                note.Enabled = false;
                steps_list.Enabled = false;
                submit_action.Enabled = false;
                state_list.Enabled = false;
            }
            else
            {
                state_list.SetSelected(0, true);
                foreach(var step in steps)
                {
                    steps_list.Items.Add(step.description);
                }
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            XElement ticket_xml = XMLUtils.ticketToXml(ticket);
            ticket_xml.Add(XMLUtils.ownerToXml(client));
            ticket_xml.Add(XMLUtils.supervisorToXml(admin));
            ticket_xml.Add(new XElement("description", ticket.description));
            ticket_xml.Add(XMLUtils.typeToXml(ticketType));
            ticket_xml.Add(XMLUtils.actionsToXml(actions));

            XDocument final = new XDocument(new XDeclaration("1.0", "utf-8", null), ticket_xml);

            //StringWriter returns encoding utf-16. No worries :)
            var wr = new StringWriter();
            //TODO: Save into file
            final.Save(wr);
            Console.Write(wr.GetStringBuilder().ToString());
        }

        private void remove_Click(object sender, EventArgs e)
        {
            AskAdminID admin = new AskAdminID();
            admin.ShowDialog();

            int admin_id = admin.id;
            if (actions != null && ticket.admin_id == admin_id)
            {
                Boolean removed = false;
                if (this.admin.id == admin_id)
                {
                    removed = TicketDAO.removeTicket(database, ticket.code);
                }
                if (removed)
                {
                    MessageBox.Show("Ticket successfully removed");
                    OnTicketChanged(EventArgs.Empty);
                    Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void submit_action_Click(object sender, EventArgs e)
        {
            AskAdminID admin = new AskAdminID();
            admin.ShowDialog();

            int admin_id = admin.id;
            if (state_list.SelectedItem.ToString().Equals(ticket.STATE))
            {
                int order = steps_list.SelectedIndex;
                if (order >= 0)
                {
                    L_IckEtS.model.Action action = new L_IckEtS.model.Action(note.Text, ticket.code, admin_id, order + 1, ticket.id_type);
                    ActionDAO.insertAction(database, action);
                    Close();
                }
                else
                {
                    MessageBox.Show("Must Select a step");
                }
                //TODO: Test
            }
            else
            {
                if (actions_list.Items.Count>0)
                {
                        if (ticket.admin_id == admin_id)
                        {
                            TicketDAO.closeTicket(database, ticket.code);
                            OnTicketChanged(EventArgs.Empty);
                            Close();
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