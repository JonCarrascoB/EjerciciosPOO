using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea la clase coche con dos constructores. Uno no toma parámetros y el otro sí. Los dos constructores inicializarán 
            //los atributos marca y modelo de la clase.
            //Implementa métodos para obtener y establecer el valor de los atributos, así como un método para mostrar toda la información.
            //Crea dos objetos(cada objeto llama a un constructor distinto) y verifica que todo funciona correctamente.

            Coche co1 = new Coche();
            co1.Setmarca("Ford");
            co1.Setmodelo("Fiesta");

            Console.WriteLine("La marca del coche es: " + co1.Getmarca());
            Console.WriteLine("La modelo del coche es: " + co1.Getmodelo());
            //co1.inform();

            Consumo con1 = new Consumo();
                con1.SetKilometros(360);
                con1.SetLitros(200);
                con1.SetVmedia(100);
                con1.SetCombustible("DIESEL");

                con1.MostrarDatos();

            Console.ReadLine();
        }
    }
}
