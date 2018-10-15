using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1:
            //Realiza una clase finanzas que convierta dólares a euros y viceversa. Codifica los métodos dolaresToEuros y eurosToDolares.
            //Prueba que dicha clase funciona correctamente haciendo conversiones entre euros y dólares.
            //La clase tiene que tener:
            //Un constructor finanzas() por defecto, el cual establecerá el cambio Dólar - Euro en 0.92.
            //Un constructor finanzas(double), el cual permitirá configurar el cambio dólar - euro.

            //crear objetos sin parametros
            Finanzas f1 = new Finanzas();
            f1.Setcambio(0.92);
            Console.WriteLine("5 Euros son: " + f1.EurosToDolares(5) + " dolares.");
            Console.WriteLine("5 Dolares son: " + f1.DolaresToEuros(5) + " dolares.");

            Console.ReadLine();
        }
    }
}
