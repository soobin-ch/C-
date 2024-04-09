using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_CopyOfInteger
{
    public partial class ValueTypeForm : Form
    {
        public ValueTypeForm()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            int ix = 0, iy = 0;

            ix = 1024;

            lblIx1.Text = ix.ToString();
            lblIy1.Text = iy.ToString();


            iy = ix;
            lblIx2.Text = ix.ToString();
            lblIy2.Text = iy.ToString();

            iy = 2048;
            lblIx3.Text = ix.ToString();
            lblIy3.Text = iy.ToString();



        }
    }
}
