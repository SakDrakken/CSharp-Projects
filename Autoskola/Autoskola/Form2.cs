using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoskola
{
    public partial class Form2 : Form
    {
        public Form2()
        {           
            InitializeComponent();
            label4.Text = casTestu;
            performRefresh();
        }

        public int pocetChyb = 0;
        public int pocetBodu = 0;

        public string casTestu
        {
            get { return Form1.casTestu; } 
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void performRefresh()
        {
            label2.Text = pocetBodu + " z 50";
            label3.Text = pocetChyb + " z 25";
        }
    }
}
