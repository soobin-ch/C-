using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_ComplexAssignment
{
    public partial class TextAddForm : Form
    {
        public TextAddForm()
        {
            InitializeComponent();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar =='\r')
            {
                txtOutput.Text += txtInput.Text + "\r\n";
                txtOutput.Focus();


                txtOutput.ScrollToCaret();
                txtInput.Text = "";
                txtInput.Focus();

            }
        }
    }
}
