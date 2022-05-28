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
    public partial class kontrol2 : UserControl
    {
        public kontrol2()
        {
            InitializeComponent();
        }

        private void kontrol2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adresiniz başarıyla kaydedildi!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz alınmiştir, bizi tercih ettiğiniz için teşekkür ederiz!");
        }
    }
}
