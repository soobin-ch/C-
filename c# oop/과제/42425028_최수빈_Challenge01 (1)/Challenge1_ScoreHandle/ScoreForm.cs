using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge1_ScoreHandle
{
    public partial class ScoreForm : Form
    {
        public static int maxStudent = 10;

        Student[] students = new Student[maxStudent];


        public ScoreForm()
        {
            InitializeComponent();
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            txtCsCredit1.Text = Credit.Cs.ToString();
            txtOopCredit1.Text = Credit.Oop.ToString();
            txtHtmlCredit1.Text = Credit.Html.ToString();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int  id = int.Parse(txtId.Text); 
            string name = txtName.Text;
            int  cs  = int.Parse(txtCs.Text);
            int oop = int.Parse(txtOop.Text);
            int html = int.Parse(txtHtml.Text);

            students[Student.count]= new Student(id, name, cs, oop, html);

            if(Student.count > maxStudent ) {

                return;
            }

            cbId.Items.Add(students[Student.count].Id);

            Student.count++;



        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choiceIndex = cbId.SelectedIndex;
            int cs = students[choiceIndex].Cs;
            int oop = students[choiceIndex].Oop;
            int html = students[choiceIndex].Html;  


            txtNameOutput.Text = students[choiceIndex].Name;
            txtScoreCs.Text =cs.ToString();
            txtScoreOop.Text = oop.ToString();
            txtScoreHtml.Text = html.ToString();


            txtCsCredit2.Text = Student.GetPoint(cs).ToString(); 
            txtOopCredit2.Text = Student.GetPoint(oop).ToString();
            txtHtmlCredit2.Text = Student.GetPoint(html).ToString();

            txtGradeCs.Text = Student.GetGrade(cs);
            txtGradeOop.Text = Student.GetGrade(oop);
            txtGradeHtml.Text = Student.GetGrade(html);

            calculateGPA(double.Parse(txtCsCredit2.Text), double.Parse(txtOopCredit2.Text), double.Parse(txtHtmlCredit2.Text));

        }

        private void calculateGPA(double cs, double oop, double html)
        {
            double totalCredit = cs + oop + html;

            txtGpa.Text = (totalCredit / 3.0).ToString();
            


        }
    
    }
}
