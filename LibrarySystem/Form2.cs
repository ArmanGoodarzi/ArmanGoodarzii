using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.title = textBox1.Text;
            b.author = textBox2.Text;
            b.ISBN = int.Parse(textBox3.Text);
            b.year = int.Parse(textBox4.Text);
            b.showInfo();
        }
    }
    public class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public int ISBN { get; set; }
        public int year { get; set; }

        public void showInfo()
        {
            MessageBox.Show($"Title : {title},Author : {author},ISBN : {ISBN},Year : {year}");
        }
    }
    
}
