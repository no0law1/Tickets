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

        public TicketEdit(ticket t)
        {
            InitializeComponent();
            UpdateUI(t);
        }

        private void UpdateUI(ticket t)
        {
            this.Text = "Ticket " + t.code;
            state.Text = t.STATE;
            priority.Text = t.priority;
            description.Text = t.description;
            created.Text = t.created_at.ToShortDateString();
            closed.Text = t.closed_at.HasValue ? t.closed_at.GetValueOrDefault().ToShortDateString() : "";
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
