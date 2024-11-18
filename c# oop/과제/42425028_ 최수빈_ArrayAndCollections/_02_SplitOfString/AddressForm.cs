using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_SplitOfString
{
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            if( txtAddress.Text.Length <=0 )
            {
                return;
            }
            string[] splitAddresses = txtAddress.Text.Split(' ');

            foreach (string addr in splitAddresses)
                lsbAddresses.Items.Add(addr);


            lblProvince.Text = splitAddresses[0];

            if (splitAddresses.Length > 1)
            {
                lblElementary.Text = splitAddresses[1];
            }

            if(splitAddresses.Length > 2)
            {
                lblRoad.Text = splitAddresses[2];
            }

            if(splitAddresses.Length > 3)
            {
                lblBuilding.Text = splitAddresses[3];
            }

            if(splitAddresses.Length > 4)
            {
                for (int i = 4; i< splitAddresses.Length; i++)
                {
                    lblDetails.Text += splitAddresses[i] + " ";
                }
            }

        }
    }
}
