using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mittaimet
{
    internal class Sensoriryhma
    {
        double[] tulokset = new double[4];
        int i = 0;
        public double maxValue;
        public double minValue;
        public double average;

        public void Lisaus(Sensori zen)
        {
            tulokset[i] = zen.Lampo;
            i += 1;
            if (i > 3)
                {
                i = 0;
                }
        }

        public void Suurin()
        {
            maxValue = tulokset.Max();
        }

        public void Pienin()
        {
            minValue = tulokset.Min();
        }
        public void Keskiarvo()
        {
            average = tulokset.Average();
        }

    }
}