using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_PolymoephismWindowsApp
{
    public partial class PolymorphismForm : Form
    {
        Unit unit;


        public PolymorphismForm()
        {
            InitializeComponent();
        }

        private void cbCreateUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbCreateUnit.SelectedIndex)
            {
                case 0:
                    unit = new SCV();
                    btnTankMode.Visible = false;
                    break;
                case 1:
                    unit = new Marine();
                    btnTankMode.Visible = false;
                    break;
                case 2:
                    unit = new Tank();
                    btnTankMode.Visible = true;
                    break;

            }

            lblResult.Text = "";
            pictureBox1.Image = imageList1.Images[unit.ImgNo];
        }

        private void btnTankMode_Click(object sender, EventArgs e)
        {
            if (btnTankMode.Text == "시즈모드로") btnTankMode.Text = "일반모드로";
            else btnTankMode.Text = "시즈모드로";

            ((Tank)unit).ChangeMode();

            pictureBox1.Image = imageList1.Images[unit.ImgNo];
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            lblResult.Text = unit.Move();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            lblResult.Text = unit.Attack();
        }
    }
}
