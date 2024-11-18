using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07HashTableApp
{
    public partial class StudentInfoForm : Form
    {
        Hashtable Students = new Hashtable();
        public StudentInfoForm()
        {
            


            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Students.Add(txtId.Text, txtName.Text);
            cboSelect.Items.Add(txtId.Text);

            txtId.Text = "";
            txtName.Text = "";

        }

        private void cboSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
           lblId.Text = cboSelect.SelectedItem.ToString();
            lblName.Text = Students[cboSelect.SelectedItem.ToString()].ToString();

        }
    }
}
