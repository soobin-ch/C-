using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariableScope
{
    public partial class VariableScopeForm : Form
    {
        String sGlobal;
        public VariableScopeForm()
        {
            InitializeComponent();
        }

        private void VariableScopeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string sLocal;
            sGlobal = txtGlobal.Text;
            sLocal = txtLocal.Text;

            lblGlobalRead.Text = sGlobal;
            lblLocalRead.Text = sLocal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblGlobalClick.Text = sGlobal;
        }
    }
}
