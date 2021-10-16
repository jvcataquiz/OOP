using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = "Jerick Vegile M. Cataquiz";
            string title = "Fullname:";
            MessageBox.Show(Name, title);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string course = "BSCOE 5-1D";
            string txttitle = "Course:";
            MessageBox.Show(course, txttitle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
