using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_InheritanceWindowsApp
{
    public partial class InheritanceForm : Form
    {
        string sFigFilename = "";
        const int I_MAX_OBJ = 10;
        int iCnt = -1;
        Vehicle[] myVehicle = new Vehicle[I_MAX_OBJ];
        public InheritanceForm()
        {
            InitializeComponent();
        }
        private void btnInputFig_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                if (filename == null) return;
                sFigFilename = filename;
            }
        }
        private void cbSelectObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbType.SelectedIndex.ToString())
            {
                case "승용차":
                    lblAuxName.Text = "승차인원 : ";
                    txtAux.Text = "5";
                    break;
                case "버스":
                    lblAuxName.Text = "승객수 : ";
                    txtAux.Text = "45";
                    break;
                case "트럭":
                    lblAuxName.Text = "적재정량 : ";
                    txtAux.Text = "5";
                    break;
                default: break;
            }

            switch(myVehicle[cbSelectObject.SelectedIndex].sType)
            {
                case "승용차":
                    lblAuxInfo.Text = "승차인원 : ";
                    Car mCar = (Car)myVehicle[cbSelectObject.SelectedIndex];
                    lblAux.Text = mCar.iMaxSeats.ToString() + "명";
                    break;
                case "버스":
                    lblAuxInfo.Text = "승객수 : ";
                    Bus mBus = (Bus)myVehicle[cbSelectObject.SelectedIndex];
                    lblAux.Text = mBus.iMaxPassengers.ToString() + "명";
                    break;
                default:
                    lblAuxInfo.Text = "승객수 : ";
                    Truck mTruck = (Truck)myVehicle[cbSelectObject.SelectedIndex];
                    lblAux.Text = mTruck.iMaxCargo.ToString();
                    break;
            }

            pcMain.Image = new Bitmap(myVehicle[cbSelectObject.SelectedIndex].sPictureFilename);
            lblType.Text = myVehicle[cbSelectObject.SelectedIndex].sType;
            lblMaker.Text = myVehicle[cbSelectObject.SelectedIndex].sMaker;
            lblPrice.Text = (myVehicle[cbSelectObject.SelectedIndex].iPrice / 10000).ToString() + "만원";
        }
        private void btnCreateObject_Click(object sender, EventArgs e)
        {
            if (sFigFilename == "")
            {
                MessageBox.Show("그림 파일을 선택하세요.");
                return;
            }
            iCnt++;
            if (iCnt >= I_MAX_OBJ) return;
            
            string sType = cbType.SelectedItem.ToString();
            string sMaker = cbMaker.SelectedItem.ToString();
            string sColor = cbColor.SelectedItem.ToString();
            int iPrice = int.Parse(txtPrice.Text);
            int iAux = int.Parse(txtAux.Text);

            switch (cbType.SelectedItem.ToString()) 
            {
                case "승용차":
                    myVehicle[iCnt] = new Car(sType, sMaker, sColor, iPrice, sFigFilename, iAux);
                    break;
                case "버스":
                    myVehicle[iCnt] = new Bus(sType, sMaker, sColor, iPrice, sFigFilename, iAux);
                    break;
                case "트럭":
                    myVehicle[iCnt] = new Truck(sType, sMaker, sColor, iPrice, sFigFilename, iAux);
                    break;
                default: break;
            }

            cbSelectObject.Items.Add(iCnt);
            sFigFilename = "";
        }
    }
}
