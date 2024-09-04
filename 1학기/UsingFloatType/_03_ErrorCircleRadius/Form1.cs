using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorCircleRadius
{
    public partial class CircleWidth : Form
    {
        public CircleWidth()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const double PI = 3.14;
           
            double iRadius = double.Parse(txtInput.Text);
            double area = PI * iRadius * iRadius;
            lblResult.Text = area.ToString();

        }
    }
}
