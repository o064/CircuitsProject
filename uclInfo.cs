using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircuitsProject
{
    public partial class uclInfo : UserControl
    {
        public uclInfo()
        {
            InitializeComponent();
        }

        private void gb_Enter(object sender, EventArgs e)
        {

        }

        private void cbResponse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbResponse.Text == "Step")
            {
                lblSourceValue.Visible = true;
                txbSourceValue.Visible = true;
            }

            if (cbResponse.Text == "Natural")
            {
                lblSourceValue.Visible = false;
                txbSourceValue.Visible = false;
            }
        }

        private void Info_Load(object sender, EventArgs e)
        {
            cbResponse.SelectedIndex = 0;
            cbConnection.SelectedIndex = 0;
        }

        private void txbR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
