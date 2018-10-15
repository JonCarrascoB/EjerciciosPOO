using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deberá tener un atributo donde se almacene el peso de un objeto en kilogramos.
            //En el constructor se le pasará el peso y la medida en la que se ha tomado(‘Lb’ para libras, ‘Li’ para lingotes,
            //‘Oz’ para onzas, ‘P’ para peniques, ‘K’ para kilos, ‘G’ para gramos y ‘Q’ para quintales).
            //Deberá de tener los siguientes métodos:
            //GetLibras.Devuelve el peso en libras.
            //GetLingotes.Devuelve el peso en lingotes.
            //GetPeso.Devuelve el peso en la medida que se pase como parámetro(‘Lb’ para libras, ‘Li’ para lingotes,
            //‘Oz’ para onzas, ‘P’ para peniques, ‘K’ para kilos, ‘G’ para gramos y ‘Q’ para quintales).
            //Para la realización del ejercicio toma como referencia los siguientes datos:
            //1 Libra = 16 onzas = 453 gramos.
            //1 Lingote = 32,17 libras = 14,59 kg.
            //1 Onza = 0,0625 libras = 28,35 gramos.
            //1 Penique = 0,05 onzas = 1,55 gramos.
            //1 Quintal = 100 libras = 43,3 kg.
            //Crea además un método main para testear y verificar los métodos de esta clase

            int peso = 5;
            String tipo = "LB";
            Peso p1 = new Peso(peso, tipo);
            //Console.WriteLine(p1.GetPeso(p1.GetKg(), "lb"));
            Console.WriteLine(peso + " " + tipo + " = " + p1.GetKg() + "kg");
            Console.WriteLine(p1.GetKg() + "kg =" + p1.GetPeso("lb") + " libras");
            Console.ReadLine();
        }
        
    }
}
