using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Consumo
    {
        private double kilometros;
        private double litros;
        private double vmedia;
        private string combustible;

        public Consumo()
        {
            kilometros = 100;
            litros = 10;
            vmedia = 110;
            combustible = "GASOLINA 98";
        }

        public Consumo(double kilometros, double litros, double vmedia, string combustible)
        {
            this.kilometros = kilometros;
            this.litros = litros;
            this.vmedia = vmedia;
            this.combustible = combustible;
        }

        //GET y SET
        public double GetKilometros()
        {
            return kilometros;
        }
        public void SetKilometros(double kilometros)
        {
            this.kilometros = kilometros;
        }
        public double GetLitros()
        {
            return litros;
        }
        public void SetLitros(double litros)
        {
            this.litros = litros;
        }
        public double GetVmedia()
        {
            return vmedia;
        }
        public void SetVmedia(double vmedia)
        {
            this.vmedia = vmedia;
        }
        public string GetCombustible()
        {
            return combustible;
        }
        public void SetCombustible(string combustible)
        {
            this.combustible = combustible;
        }

        //METODOS:
        public double GetTiempo()
        {
            return this.kilometros/this.vmedia;
        }
        public double ConMedio()
        {
            return (this.litros*100)/this.kilometros;
        }
        

        public double GetGasto()
        {
            switch (combustible.ToUpper())
                {
                case "GASOLINA 95":
                return ConMedio() * 1.14;
                case "GASOLINA 98":
                return ConMedio() * 1.25;
                case "DIESEL":
                return ConMedio() * 1.04;
                default:
                Console.WriteLine("El combustible introducido es incorrecto");
                Console.ReadLine();
                return 0;
                }
            }
        
        public void MostrarDatos()
        {
            Console.WriteLine("Los kilometros recorridos son: " + GetKilometros() + " Km");
            Console.WriteLine("Los litros gastaos son: " + GetLitros() + " ls");
            Console.WriteLine("La velocidad media es: " + GetVmedia() +" Km/h");
            Console.WriteLine("El tipo de combustible es: " + GetCombustible());
            Console.WriteLine("El tiempo empleado en el viaje: " + GetTiempo() +"h");
            Console.WriteLine("El consumo medio es: " + ConMedio() + " litros a los 100Km");
            Console.WriteLine("El consumo medio de euros es: " + GetGasto() + " euros a los 100Km");
        }
    }
}
