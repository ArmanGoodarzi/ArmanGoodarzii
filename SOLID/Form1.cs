using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(double.Parse(textBox1.Text),double.Parse(textBox2.Text));
            label4.Text = r.calculateArea().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Circle c = new Circle(double.Parse(textBox3.Text));
            label5.Text = c.calculateArea().ToString();
        }
    }
    interface IShape
    {
        double calculateArea();  
    }
    public class Circle : IShape
    {
        public double radius { get; set; }
        public Circle(double Radius)
        {
            radius = Radius;
        }
        public double calculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
    public class Rectangle : IShape
    {
        public double height { get; set; }
        public double width { get; set; }

        public Rectangle(double Height,double Width)
        {
            height = Height;
            width = Width;
        }
        public double calculateArea()
        {
            return height * width;
        }
    }
    
}
