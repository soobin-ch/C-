using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeConversion
{
    public partial class TypeConvForm : Form
    {
        public TypeConvForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int iNum = int.Parse(txtInt.Text);
            double dNum = double.Parse(txtDouble.Text);
            lblStrToInt.Text = iNum.ToString();
            lblStrToDouble.Text = dNum.ToString();
            double dIntToDouble = iNum;
            lblIntToDoublelmp.Text = dIntToDouble.ToString();
            dIntToDouble = (double)iNum;
            lblIntToDoubleExp.Text = dIntToDouble.ToString();

            int iDoubleToInt = (int)dNum;
            lblDoubleToIntExp.Text = iDoubleToInt.ToString();

        }
    }
}
