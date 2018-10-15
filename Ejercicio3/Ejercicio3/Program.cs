using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Modifica la clase satélite y añádele los siguientes métodos:
            //Método void VariaAltura(double desplazamiento): Este método acepta un parámetro que será positivo o negativo 
            //dependiendo de si el satélite tiene que alejarse o acercarse a La Tierra.
            //Método boolean EnOrbita(): Este método devolverá false si el satélite está en tierra, y true en caso contrario.
            //Método void VariaPosicion(double variap, double variam): Este método permite modificar los atributos de posición
            //(meridiano y paralelo) mediante los parámetros variap y variam. Estos parámetros serán valores positivos 
            //o negativos relativos que harán al satélite modificar su posición.

            Satelite sat1 = new Satelite();
            sat1.SetPosicion(66, 23, 36000);

            
            sat1.VariarAltura(-560);
            Console.WriteLine(sat1.EnOrbita());
            sat1.VariaPosicion(20,-36);
            sat1.PrintPosicion();

            Console.ReadLine();
        }
    }
}
