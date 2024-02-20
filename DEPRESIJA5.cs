using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace depresija_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void gridas_izmaksa(double cena, int linoleja_platums, int telpas_platums, int telpas_garums)
        {
            int telpas_izmers = telpas_garums * telpas_platums;
            double izmaksa = cena * telpas_izmers / linoleja_platums;
        }
    }
}
