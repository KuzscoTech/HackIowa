using Crop_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Framework
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            userControlCrops C = userControlCrops1;
            userControlNews N = userControlNews1;
            userControlWeather W = userControlWeather1;

            userControlWeather1.Hide();
            userControlCrops1.Hide();
            userControlNews1.Hide();
        }

        private void btnCrops_Click(object sender, EventArgs e)
        {

            userControlWeather1.Hide();
            userControlCrops1.Show();
            userControlNews1.Hide();
        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            userControlWeather1.Hide();
            userControlCrops1.Hide();
            userControlNews1.Show();
        }

        private void btnCrops_Click_1(object sender, EventArgs e)
        {
            userControlWeather1.Hide();
            userControlCrops1.Show();
            userControlNews1.Hide();
        }

        private void btnNews_Click_1(object sender, EventArgs e)
        {
            userControlWeather1.Hide();
            userControlCrops1.Hide();
            userControlNews1.Show();
        }

        private void btnWeather_Click(object sender, EventArgs e)
        {
            userControlWeather1.Show();
            userControlCrops1.Hide();
            userControlNews1.Hide();
        }
    }
}
