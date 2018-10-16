using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_CONTACTO
{
    class Contacto
    {

        private string name;
        private int number;
        private DateTime birthdate;

        //Constructores
        public Contacto()
        {
            this.name = null;
            this.number = 0;
            this.birthdate = DateTime.Today;
        }

        public Contacto(string name, int number, DateTime birthdate)
        {
            this.name = name;
            this.number = number;
            this.birthdate = birthdate;
        }

        public Contacto(string name, DateTime birthdate)
        {
            this.name = name;
            this.birthdate = birthdate;

            //Metodo comparar fechas lo tenemos que hacer en el Main
        }

        public Contacto(string name, int number)
        {
            this.name = name;
            this.number = number;
            this.birthdate = DateTime.Today;
        }

        //Getters Setters
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetNumber()
        {
            return number;
        }

        public void SetNumber(int number)
        {
            this.number = number;
        }

        public DateTime GetBirthdate()
        {
            return birthdate;
        }

        public void SetBirthdate(DateTime birthdate)
        {
            this.birthdate = birthdate;
        }

        //Metodo cambiar nombre
        public string ChangeName()
        {
            Console.WriteLine("Inserte el nuevo nombre");
            string newname = Console.ReadLine();
            return name = newname;
        }

        //Metodo devolver nombre
        public void ReturnName()
        {
            Console.WriteLine("El nuevo nombre es: " + GetName());
        }

        //Metodo cambiar telefono
        public string ChangeNumber()
        {
            Console.WriteLine("Inserte el nuevo número de teléfono");
            string newnumber = Console.ReadLine();
            return name = newnumber;
        }

        //Metodo devolver telefono
        public void ReturnNumber()
        {
            Console.WriteLine("El nuevo teléfono es: " + GetNumber());
        }

        //Metodo para activar CFEcha
        public void ActivateCFecha()
        {
            CFecha c1 = new CFecha(birthdate);
            Console.WriteLine(c1.ReturnDay());
            Console.WriteLine(c1.ReturnMonth());
            Console.WriteLine(c1.ReturnYear());
        }

        //Metodo para obtener edad
        public int GetAge()
        {
            DateTime oldDate = birthdate;
            DateTime newDate = DateTime.Now;

            // Difference in days, hours, and minutes.
            TimeSpan ts = newDate - oldDate;

            // Difference in days.
            int Age = ts.Days / 365;

            //Console.WriteLine("La edad es : " + Age);
            Console.ReadLine();
            return Age;
        }

        //Metodo Congratulations
        public void Congratulations()
        {
            if (birthdate == DateTime.Today)
            {
                Console.WriteLine("Te deseamos FELICIDADES en tu cumpleaños " + GetAge());
            }
        }

        //Mostrar datos contacto

        public void ShowContactData()
        {
            Console.WriteLine("Datos Contacto: " + GetName() + "\t" + GetNumber() + "\t" + GetBirthdate());
        }

    }
}
