using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_EmployManagement
{
    public partial class EmployForm : Form
    {

        string sFigFilename = "";
        const int I_MAX_OBJ = 10;
        Employee[] eEmployee = new Employee[I_MAX_OBJ];





        public EmployForm()
        {
            InitializeComponent();
        }

        private void btnGetPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                if (filename == null)
                {
                    return;
                }

                sFigFilename = filename;

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(sFigFilename =="")
            {
                MessageBox.Show("그림파일을 선택하세요");
                return;
            }

            if (Employee.GetTotalNumbers() >= I_MAX_OBJ)
            {
                return;
            }

            eEmployee[Employee.GetTotalNumbers()] = new Employee(txtName.Text, txtCompany.Text, txtSalary.Text, sFigFilename);

            txtName.Text = "";
            
            lblNumbers.Text = Employee.GetTotalNumbers().ToString();


            cbEmployeeId.Items.Add(Employee.GetTotalNumbers());

        }

        private void cbEmployeeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee eEmp = eEmployee[cbEmployeeId.SelectedIndex];
            lblId.Text = eEmp.Id.ToString();
            lblName.Text = eEmp.Name;
            lblCompany.Text = eEmp.CompanyName;
            lblSalary.Text = eEmp.Salary;

            pbMain.Image = new Bitmap(eEmp.Picture);

        }
    }
}
