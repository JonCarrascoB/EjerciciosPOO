using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_CONTACTO
{
    class CFecha
    {
        

        private DateTime fecha;

        //Constructor

        public CFecha()

        {



        }

        public CFecha(DateTime fecha)

        {

            this.fecha = fecha;

        }



        //Metodo 

        public string ReturnDay()

        {

            return fecha.ToString("dd");

        }

        public string ReturnMonth()

        {

            return fecha.ToString("MM");

        }

        public string ReturnYear()

        {

            return fecha.ToString("yyyy");

        }

    
}
}
