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
    public partial class Form1 : Form
    {
        Form2 f = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member m = new Member();
            m.firstName = textBox5.Text;
            m.lastName = textBox6.Text;
            m.phoneNumber = int.Parse(textBox7.Text);
            m.memberId = int.Parse(textBox8.Text);
            m.showInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (f.IsDisposed == true)
            {
                f = new Form2();
            }
            f.Show();
        }
    }
    public class Member
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int phoneNumber { get; set; }
        public int memberId { get; set; }

        public void showInfo()
        {
            MessageBox.Show($"First Name : {firstName},Last Name : {lastName},Phone Number : {phoneNumber},Member ID : {memberId}");
        }
    }
}
