using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocusApp3
{
    public partial class FocusCorm : Form
    {
        public FocusCorm()
        {
            InitializeComponent();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') txtWeight.Focus();
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') btnInput.Focus();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            lblResult.Text = "학번: " + txtNum.Text + "체중: " + txtWeight.Text;
        }
    }
}
