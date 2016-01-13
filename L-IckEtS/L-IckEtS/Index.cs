using L_IckEtS.data.entity;
using L_IckEtS.database;
using L_IckEtS.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace L_IckEtS_EF
{
    public partial class Index : Form
    {
        private static readonly string DATA_SOURCE = "ASUS";

        private static readonly string INITIAL_CATALOG = "ticket_system";

        private static readonly Boolean INTEGRATED_SECURITY = true;

        private DB database;

        public Index()
        {
            InitializeComponent();
            database = new DB(DATA_SOURCE, INITIAL_CATALOG, INTEGRATED_SECURITY);
            UpdateUI();
        }

        private void TicketRemoved(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            ticket_list.Items.Clear();

            IEnumerable<Ticket> tickets;
            if (show_non_closed.Checked)
            {
                tickets = TicketDAO.getNonClosedTickets(database);
            }
            else
            {
                tickets = TicketDAO.getAllTickets(database);
            }
            setUpListView(tickets);
        }

        private void setUpListView(IEnumerable<Ticket> table)
        {
            foreach (Ticket ticket in table)
            {
                if (ticket == null)
                {
                    break;
                }
                string closed = ticket.closed_at == null ? "" : ticket.closed_at.ToString();
                string[] row = { ticket.code.ToString(), ticket.STATE, ticket.created_at.ToString(), closed, ticket.priority, ticket.admin_id.ToString() };
                var listViewItem = new ListViewItem(row);
                ticket_list.Items.Add(listViewItem);
            }
        }

        private void show_non_closed_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void edit_ticket_Click(object sender, EventArgs e)
        {
            if (ticket_list.SelectedItems.Count < 1)
            {
                MessageBox.Show("You need to select a Ticket");
            }
            else
            {
                int code = int.Parse(ticket_list.SelectedItems[0].Text);

                var ticket = TicketDAO.getTicketById(database, code);
                var type = ticket.id_type != null ? TypeDAO.getType(database, ticket.id_type.Value):null;
                var client = ClientDAO.getClient(database, ticket.client_id);
                var admin = AdminDAO.getAdminByID(database, ticket.admin_id);
                var info_requests = RequestDAO.getTicketRequests(database, code);
                var actions = ActionDAO.getTicketActions(database, code);

                TicketDetails t = new TicketDetails(ticket, type, client, admin, info_requests, actions);
                t.Changed += new TicketDetails.RemovedEventHandler(TicketRemoved);
                t.Show();
            }
        }
    }
}
