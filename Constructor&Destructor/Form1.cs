using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor_Destructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car c = new Car(textBox1.Text,int.Parse(textBox2.Text));
            
        }
    }
    public class Car
    {
        private string brand { get; set; }
        private int speed { get; set; }

        public Car(string Brand , int Speed )
        {
            brand = Brand;
            speed = Speed;
        }
        ~Car()
        {
            MessageBox.Show($"Brand : {brand},Speed : {speed}");   
        }
    }
}
