using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Coche
    {
        private string marca;
        private string modelo;

        public Coche()
        {

        }
        public Coche(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public string Getmarca()
        {
            return marca;
        }
        public void Setmarca(string marca)
        {
            this.marca = marca;
        }

        public string Getmodelo()
        {
            return modelo;
        }
        public void Setmodelo(string modelo)
        {
            this.modelo = modelo;
        }


    }
}
