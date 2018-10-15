using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realiza una clase número que almacene un número entero y tenga las siguientes características:
            //Constructor por defecto que inicializa a 0 el número interno.
            //Constructor que inicializa el número interno.
            //Método añade que permite sumarle un número al valor interno.
            //Método resta que resta un número al valor interno.
            //Método getValor. Devuelve el valor interno.
            //Método getDoble. Devuelve el doble del valor interno.
            //Método getTriple. Devuelve el triple del valor interno.
            //Método setNumero. Inicializa de nuevo el valor interno.

            Numero n1 = new Numero();
            n1.Setnumero(45);
            
            Console.WriteLine("La suma del numero es: " + n1.Añade(10));
            Console.WriteLine("La resta del numero es: " + n1.Resta(10));
            Console.WriteLine("El valor del numero es: " + n1.Getvalor());
            Console.WriteLine("El Doble del numero es: " + n1.GetDoble());
            Console.WriteLine("El triple del numero es: " + n1.GetTriple());
            Console.WriteLine("El numero es: " + n1.Restart());

            Console.ReadLine();
        }
    }
}
