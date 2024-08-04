using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConvertBtn(object sender, EventArgs e)
        {
            string selectedScale = DropDown.SelectedItem.ToString();

            double temp;
            
            if (double.TryParse(ValueText.Text, out temp))
            {
                TempConverter.WebService1SoapClient client = new TempConverter.WebService1SoapClient();

             
                if (selectedScale == "Celsius")
                {
              
                    Final.Text = client.FarenhietToCelsius(temp).ToString();
                }
                else if (selectedScale == "Farenhiet")
                {
                 
                    Final.Text = client.CelsiusToFarenhiet(temp).ToString();
                }
            }
        }
            private void ClearBtn(object sender, EventArgs e)
            {
            ValueText.Clear();
            DropDown.SelectedIndex = 0;
            Final.Clear();
            

            }
    }
}
