using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentti_tehtava2
{
    class Piste
    {
        public string Nimi { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Piste()
        {

        }
        public Piste(string nimi, double x, double y)
        {
            this.Nimi = nimi;
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return Nimi + "\n" + X + "\n" + Y+"\n";
        }
    }
}
