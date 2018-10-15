using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea una clase con un método MillasAMetros() que toma como parámetro de entrada un valor en millas marinas y 
            //las convierte a metros.
            //Una vez tengas este método escribe otro MillasAKilometros() que realice la misma conversión, pero esta vez 
            //exprese el resultado en kilómetros.
            //Nota: 1 milla marina equivale a 1852 metros.

            Millas m1 = new Millas();
            m1.Setmillas(56);

            Console.WriteLine(m1.Getmillas() + "millas marinas = " + m1.MillasAMetros() + " metros");
            Console.WriteLine(m1.Getmillas() + "millas marinas = " + m1.MillasAKilometros() + " Kilometros");
            Console.ReadLine();

        }
    }
}
