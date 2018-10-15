using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    class Finanzas
    {
        //private double dinero;
        private double cambio;
        

        public Finanzas ()
        {
            cambio = 0.92;
        }
        public Finanzas (double cambio)
        {
            this.cambio = cambio;
            
            
        }

        //metodos get y set
        //public double Getdinero()
        //{

        //    return dinero;

        //}
        //public void Setdinero(double dinero)
        //{

        //    this.dinero = dinero;

        //}
        public double Getcambio()
        {

            return cambio;

        }
        public void Setcambio(double cambio)
        {

            this.cambio = cambio;

        }
        

        

        //metodos cambio
        public double DolaresToEuros (double cantidad)
        {
            return cantidad * cambio;
        }
        
        public double EurosToDolares (double cantidad)
        {
            return cantidad/cambio;
        }
    }
}
