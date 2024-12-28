using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator add = new Calculator();   
            label3.Text = add.Add(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculator subtract = new Calculator();
            label4.Text = subtract.Subtract(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
        }
    }
    interface IOperations
    {
        double Add();
        double Subtract();
    }

    public class Calculator
    {
        public double Add(double a , double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
    }
}
