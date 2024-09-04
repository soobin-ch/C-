using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_RelationalOperators
{
    public partial class RelatonalOpForm : Form
    {
        public RelatonalOpForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dNum1 = double.Parse(txtNum1.Text);
            double dNum2 = double.Parse(txtNum2.Text);
            txtEQ.Text = (dNum1 == dNum2).ToString();
            txtNE.Text = (dNum1 != dNum2).ToString();
            txtGT.Text = (dNum1 > dNum2).ToString();
            txtLT.Text = (dNum1 < dNum2).ToString();
            txtGE.Text = (dNum1 >= dNum2).ToString();
            txtLE.Text = (dNum1 <= dNum2).ToString();
        }
    }
}
