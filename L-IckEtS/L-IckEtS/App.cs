using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L_IckEtS
{
    public partial class App : Form
    {

        public App()
        {
            InitializeComponent();
        }

        private void non_closed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: SHOW NON CLOSED TICKETS");
        }

        private void assign_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: ASSIGN TECH TO TICKET");
        }

        private void insert_action_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: INSERT ACTION TO TICKET");
        }

        private void remove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: REMOVE A TICKET");
        }

        private void export_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: EXPORT INFO OF A TICKET");
        }
    }
}
