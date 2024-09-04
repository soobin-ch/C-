using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingDecimalType
{
    public partial class DecimalForm : Form
    {
        public DecimalForm()
        {
            InitializeComponent();
        }

        private void DecimalForm_Load(object sender, EventArgs e)
        {
            lblFloat.Text = (22f / 7f).ToString();
            lblDouble.Text = (22.0 / 7).ToString();
            lblDecimal.Text = (22m / 7m).ToString();

        }
    }
}
