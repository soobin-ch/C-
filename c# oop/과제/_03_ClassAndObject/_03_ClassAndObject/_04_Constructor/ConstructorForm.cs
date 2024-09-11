using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Constructor
{
    public partial class ConstructorForm : Form
    {


        Automobile[] myCar = new Automobile[10];

        int iCnt = -1;

        public ConstructorForm()
        {
            InitializeComponent();
        }

        private void btnCreateNoArg_Click(object sender, EventArgs e)
        {
            iCnt++;
            if (iCnt >= 10) return;

            myCar[iCnt] = new Automobile();

            DisplayInfo(iCnt);
        }
        private void DisplayInfo(int iCnt)
        {
            lblCount.Text = iCnt.ToString();
            lblType.Text = myCar[iCnt].type;
            lblSpeed.Text = myCar[iCnt].speed.ToString();

        }

        private void btnCreateWithArgs_Click(object sender, EventArgs e)
        {
            iCnt++;

            if(iCnt >= 10) return;
            myCar[iCnt] = new Automobile(cbType.SelectedItem.ToString(), int.Parse(txtSpeed.Text));


            DisplayInfo(iCnt);

        }
    }
}
