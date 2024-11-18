using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalSounds
{
    public partial class ChallengeForm : Form
    {

        string sPicture = "";
        Animal animal;

        public ChallengeForm()
        {
            InitializeComponent();
        }

        private void btnGetPhoto_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                if(filename == null)
                {
                    return;
                }
                sPicture = filename;
            }
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if(cbType.SelectedIndex < 0) {

                MessageBox.Show("동물을 선택해주세요");
                return;
            }
            if(sPicture =="")
            {
                MessageBox.Show("그림파일을 선택해주세요");
                return;
            }

            string name = cbType.SelectedItem.ToString();

            switch (cbType.SelectedIndex)
            {
                case 0:
                    animal = new Alien(name, sPicture); break;
                case 1:
                    animal = new Cat(name, sPicture); break;
                case 2:
                    animal = new Dog(name, sPicture); break;
                case 3:
                    animal = new Duck(name, sPicture); break; 
            }

            lblType.Text = name;
            lblSpeak.Text = animal.Speak();
            pbMain.Image = new Bitmap(animal.SPicture);
        }
    }
}
