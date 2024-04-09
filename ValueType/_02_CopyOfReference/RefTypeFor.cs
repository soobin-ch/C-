using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_CopyOfReference
{
    public partial class RefTypeFor : Form
    {
        public RefTypeFor()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            MyClass myObj1 = new MyClass(1024);

            MyClass myObj2;
            lblObj11.Text = myObj1.iNum.ToString();
            myObj2 = myObj1;
            lblObj12.Text = myObj1.iNum.ToString();
            lblObj22.Text = myObj2.iNum.ToString();
            myObj2.iNum = 2048;

            lblObj22.Text = myObj1.iNum.ToString();
            lblObj23.Text = myObj2.iNum.ToString();

        }
    }
}
