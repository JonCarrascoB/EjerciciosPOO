using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Millas
    {
        private double millas;

        public Millas()
        {

        }

        public Millas(double millas)
        {
            this.millas = millas;
        }

        public double Getmillas()
        {
        return millas;
        }
        public void Setmillas(double millas)
        {
            this.millas = millas;
        }

        public double MillasAMetros()
        {
            return millas * 1852;
        }
        public double MillasAKilometros()
        {
            return (millas * 1852)/1000;
        }

    }
}
