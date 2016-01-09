using L_IckEtS_EF.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace L_IckEtS_EF
{
    public partial class TicketDetails : Form
    {
        public delegate void RemovedEventHandler(object sender, EventArgs e);

        public event RemovedEventHandler Removed;

        protected virtual void OnRemoved(EventArgs e)
        {
            if (Removed != null)
                Removed(this, e);
        }

        private ticket t;

        public TicketDetails()
        {
            InitializeComponent();
        }

        public TicketDetails(ticket t, IEnumerable<request> r)
        {
            InitializeComponent();
            this.t = t;
            UpdateUI(t, r);
        }
        private void UpdateUI(ticket t, IEnumerable<request> r)
        {
            this.Text = "Ticket " + this.t.code;
            state.Text = t.STATE;
            priority.Text = t.priority;
            description.Text = t.description;
            created.Text = t.created_at.ToShortDateString();
            closed.Text = t.closed_at.HasValue ? t.closed_at.GetValueOrDefault().ToShortDateString() : "";

            foreach (request req in r)
            {
                string response_date = req.response_date.HasValue ? req.response_date.Value.ToShortDateString() : "";
                string[] row = { req.id.ToString(), req.created_at.ToShortDateString(), response_date, req.admin_id.ToString() };
                var listViewItem = new ListViewItem(row);
                info_requests.Items.Add(listViewItem);
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            client c = null;
            administrator admin = null;
            type tp = null;
            IEnumerable<action> actions = null;
            using (ticket_systemEntities db = new ticket_systemEntities())
            {
                c = new TicketSystemDBQueryable().getClientById(db, t.client_id);
                admin = new TicketSystemDBQueryable().getAdminById(db, t.admin_id);
                if (t.id_type != null)
                    tp = new TicketSystemDBQueryable().getTypeById(db, t.id_type);
                actions = new TicketSystemDBQueryable().getActionsByTicketId(db, t.code);

                XElement ticket_xml = XMLUtils.ticketToXml(t);
                ticket_xml.Add(XMLUtils.ownerToXml(c));
                ticket_xml.Add(XMLUtils.supervisorToXml(admin));
                ticket_xml.Add(new XElement("description", t.description));
                ticket_xml.Add(XMLUtils.typeToXml(tp));
                ticket_xml.Add(XMLUtils.actionsToXml(actions));

                XDocument final = new XDocument(new XDeclaration("1.0", "utf-8", null), ticket_xml);

                //StringWriter returns encoding utf-16. No worries :)
                var wr = new StringWriter();
                //TODO: Save into file
                final.Save(wr);
                Console.Write(wr.GetStringBuilder().ToString());
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            using (ticket_systemEntities db = new ticket_systemEntities())
            {
                ObjectParameter count = new ObjectParameter("res", SqlDbType.Int);
                db.RemoveTicket(this.t.code, count);
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
