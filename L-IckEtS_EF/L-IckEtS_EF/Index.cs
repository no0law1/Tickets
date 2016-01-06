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
            InitUI();
        }

        private void InitUI()
        {
            using (var db = new ticket_systemEntities())
            {
                if (show_non_closed.Checked)
                {
                    Console.WriteLine("non closed");
                    foreach (var ticket in db.ticket)
                    {
                        string closed = ticket.closed_at == null ? "" : ticket.closed_at.ToString();
                        string[] row = { ticket.code.ToString(), ticket.STATE, ticket.created_at.ToString(), closed, ticket.priority, ticket.admin_id.ToString() };
                        var listViewItem = new ListViewItem(row);
                        ticket_list.Items.Add(listViewItem);
                    }
                }
                else
                {

                }
            }
        }

        private void show_non_closed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void edit_ticket_Click(object sender, EventArgs e)
        {
            using(var db = new ticket_systemEntities())
            {
                // selected items returns the code. Need lokking into
                int code = int.Parse(ticket_list.SelectedItems[0].Text);
                var ticket = (from t in db.ticket
                                  where t.code == code
                                  select t).FirstOrDefault();
                MessageBox.Show("Ticket: " + ticket.code+ ", "+ticket.STATE);
            }
        }
    }
}
