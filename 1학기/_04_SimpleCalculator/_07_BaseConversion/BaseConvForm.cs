using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_BaseConversion
{
    public partial class BaseConvForm : Form
    {
        public BaseConvForm()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int prevRadix = int.Parse(lblBase.Text);
            int nextRadix = int.Parse(btn.Text);
            int iValue = Convert.ToInt32(txtValue.Text, prevRadix);
            txtValue.Text = Convert.ToString(iValue, nextRadix);
            lblBase.Text = nextRadix.ToString();

        }

       
    }
}
