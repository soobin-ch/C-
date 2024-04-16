using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_IncrementDecrementOperators
{
    public partial class IncreDecrementForm : Form
    {
        int iNum;
        double dNum;

        public IncreDecrementForm()
        {
            InitializeComponent();
        }

        private void IncreDecrementForm_Load(object sender, EventArgs e)
        {

        }

        private void btnIntDec_Click(object sender, EventArgs e)
        {
            iNum = int.Parse(txtIntNum.Text);
            txtIntNum.Text = (--iNum).ToString();

        }

        private void btnIntInc_Click(object sender, EventArgs e)
        {
            iNum = int.Parse(txtIntNum.Text);
            txtIntNum.Text = (++iNum).ToString();
        }

        private void btnDoubDec_Click(object sender, EventArgs e)
        {
            dNum = double.Parse(txtDoubNum.Text);
            txtDoubNum.Text = (--dNum).ToString();
        }

        private void btnDoubInc_Click(object sender, EventArgs e)
        {
            dNum = double.Parse(txtDoubNum.Text);
            txtDoubNum.Text = (++dNum).ToString();
        }
    }
}
