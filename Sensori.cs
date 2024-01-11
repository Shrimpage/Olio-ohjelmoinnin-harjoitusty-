using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mittaimet
{
    
    public class Sensori
    {


        public double Lampo;
        public DateTime Aika;
        public double Tulos;
        public DateTime DT;

        public Random Rnd { get; private set; }

        public Sensori()
        {
            Lampo = 0;
            Rnd = new Random();
        }

        public void Mittaus()
        {
            Lampo = Rnd.NextDouble();
            Lampo = Math.Round(Lampo , 1);
            Lampo += Rnd.Next(-30, 30);
            Aika = DateTime.Now;
            string s = string.Format("{0:0.00}", Lampo);
            File.AppendAllText("Mittaukset.txt",Environment.NewLine + s);
            string a = Aika.ToString();
            File.AppendAllText("Ajat.txt", Environment.NewLine + a);
        }

        public void Luku()
        {
            string l = File.ReadLines("Mittaukset.txt").Last();
            Tulos = Convert.ToDouble(l);
            string d = File.ReadLines("Ajat.txt").Last();
            DT = Convert.ToDateTime(d);
        }

        public void Tyhjennys()
        {
            File.Delete("Mittaukset.txt");
            File.Delete("Ajat.txt");
        }
        public string Teksti()
        {
            return $"{Tulos}°Celsiusta";
        }
    
    }
}
