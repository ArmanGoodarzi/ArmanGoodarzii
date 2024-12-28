using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.Brand = textBox1.Text;
            c.Speed = int.Parse(textBox2.Text);
            c.infoMethod();
        }
    }
    public class Car
    {
        
        private string brand;
        private int speed;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        
        public int Speed
        {
            
            get { return speed; }
            
            set { 
                if (value >= 0 && value <= 290) 
                    speed = value;
                else
                    MessageBox.Show("Speed must be between 0 and 240.");                
            }
        }
        public void infoMethod()
        {
            MessageBox.Show($"Brand:{brand},Speed:{speed}");
        }
    }
    
}
