using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddclick(object sender, EventArgs e)
        {
            
       
            MyCalcService.WebService1SoapClient client = new MyCalcService.WebService1SoapClient();
            textBox3.Text = client.Addition(Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(textBox2.Text)).ToString();


        
        }

        private void btnSubClick(object sender, EventArgs e)
        {

            MyCalcService.WebService1SoapClient client = new MyCalcService.WebService1SoapClient();
            textBox3.Text = client.Subtract(Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(textBox2.Text)).ToString();
        }

        private void btnDivClick(object sender, EventArgs e)
        {

            MyCalcService.WebService1SoapClient client = new MyCalcService.WebService1SoapClient();
            textBox3.Text = client.Division(Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(textBox2.Text)).ToString();
        }

        private void btnMulClick(object sender, EventArgs e)
        {

            MyCalcService.WebService1SoapClient client = new MyCalcService.WebService1SoapClient();
            textBox3.Text = client.Multiplication(Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(textBox2.Text)).ToString();
        }

        private void btnModClick(object sender, EventArgs e)
        {

            MyCalcService.WebService1SoapClient client = new MyCalcService.WebService1SoapClient();
            textBox3.Text = client.Modules(Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(textBox2.Text)).ToString();
        }
    }
}
