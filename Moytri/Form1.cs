using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moytri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comb = comboBox1.Text;
            //  MessageBox.Show(comb);

            if (string.Compare(comb, "Normal Map") == 0)
            {

                web.Navigate("C:\\Users\\Klayton\\documents\\visual studio 2015\\Projects\\Moytri\\Moytri\\HTML\\main.html");
                //web.Navigate(@"\\HTML\\main.html");
            }


            else if(string.Compare(comb, "Sattelite Map")==0) {


                web.Navigate("C:\\Users\\Klayton\\documents\\visual studio 2015\\Projects\\Moytri\\Moytri\\HTML\\main_sattelite.html");


            }

            else if(string.Compare(comb,"Terrain Map") == 0)
            {
                web.Navigate("C:\\Users\\Klayton\\documents\\visual studio 2015\\Projects\\Moytri\\Moytri\\HTML\\main_terrain.html");



            }

            else if(string.Compare(comb, "Hybrid Map") == 0)
            {


                web.Navigate("C:\\Users\\Klayton\\documents\\visual studio 2015\\Projects\\Moytri\\Moytri\\HTML\\main_hybrid.html");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            web.Navigate("C:\\Users\\Klayton\\documents\\visual studio 2015\\Projects\\Moytri\\Moytri\\HTML\\main.html");
        }


        private void btn_no_fly_Click(object sender, EventArgs e)
        {
            web.Navigate("C:\\Users\\Klayton\\documents\\visual studio 2015\\Projects\\Moytri\\Moytri\\HTML\\nofly.html");

            MessageBox.Show("Warning!! No Fly Zone Ahead");
        }

        private void btn_weather_Click(object sender, EventArgs e)
        {
            web.Navigate("localhost\\hello\\weatherff.html");
        }

        private void btn_electric_Click(object sender, EventArgs e)
        {
            web.Navigate("C:\\Users\\Klayton\\documents\\visual studio 2015\\Projects\\Moytri\\Moytri\\HTML\\tower.html");
        }

        private void btn_vegetation_Click(object sender, EventArgs e)
        {
            web.Navigate("C:\\Users\\Klayton\\documents\\visual studio 2015\\Projects\\Moytri\\Moytri\\HTML\\vegetation.html");
        }

        private void btn_terrain_Click(object sender, EventArgs e)
        {
            web.Navigate("C:\\Users\\Klayton\\documents\\visual studio 2015\\Projects\\Moytri\\Moytri\\HTML\\terrain.html");
        }
    }
}
