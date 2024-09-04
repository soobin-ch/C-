using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_LogicalOperators
{
    public partial class LogicalOpForm : Form
    {
        public LogicalOpForm()
        {
            InitializeComponent();
        }

        private void LogicalOpForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool a = bool.Parse(txtA.Text);
            bool b = bool.Parse(txtB.Text);

            lblAnb.Text = (a & b).ToString();
            lblAnnB.Text = (a && b).ToString();
            lblAoB.Text = (a | b).ToString();
            lblAooB.Text = (a || b).ToString();
            lblAxorB.Text = (a ^ b).ToString();
            lblNotA.Text = (!a).ToString();

        }
    }
}
