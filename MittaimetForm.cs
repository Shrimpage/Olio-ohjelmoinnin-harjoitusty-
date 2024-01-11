using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mittaimet
{
    public partial class MittaimetForm : Form
    {
        Sensori sensori;
        Sensoriryhma sryhma;
        public List<Sensori> sensoriList;
        public MittaimetForm()
        {
            InitializeComponent();
            sensori = new Sensori();
            sryhma = new Sensoriryhma();
            sensoriList = new List<Sensori> { sensori };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            sensori.Mittaus();
            sensori.Luku();
            sensoriList.Add(sensori);
            sryhma.Lisaus(sensori);
            lblsensori1.Text = sensori.Teksti();
            lblYsensori1.Text = sensori.Teksti();
            lblTime1.Text = Convert.ToString(sensori.Aika);

            sensori.Mittaus();
            sensori.Luku();
            sryhma.Lisaus(sensori);
            lblsensori2.Text = sensori.Teksti();
            lblYsensori2.Text = sensori.Teksti();
            lblTime2.Text = Convert.ToString(sensori.Aika);

            sensori.Mittaus();
            sensori.Luku();
            sryhma.Lisaus(sensori);
            lblsensori3.Text = sensori.Teksti();
            lblYsensori3.Text = sensori.Teksti();
            lblTime3.Text = Convert.ToString(sensori.Aika);

            sensori.Mittaus();
            sensori.Luku();
            sryhma.Lisaus(sensori);
            lblsensori4.Text = sensori.Teksti();
            lblYsensori4.Text = sensori.Teksti();
            lblTime4.Text = Convert.ToString(sensori.Aika);

            lblAjat.Text = Convert.ToString(sensori.Aika);
            sryhma.Suurin();
            lblsuurin.Text = Convert.ToString(sryhma.maxValue);
            sryhma.Pienin();
            lblpienin.Text = Convert.ToString(sryhma.minValue);
            sryhma.Keskiarvo();
            lblkeskiarvo.Text = Convert.ToString(sryhma.average);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            sensori.Tyhjennys();
        }
    }
}
