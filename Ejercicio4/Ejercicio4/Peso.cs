using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Peso
    { 

        private double kg;
        private String medida;

        public Peso()
        {

        }

        public Peso(double peso, string tipo)
        {
            this.kg = GetKilos(peso, tipo);
        }

        public double GetKg()
        {
        return kg;
        }

       public void SetKg(double kg)
        {
        this.kg = kg;
        }

        public String GetMedida()
        {
        return medida;
        }

        public void SetMedida(string medida)
        {
        this.medida = medida;
        }

        public double GetLibras()
        {
        return GetKg() / 0.453;
        }

        public double GetLingotes()
        {
        return GetKg() / 14.59;
        }

        public double GetKilos(double peso, String tipo)
        {
            switch (tipo.ToUpper())
            {
            case "LB":
                return peso * 0.453;
            case "LI":
                return peso * 14.59;
            case "OZ":
                return peso * 0.2835;
            case "P":
                return peso * 0.00155;
            case "K":
                return peso;
            case "G":
                return peso * 1000;
            case "Q":
                return peso * 43.3;
            default:
                Console.WriteLine("La medida introducida es incorrecta");
                Console.ReadLine();
                return peso;
            }
        }

    public double GetPeso(string tipo)
    {
        switch (tipo.ToUpper())
        {
            case "LB":
                return GetLibras();
            case "LI":
                return GetLingotes();
            case "OZ":
                return GetKg() / 0.2835;
            case "P":
                return GetKg() / 0.00155;
            case "K":
                return GetKg();
            case "G":
                return GetKg() * 1000;
            case "Q":
                return GetKg() / 43.3;
            default:
                Console.WriteLine("La medida introducida es incorrecta");
                Console.ReadLine();
                return kg;
            }
        }


    }
}
