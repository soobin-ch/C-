using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_BitOperators
{
    public partial class NetworkIdForm : Form
    {
        public NetworkIdForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int ip1 = int.Parse(txtIp1.Text); int msk1 = int.Parse(txtMask1.Text);
            int ip2 = int.Parse(txtIp2.Text); int msk2 = int.Parse(txtMask2.Text);
            int ip3 = int.Parse(txtIp3.Text); int msk3 = int.Parse(txtMask3.Text);
            int ip4 = int.Parse(txtIp4.Text); int msk4 = int.Parse(txtMask4.Text);


            lblNet1.Text = (ip1 & msk1).ToString();
            lblNet2.Text = (ip2 & msk2).ToString();
            lblNet3.Text = (ip3 & msk3).ToString();
            lblNet4.Text = (ip4 & msk4).ToString();



            lblBC1.Text = ((byte)(ip1 | ~msk1)).ToString();
            lblBC2.Text = ((byte)(ip2 | ~msk2)).ToString();
            lblBC3.Text = ((byte)(ip3 | ~msk3)).ToString();
            lblBC4.Text = ((byte)(ip4 | ~msk4)).ToString();

        }
    }
}
