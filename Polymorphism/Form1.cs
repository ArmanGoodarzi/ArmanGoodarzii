using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle car = new Car();
            car.Drive();
            Vehicle bike = new Bike();
            bike.Drive();
        }
    }
    public class Vehicle 
    {
        public virtual void Drive()
        {
            MessageBox.Show("Driving");
        }
    }
    public class Car : Vehicle
    {
        public override void Drive()
        {
            MessageBox.Show("Driving fast");
        }
    }
    public class Bike : Vehicle
    {
        public override void Drive()
        {
            MessageBox.Show("Pedal");
        }
    }
}
