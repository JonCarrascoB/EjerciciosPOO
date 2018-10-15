using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Numero
    {
        private int numero;
        

        //constructores
        public Numero()
        {
            numero = 0;
            
        }
        public Numero(int numero)
        {
            this.numero = numero;
        }

        // get y set
        public int Getnumero()
        {
            return numero;
        }
        public void Setnumero(int numero)
        {
            this.numero = numero;
        }


        //metodos
        public int Añade(int add)
        {
            return (add + numero);

        }
        public int Resta(int add)
        {
            return (numero - add);

        }
        public int Getvalor()
        {
            return numero;

        }
        public int GetDoble()
        {
            return (numero*2);

        }
        public int GetTriple()
        {
            return (numero*3);

        }
        public int Restart()
        {
            return numero;

        }
    }
}
