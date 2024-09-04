using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_StringConnection
{
    public partial class StringConnectionForm : Form
    {
        public StringConnectionForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblResult.Text = "저는 " + txtUniv.Text + " " + txtDept.Text + " " + txtName.Text + "입니다.";
        }
    }
}
