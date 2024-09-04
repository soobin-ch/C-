using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_ArithmeticOperators
{
    public partial class ArithmeticForm : Form
    {
        public ArithmeticForm()
        {
            InitializeComponent();
        }

        private void btnIntCalc_Click(object sender, EventArgs e)
        {
            int iNum1 = int.Parse(txtNum1.Text);
            int iNum2 = int.Parse(txtNum2.Text);

            txtlAdd.Text = (iNum1 + iNum2).ToString();
            txtlMin.Text = (iNum1 - iNum2).ToString();
            txtlMul.Text = (iNum1 * iNum2).ToString();
            txtlDiv.Text = (iNum1 / iNum2).ToString();
            txtlMod.Text = (iNum1 % iNum2).ToString();

        }

        private void btnDoubCalc_Click(object sender, EventArgs e)
        {
            double dNum1 = double.Parse(txtNum1.Text);
            double dNum2 = double.Parse(txtNum2.Text);
            txtDAdd.Text = (dNum1 + dNum2).ToString();
            txtDMin.Text = (dNum1 - dNum2).ToString();
            txtDMul.Text = (dNum1 * dNum2).ToString();
            txtDDiv.Text = (dNum1 / dNum2).ToString();
            txtDMod.Text = (dNum1 % dNum2).ToString();

        }
    }
}
