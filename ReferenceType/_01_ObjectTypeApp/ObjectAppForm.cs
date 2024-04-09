using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_ObjectTypeApp
{
    public partial class ObjectAppForm : Form
    {
        public ObjectAppForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            object oInt = 22;
            object oDouble = 3.14;
            object oString = "두원공대";

            lblInteger.Text = oInt.ToString() + "/" + oInt.GetType().ToString();
            lblDouble.Text = oDouble.ToString() + "/" + oDouble.GetType().ToString();
            lblString.Text = oString.ToString() + "/" + oString.GetType().ToString();

                }
    }
}
