using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMethod
{
    public partial class StringAppForm : Form
    {
        public StringAppForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String sInput = txtInput.Text;

            lblLength.Text += sInput.Length.ToString();
            lblLeft3Chars.Text += sInput.Substring(0, 3);
            lblRight3Chars.Text += sInput.Substring(sInput.Length - 3);
            lbl5th3chars.Text += sInput.Substring(4, 3);
            lblBlankPosition.Text += sInput.IndexOf(" ").ToString();

        }
    }
}
