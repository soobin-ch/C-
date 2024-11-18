using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicianManagerWin
{
    

    public partial class Form1 : Form
    {


        Musician musician;
        public Form1()
        {
            InitializeComponent();
        }

        private void cbCreateUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCreateUnit.SelectedIndex <0)
            {
                MessageBox.Show("음악가를 선택해주세요");
                return;
            }

            switch(cbCreateUnit.SelectedIndex)
            {

                case 0:
                    musician = new Pianist(0,"피아니스트");
                    break;
                case 1:
                    musician = new Drummer(1, "드러머");
                    break;
                case 2:
                    musician = new Guitarist(2, "기타리스트");
                    break;
                case 3:
                    musician = new Vocal(3,"보컬");
                    break;
            }

            pictureBox1.Image = imageList1.Images[musician.IImgNo];
        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            lblResult.Text = musician.introduce();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            lblResult.Text = musician.Play();
        }
    }
}
