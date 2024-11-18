using _05_EncapsulationWindow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_EncapsulationWindowsApp
{
    public partial class StudentInfoForm : Form
    {


        string picture = "";

        const int I_MAX_OBJ = 10;

        int iCnt = -1;

        Student[] myStd = new Student[I_MAX_OBJ];


        int currStd1 = -1, currStd2 = -1;
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        private void btnGetPic_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;

                if (filename == null) return;
                picture = filename;

            }
        }

        private void btnCreateObject_Click(object sender, EventArgs e)
        {
            if (picture == "")
            {
                MessageBox.Show("그림파일을 선택하세요");
                return;
            }

            iCnt++;

            if (iCnt >= I_MAX_OBJ)
                return;

            string dept = cbDept.SelectedItem.ToString();
            int id = int.Parse(txtId.Text.ToString());
            string name = txtName.Text;
            int credits = int.Parse(txtCredits.Text);
            string gender = cbGender.SelectedItem.ToString();

            int age = int.Parse(txtAge.Text);
            string address = txtAddress.Text;

            myStd[iCnt] = new Student(name, gender, address, age, picture, id, dept, credits);

            cbSelectStudent1.Items.Add(iCnt);
            cbSelectStudent2.Items.Add(iCnt);


        }

        private void cbSelectStudent1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currStd1 = cbSelectStudent1.SelectedIndex;
            txtModAddress.Text = myStd[currStd1].SAddress;
        }

        private void btnModifyAddress_Click(object sender, EventArgs e)
        {
            if (currStd1 < 0)
            {
                MessageBox.Show("학생을 선택하세요 ");
                return;
            }
            myStd[currStd1].SAddress = txtModAddress.Text;
        }

        private void btnAddAge_Click(object sender, EventArgs e)
        {
            if (currStd1 < 0)
            {
                MessageBox.Show("학생을 선택하세요 ");
                return;
            }
            myStd[currStd1].IAge += 1;

        }

        private void btnAddCredits_Click(object sender, EventArgs e)
        {
            if (currStd1 < 0)
            {
                MessageBox.Show("학생을 선택하세요 ");
                return;
            }
            myStd[currStd1].IAcquiredCredits += int.Parse(txtAddCredits.Text);
        }

        private void btnModifyPic_Click(object sender, EventArgs e)
        {
            if (currStd1 < 0)
            {
                MessageBox.Show("학생을 선택하세요 ");
                return;
            }


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;

                if (filename == null) return;
                myStd[currStd1].SPicture = filename;

            }
        }

        private void cbSelectStudent2_SelectedIndexChanged(object sender, EventArgs e)
        {
            currStd2 = cbSelectStudent2.SelectedIndex;
            pcMain.Image = new Bitmap(myStd[currStd2].SPicture);
            lblDept.Text = myStd[currStd2].SDepartment;
            lblStdId.Text = myStd[currStd2].ISTudentId.ToString();
            lblName.Text = myStd[currStd2].SName;
            lblCredits.Text = myStd[currStd2].IAcquiredCredits.ToString();
            lblGender.Text = myStd[currStd2].SGender;
            lblAge.Text = myStd[currStd2].IAge.ToString();
            lblAddress.Text = myStd[currStd2].SAddress;

        }

        private void StudentInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
