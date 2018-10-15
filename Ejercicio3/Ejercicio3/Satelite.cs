using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    
        public class Satelite
        {
            private double meridiano;
            private double paralelo;
            private double distancia_tierra;

            public Satelite(double m, double p, double d)
            {
                meridiano = m;
                paralelo = p;
                distancia_tierra = d;
            }

            public double Getmeridiano()
            {
                return meridiano;
            }
            public void Setmeridiano(double meridiano)
            {
                this.meridiano = meridiano;
            }
            public double Getparalelo()
            {
                return paralelo;
            }
            public void Setparalelo(double paralelo)
            {
                this.paralelo = paralelo;
            }
            public double Getdistancia_tierra()
            {
                return distancia_tierra;
            }
            public void Setdistancia_tierra(double distancia_tierra)
            {
                this.distancia_tierra = distancia_tierra;
            }


            public Satelite()
            {
                meridiano = paralelo = distancia_tierra = 0;
            }

            public void SetPosicion(double m, double p, double d)
            {
                meridiano = m;
                paralelo = p;
                distancia_tierra = d;
            }

            public void PrintPosicion()
            {
                Console.WriteLine("El satélite se encuentra en el paralelo " + paralelo + " Meridiano "+meridiano+ " a una distancia de la tierra de "+distancia_tierra+"Kilómetros");
                Console.ReadLine();
            }

            public  void VariarAltura(double desplazamiento)
            {
                if (desplazamiento < 0)
                {
                    Console.WriteLine("se esta acercando a la tierra");
                }
                else if (desplazamiento > 0)
                {
                    Console.WriteLine("se aleja de la Tierra");
                }
                else
                {
                    Console.WriteLine("no se mueve");
                }
            }
            public bool EnOrbita()
            {
                if (distancia_tierra == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                
            }
            
            public void VariaPosicion (double variap, double variam)
            {
                meridiano = meridiano + variam;
                paralelo = paralelo + variap;
            }

        }
}
