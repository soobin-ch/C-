﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWindows2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblResult.Text = "안녕하세요, c# 프로그래밍";
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

   
    }
}
