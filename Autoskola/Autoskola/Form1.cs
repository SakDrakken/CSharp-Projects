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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            performRefresh();           
        }

        
        public int cisloOtazky = 1;
        public int pocetOtazekMIN = 1;
        public int pocetOtazekMAX = 30;
        public string[] otazky = {"Nultá otázka.","První otázka.", "Druhá otázka.","Třetí otázka." };
        public string[,] odpovedi = { {"null", "null", "null", "null" }, {"a","b","c","d" }, { "e", "f", "g", "h" }, { "i", "j", "k", "l" }, { "m", "n", "o", "p" } };
        public int casStraven = 0;
        public static string casTestu = "0 : 00";

        private void button1_Click(object sender, EventArgs e)
        {
            if (cisloOtazky > pocetOtazekMIN)
            {
                cisloOtazky--;
                pBar1.Step = -10;
                pBar1.PerformStep();
                pBar1.Step = 10;
            }
            else
                cisloOtazky = pocetOtazekMIN;
            performRefresh();            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cisloOtazky < pocetOtazekMAX)
            {
                cisloOtazky++;
            pBar1.PerformStep();
            }
            else
                cisloOtazky = pocetOtazekMAX;
            performRefresh();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void performRefresh()
        {
            pBCisloOtazky.Text = Convert.ToString(cisloOtazky);
            blokOtazky.Text = "Otázka " + Convert.ToString(cisloOtazky);
            textOtazky.Text = Convert.ToString(otazky[cisloOtazky]);
            butA.Text = odpovedi[cisloOtazky,0];
            butB.Text = odpovedi[cisloOtazky, 1];
            butC.Text = odpovedi[cisloOtazky, 2];

        }

        private void button7_Click(object sender, EventArgs e)
        {
            vyhodnotitCas();
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            casStraven++;
        }

        public void vyhodnotitCas()
        {
            int casMinuty = casStraven / 60;
            int casVteriny = casStraven % 60;
            casTestu = casMinuty + " : " + casVteriny;
        }
    }
}
