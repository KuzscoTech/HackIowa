using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Crop_Models;

namespace UI_Framework
{
    public partial class userControlCrops : UserControl
    {
        public userControlCrops()
        {
            InitializeComponent();
        }

        private void userControlCrops_Load(object sender, EventArgs e)
        {

        }

        public void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnRice_Click(object sender, EventArgs e)
        {
            Rice r = new Rice();

            lblInfo.Text = (r.EconInfo());
            lblPlantInfo.Text = (r.PlantingInfo());

        }

        private void btnWheat_Click(object sender, EventArgs e)
        {
            Wheat w = new Wheat();

            lblInfo.Text = (w.EconInfo());
            lblPlantInfo.Text = (w.PlantingInfo());
        }

        private void btnCotton_Click(object sender, EventArgs e)
        {
            Cotton c = new Cotton();
            lblInfo.Text = (c.EconInfo());
            lblPlantInfo.Text = (c.PlantingInfo());
        }

        private void btnCorn_Click(object sender, EventArgs e)
        {
            Corn co = new Corn();
            lblInfo.Text = (co.EconInfo());
            lblPlantInfo.Text = (co.PlantingInfo());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCost_Click(object sender, EventArgs e)
        {
            Rice r1 = new Rice();
            Wheat w1 = new Wheat();
            Cotton c1 = new Cotton();
            Corn co1 = new Corn();

            string CropName = txtCrop.Text;
            

            string str = Convert.ToString(txtAcres.Text);
            int Acres; bool correctEntry = int.TryParse(str, out Acres);

            if (correctEntry == true)
            {
                if (Acres > 0)
                {

                    if (CropName == "Rice")
                    {
                        double RiceCost = r1.CostCalculator(Acres);
                        lblCost.Text = RiceCost.ToString("C2");
                    }

                    else if (CropName == "Wheat")
                    {
                        double WheatCost = w1.CostCalculator(Acres);
                        lblCost.Text = WheatCost.ToString("C2");
                    }
                    else if (CropName == "Corn")
                    {
                        double CornCost = c1.CostCalculator(Acres);
                        lblCost.Text = CornCost.ToString("C2");
                    }
                    else if (CropName == "Cotton")
                    {

                        double CottonCost = co1.CostCalculator(Acres);
                        lblCost.Text = CottonCost.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Please enter one of the four crops.");
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Entry");
                }
            }
            else
            {
                MessageBox.Show("Invalid Entry");
            }

        }

        private void lblReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Rice r1 = new Rice();
            Wheat w1 = new Wheat();
            Cotton c1 = new Cotton();
            Corn co1 = new Corn();

            string CropName = txtCrop.Text;


            string str = Convert.ToString(txtAcres.Text);
            int Acres; bool correctEntry = int.TryParse(str, out Acres);

            if (correctEntry == true)
            {
                if (Acres > 0)
                {

                    if (CropName == "Rice")
                    {
                        double RiceCost = r1.ReturnCalculator(Acres);
                        lblReturn.Text = RiceCost.ToString("C2");
                    }

                    else if (CropName == "Wheat")
                    {
                        double WheatCost = w1.ReturnCalculator(Acres);
                        lblReturn.Text = WheatCost.ToString("C2");
                    }
                    else if (CropName == "Corn")
                    {
                        double CornCost = c1.CostCalculator(Acres);
                        lblReturn.Text = CornCost.ToString("C2");
                    }
                    else if (CropName == "Cotton")
                    {
                        double CottonCost = co1.CostCalculator(Acres);
                        lblReturn.Text = CottonCost.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Please enter one of the four crops.");
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Entry");
                }
            }
            else
            {
                MessageBox.Show("Invalid Entry");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAcres.Clear();
            txtCrop.Clear();
            lblPlantInfo.Text = "";
            lblInfo.Text = "";
            lblCost.Text = "";
            lblReturn.Text = "";
        }

        private void lblCost_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
