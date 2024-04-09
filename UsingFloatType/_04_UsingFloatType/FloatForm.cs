using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_UsingFloatType
{
    public partial class FloatForm : Form
    {
        public FloatForm()
        {
            InitializeComponent();
        }

        private void FloatForm_Load(object sender, EventArgs e)
        {
            float fpi = 3.14f;
            double dpi = 3.14f;

            double dMultiply = fpi * dpi;
            lblFpi.Text = fpi.ToString();
            lblDpi.Text = dpi.ToString();
            lblResult.Text = dMultiply.ToString();

        }
    }
}
