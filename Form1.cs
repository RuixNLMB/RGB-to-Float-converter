using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace adsggasagsd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num1, ans;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            textBox1.Text = textBox1.Text;


            double txt1 = Convert.ToDouble(textBox1.Text);

            double hex = 255;

            double txt2 = Convert.ToDouble(textBox2.Text);

            double txt3 = Convert.ToDouble(textBox3.Text);

            double division = txt1 / hex;
            double division2 = txt2 / hex;
            double division3 = txt3 / hex;

            textBox6.Text = division.ToString();
            textBox5.Text = division2.ToString();
            textBox4.Text = division3.ToString();




        }
    }
}
