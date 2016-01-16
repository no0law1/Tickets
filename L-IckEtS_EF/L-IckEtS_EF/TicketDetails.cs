using L_IckEtS_EF.utils;
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

        private ticket t;

        private IEnumerable<request> requests;

        private IEnumerable<action> actions;

        private IEnumerable<step> steps;

        public TicketDetails(ticket t, IEnumerable<request> requests, IEnumerable<action> actions, IEnumerable<step> steps)
        {
            InitializeComponent();
            this.t = t;
            this.requests = requests;
            this.actions = actions;
            this.steps = steps;
            UpdateUI();
        }
        private void UpdateUI()
        {
            // DETAILS
            this.Text = "Ticket " + this.t.code;
            state.Text = t.STATE;
            priority.Text = t.priority;
            type.Text = t.type==null?"":t.type.NAME;
            description.Text = t.description;
            created.Text = t.created_at.ToShortDateString();
            closed.Text = t.closed_at.HasValue ? t.closed_at.GetValueOrDefault().ToShortDateString() : "";

            // REQUESTS
            info_requests.Items.Clear();
            foreach (request req in requests)
            {
                string response_date = req.response_date.HasValue ? req.response_date.Value.ToShortDateString() : "";
                string[] row = { req.id.ToString(), req.created_at.ToShortDateString(), response_date, req.admin_id.ToString() };
                var listViewItem = new ListViewItem(row);
                info_requests.Items.Add(listViewItem);
            }

            // ACTIONS
            action_type.Text = t.type == null ? "" : t.type.NAME;
            actions_list.Items.Clear();
            foreach (var action in actions)
            {
                string[] row = { action.note, action.admin_id.ToString(), action.step_order.ToString(), action.ended_at==null ? "":true.ToString() };
                var listViewItem = new ListViewItem(row);
                actions_list.Items.Add(listViewItem);
            }

            // RESOLVE
            if (!t.STATE.Equals("In Progress"))
            {
                note.Enabled = false;
                steps_list.Enabled = false;
                submit_action.Enabled = false;
                state_list.Enabled = false;
            }
            else
            {
                state_list.SetSelected(0, true);
                steps_list.Items.Clear();
                foreach(var step_aux in steps)
                {
                    steps_list.Items.Add(step_aux.description);
                }
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
                actions = new TicketSystemDBQueryable().getTicketActions(db, t.code);

                StringWriter wr = writeTicketToXml(t, c, admin, tp, actions);

                Console.Write(wr.GetStringBuilder().ToString());
            }
        }

        private StringWriter writeTicketToXml(ticket t, client c, administrator admin, L_IckEtS_EF.type tp, IEnumerable<action> actions)
        {
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
            return wr;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            AskAdminID admin = new AskAdminID();
            admin.ShowDialog();

            int admin_id = admin.id;
            using (ticket_systemEntities db = new ticket_systemEntities())
            {
                ObjectParameter count = new ObjectParameter("res", SqlDbType.Int);
                if (t.admin_id == admin_id)
                {
                    db.RemoveTicket(this.t.code, count);
                }
                if (!count.Value.Equals(0))
                {
                    MessageBox.Show("Ticket successfully removed");
                    OnTicketChanged(EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            Close();
        }

        private void submit_action_Click(object sender, EventArgs e)
        {
            AskAdminID admin = new AskAdminID();
            admin.ShowDialog();

            int admin_id = admin.id;
            using (ticket_systemEntities db = new ticket_systemEntities())
            {
                if (state_list.SelectedItem.ToString().Equals(t.STATE))
                {
                    int order = steps_list.SelectedIndex;
                    if (order != -1)
                    {
                        db.CreateAction(note.Text, t.code, admin_id, order + 1, t.id_type);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Must choose step to resolve");
                    }
                }
                else
                {
                    if (new TicketSystemDBQueryable().existsActions(db, t.code))
                    {
                        if (t.admin_id == admin_id)
                        {
                            db.CloseTicket(t.code);
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
}
