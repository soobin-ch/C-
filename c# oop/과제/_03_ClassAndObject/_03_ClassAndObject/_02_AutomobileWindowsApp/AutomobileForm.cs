using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_AutomobileWindowsApp
{

   
    public partial class AutomobileForm : Form
    {
        Automobile myCar;
        public AutomobileForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            myCar = new Automobile();
            myCar.type = cbType.SelectedItem.ToString();
            myCar.speed = int.Parse(txtSpeed.Text);


            DisplayInfo();

        }

        private void btnAccel_Click(object sender, EventArgs e)
        {
            myCar.SpeedUp(5);
            DisplayInfo();
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            myCar.SpeedDown(5);

            DisplayInfo();
        }

        private void DisplayInfo()
        {
            lblType.Text = myCar.type;
            lblSpeed.Text = myCar.speed.ToString();
        }
    }
}
