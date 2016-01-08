using L_IckEtS_EF.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L_IckEtS_EF
{
    public partial class Index : Form
    {

        public Index()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void TicketRemoved(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            ticket_list.Items.Clear();
            using (ticket_systemEntities db = new ticket_systemEntities())
            {
                if (show_non_closed.Checked)
                {
                    setUpListView(new TicketSystemDBQueryable().getNonClosedTicketsTable(db));
                }
                else
                {
                    setUpListView(new TicketSystemDBQueryable().getAllTicketsTable(db));
                }
            }
        }

        private void setUpListView(IEnumerable<ticket> table)
        {
            foreach (var ticket in table)
            {
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
            using (ticket_systemEntities db = new ticket_systemEntities())
            {
                if (ticket_list.SelectedItems.Count < 1)
                {
                    MessageBox.Show("You need to select a Ticket");
                }
                else
                {
                    int code = int.Parse(ticket_list.SelectedItems[0].Text);
                    var ticket = new TicketSystemDBQueryable().getTicketById(db, code);
                    var info_requests = new TicketSystemDBQueryable().getTicketRequests(db, code);
                    TicketEdit t = new TicketEdit(ticket, info_requests);
                    t.Removed += new TicketEdit.RemovedEventHandler(TicketRemoved);
                    t.Show();
                }
            }
        }
    }
}
