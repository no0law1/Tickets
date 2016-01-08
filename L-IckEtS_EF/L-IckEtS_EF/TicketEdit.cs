using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L_IckEtS_EF
{
    public partial class TicketEdit : Form
    {

        public delegate void RemovedEventHandler(object sender, EventArgs e);
        public event RemovedEventHandler Removed;

        protected virtual void OnRemoved(EventArgs e)
        {
            if (Removed != null)
                Removed(this, e);
        }

        private int code;

        public TicketEdit()
        {
            InitializeComponent();
        }

        public TicketEdit(ticket t, IEnumerable<request> r)
        {
            InitializeComponent();
            this.code = t.code;
            UpdateUI(t, r);
        }

        private void UpdateUI(ticket t, IEnumerable<request> r)
        {
            this.Text = "Ticket " + this.code;
            state.Text = t.STATE;
            priority.Text = t.priority;
            description.Text = t.description;
            created.Text = t.created_at.ToShortDateString();
            closed.Text = t.closed_at.HasValue ? t.closed_at.GetValueOrDefault().ToShortDateString() : "";

            foreach(request req in r)
            {
                //TODO: insert requests to db for testing purposes
                string response_date = req.response_date.HasValue ? req.response_date.Value.ToShortDateString() : "";
                string[] row = { req.id.ToString(), req.created_at.ToShortDateString(), response_date, req.admin_id.ToString() };
                var listViewItem = new ListViewItem(row);
                info_requests.Items.Add(listViewItem);
            }
        }

        private void resolve_Click(object sender, EventArgs e)
        {
            //TODO: new form with insert of actions?
        }

        private void export_Click(object sender, EventArgs e)
        {
            // TODO: export info using xml schema
        }

        private void remove_Click(object sender, EventArgs e)
        {
            using (ticket_systemEntities db = new ticket_systemEntities())
            {
                ObjectParameter count = new ObjectParameter("res", SqlDbType.Int);
                db.RemoveTicket(code, count);
                if (!count.Value.Equals(0))
                {
                    MessageBox.Show("Ticket successfully removed");
                    OnRemoved(EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            Close();
        }
    }
}
