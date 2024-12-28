using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract
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
            c.Move();
            Bicycle b = new Bicycle();
            b.Move();
        }
    }
    public abstract class Vehicle
    {
        public abstract void Move();
    }
    public class Car : Vehicle
    { 
        public override void Move()
        {
            MessageBox.Show("Gassing the car");
        }
    }
    public class Bicycle : Vehicle
    {
        public override void Move()
        {
            MessageBox.Show("Pedaling the bicycle");
        }
    }
}
