using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

        double tan(double x)
        {
            return (Math.Tan(x * Math.PI / 180.0));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //declare variables for force and angles
            double Force, Angle;

            //Read values from text box, parse - make the numbers be read as numbers not individual figures.
            try
            {
                Force = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Type a number in the force box");
                Force = 0.0;
            }

                Angle = double.Parse(textBox2.Text);
                

            // calculate Fx and Fy 
            double Fx = Force * cos(Angle);
            double Fy = Force * sin(Angle);

            //put values for Fx and Fy in labels
            label1.Text = "Fx =  " + Fx + "N";
            label2.Text = "Fy =  " + Fy + "N";
        }
    }
}
