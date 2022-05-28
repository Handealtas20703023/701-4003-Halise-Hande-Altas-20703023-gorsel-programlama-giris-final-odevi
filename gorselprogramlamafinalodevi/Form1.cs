using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselprogramlamafinalodevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kontrol11.Show();
            kontrol21.Hide();
            kontrol31.Hide();
            kontrol11.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kontrol21.Hide();
            kontrol31.Hide();
            kontrol11.Show();
            kontrol11.BringToFront();



        }

        private void kontrol11_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kontrol11.Hide();
            kontrol21.Hide();
            kontrol31.Show();
            kontrol31.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kontrol11.Hide();
            kontrol31.Hide();
            kontrol21.Show();
            kontrol21.BringToFront();

        }

        private void kontrol31_Load(object sender, EventArgs e)
        {
            
        }
    }
}
