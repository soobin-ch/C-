using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_SimpleCalculator
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button myBtn = (Button)sender;
            lblOp.Text = myBtn.Text;
            double dNum1 = double.Parse(txtNum1.Text);
            double dNum2 = double.Parse(txtNum2.Text);


            switch(myBtn.Text)
            {
                case "+": txtResult.Text = (dNum1 + dNum2).ToString();break;
                case "-": txtResult.Text = (dNum1 - dNum2).ToString(); break;
                case "*": txtResult.Text = (dNum1 * dNum2).ToString(); break;
                case "/": txtResult.Text = (dNum1 / dNum2).ToString(); break;
                case "%": txtResult.Text = (dNum1 % dNum2).ToString(); break;
                case "==": txtResult.Text = (dNum1 == dNum2).ToString(); break;
                case "!=": txtResult.Text = (dNum1 != dNum2).ToString(); break;
                case ">": txtResult.Text = (dNum1 > dNum2).ToString(); break;
                case "<": txtResult.Text = (dNum1 < dNum2).ToString(); break;
                case ">=": txtResult.Text = (dNum1 >= dNum2).ToString(); break;
                case "<=": txtResult.Text = (dNum1 <= dNum2).ToString(); break;


            }
        }
    }
}
