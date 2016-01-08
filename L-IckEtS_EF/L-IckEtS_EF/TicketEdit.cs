using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

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

        private ticket t;

        public TicketEdit()
        {
            InitializeComponent();
        }

        public TicketEdit(ticket t, IEnumerable<request> r)
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
            //TODO: GET TYPE OF TICKET, OWNER, ADMIN AND ALL ACTIONS. THEN FILL
            XElement owner_xml = new XElement("owner", new XAttribute("ownerID", t.client_id), new XAttribute("name", "name"), new XAttribute("email", "email"), "Don't know what to put here");
            XElement supervisor_xml = new XElement("supervisor", new XAttribute("technicianID", t.admin_id), new XAttribute("name", "name"), new XAttribute("email", "email"), "Don't know what to put here");
            XElement description_xml = new XElement("description", t.description);

            //TODO: type may be null, if so exception must be handled
            XElement type_xml = new XElement("type", new XAttribute("typeID", "typeID"), new XAttribute("name", "name"), "Don't know what to put here");
            XElement actions_xml = new XElement("actions", "TODO: get actions");

            //TODO: type may be null, if so exception must be handled
            XElement ticket_xml = new XElement("ticket", new XAttribute("type", "type"), new XAttribute("ticketID", t.code), new XAttribute("status", t.STATE),
                owner_xml,
                supervisor_xml,
                description_xml,
                type_xml,
                actions_xml
            );

            XDocument final = new XDocument(new XDeclaration("1.0", "utf-8", null), ticket_xml);

            //StringWriter returns encoding utf-16. No worries :)
            var wr = new StringWriter();
            final.Save(wr);
            Console.Write(wr.GetStringBuilder().ToString());
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
