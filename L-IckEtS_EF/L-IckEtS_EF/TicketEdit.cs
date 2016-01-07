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
    public partial class TicketEdit : Form
    {
        public TicketEdit()
        {
            InitializeComponent();
        }

        public TicketEdit(ticket t, IQueryable<request> r)
        {
            InitializeComponent();
            UpdateUI(t, r);
        }

        private void UpdateUI(ticket t, IQueryable<request> r)
        {
            this.Text = "Ticket " + t.code;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
