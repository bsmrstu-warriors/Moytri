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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            web.ObjectForScripting = true;
            web.ScriptErrorsSuppressed = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            web.Navigate("localhost\\hello\\weatherff.html");
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            web.Navigate("C:\\Users\\Klayton\\documents\\visual studio 2015\\Projects\\Moytri\\Moytri\\HTML\\electricpole.html");
           // web.Navigate("www.google.com");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            web.ScriptErrorsSuppressed = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            web.Navigate("www.google.com");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            web.Navigate("C:\\Users\\Klayton\\documents\\visual studio 2015\\Projects\\Moytri\\Moytri\\HTML\\vegetation2.html");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            web.Navigate("C:\\Users\\Klayton\\documents\\visual studio 2015\\Projects\\Moytri\\Moytri\\HTML\\circle.html");
        }
    }
}
