using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void userWeather1_Load(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            userCrops C = userCrops2;
            userNews N = userNews2;
            userWeather W = userWeather2;

            C.Hide();
            N.Hide();
            W.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userCrops C = userCrops2;
            userNews N = userNews2;
            userWeather W = userWeather2;

            C.Hide();
            N.Show();
            W.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userCrops C = userCrops2;
            userNews N = userNews2;
            userWeather W = userWeather2;

            C.Hide();
            N.Hide();
            W.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userCrops C = userCrops2;
            userNews N = userNews2;
            userWeather W = userWeather2;

            C.Show();
            N.Hide();
            W.Hide();
        }
    }
}
