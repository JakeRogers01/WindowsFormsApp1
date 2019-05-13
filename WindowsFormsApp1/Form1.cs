using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 25, pictureBox1.Location.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 25, pictureBox1.Location.Y);
        }

    }
}
    
