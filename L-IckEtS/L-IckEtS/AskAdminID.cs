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
    public partial class AskAdminID : Form
    {
        public int id { get; set; }

        public AskAdminID()
        {
            InitializeComponent();
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Enter)))
            {
                this.id = int.Parse(id_text.Text);
                Close();
            }
        }
    }
}
