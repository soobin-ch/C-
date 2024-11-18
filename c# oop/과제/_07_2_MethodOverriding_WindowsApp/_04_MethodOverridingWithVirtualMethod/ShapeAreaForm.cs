using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_MethodOverridingWithVirtualMethod
{
    public partial class ShapeAreaForm : Form
    {

        Shape mShape;
        public ShapeAreaForm()
        {
            InitializeComponent();
        }

        private void ShapeAreaForm_Load(object sender, EventArgs e)
        {

        }

        

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedItem.ToString() == "원")
            {
                lblInputNum1.Text = "반지름";
                lblInputNum2.Visible = false;

                txtNum2.Visible = false;

                lblOutputLbl1.Text = "반지름";
                lblOutputLbl2.Visible = false;
                lblOutputNum2.Visible = false;

            }
            else
            {
                lblInputNum1.Text = "가로:";
                lblInputNum2.Visible = true;
                txtNum2.Visible = true;


                lblOutputLbl1.Text = "가로";
                lblOutputLbl2.Visible = true;
                lblOutputNum2.Visible = true;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string type;
            double dNum1, dNum2;

            if (cbType.SelectedIndex < 0)
            {
                MessageBox.Show("도형을 선택해주세요");
                return;
            }

            type = cbType.SelectedItem.ToString();
            dNum1 = double.Parse(txtNum1.Text);
            dNum2 = double.Parse(txtNum2.Text);



            switch (cbType.SelectedIndex)
            {
                case 0: mShape = new Rectangle(type, dNum1, dNum2); break;
                case 1: mShape = new Triangle(type, dNum1, dNum2); break;
                case 2: mShape = new Circle(type, dNum1);break;

            }

            mShape.CalculateArea();
            lblType.Text = mShape.SType;
            lblResult.Text  = mShape.DArea.ToString();

            if(mShape.SType == "원")
            {
                lblOutputNum1.Text = ((Circle)mShape).DRadius.ToString(); 
            }
            else
            {
                lblOutputNum1.Text = mShape.DWidth.ToString();
                lblOutputNum2.Text = mShape.DHeight.ToString();

            }
        }

       


    }
}
