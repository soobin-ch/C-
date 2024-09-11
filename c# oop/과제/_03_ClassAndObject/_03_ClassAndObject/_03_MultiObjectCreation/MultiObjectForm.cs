using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_MultiObjectCreation
{
    public partial class MultiObjectForm : Form
    {

        Automobile[] myCar = new Automobile[10];
        int iCnt = -1;

        public MultiObjectForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            iCnt++;
            if (iCnt >= 10)
                return;

            myCar[iCnt] = new Automobile();
            myCar[iCnt].type= cbType.SelectedItem.ToString();
            myCar[iCnt].speed = int.Parse(txtSpeed.Text);

            DisplayInfo(iCnt);
        }

        private void DisplayInfo(int iCnt)
        {
            lblCount.Text = iCnt.ToString();
            lblType.Text = myCar[iCnt].type;
            lblSpeed.Text = myCar[iCnt].speed.ToString();

        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }
    }
}
