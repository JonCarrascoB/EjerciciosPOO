using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_CONTACTO
{
    class Contacto2
    {

        private string name;
        private int number;
        private DateTime birthdate;
        private int createdcontactnumber;
        private string contactType;
        private int familyContacts;
        private int friendContacts;
        private int coworkerContacts;
        private int classMates;
        static int cont = 0; //para hacer obtener el dato de nº de contactos creados
        static int contfamilyContacts = 0;
        static int contfriendContacts = 0;
        static int contcoworkerContacts = 0;
        static int contClassMates = 0;


       //Constructores

        public Contacto2()
        {
            this.name = null;
            this.number = 0;
            this.birthdate = DateTime.Today;
            this.contactType = "FRIEND";
            cont++;
            ContactType();
        }

        public Contacto2(string name, int number, DateTime birthdate, string contactType)

        {

            this.name = name;

            this.number = number;

            this.birthdate = birthdate;

            this.contactType = contactType;

            cont++;

            ContactType();

            // this.createdcontactnumber = createdcontactnumber++;



        }



        public Contacto2(string name, DateTime birthdate)

        {

            this.name = name;

            this.birthdate = birthdate;



            //EL Metodo comparar fechas lo tenemos que hacer en el Main

        }



        public Contacto2(string name, int number)

        {

            this.name = name;

            this.number = number;

            this.birthdate = DateTime.Today;

        }



        //Metodo apartado 10

        public void ContactType()

        {

            switch (this.contactType.ToUpper())

            {

                case "FAMILY":

                    contfamilyContacts++;

                    break;

                case "FRIEND":

                    contfriendContacts++;

                    break;

                case "COWORKERS":

                    contcoworkerContacts++;

                    break;

                case "CLASSMATES":

                    contClassMates++;

                    break;

            }

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

        public string GetContactType()

        {

            return contactType;

        }

        public void SetContactType(string contactType)

        {

            this.contactType = contactType;

        }

        public int GetNumberContact()

        {

            return cont;

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

            Console.WriteLine("Te deseamos FELICIDADES en tu cumpleaños " + GetAge());

        }

        //Mostrar datos contacto modificado punto 11

        public void ShowContactData()

        {

            Console.WriteLine("Datos Contacto: " + GetName() + "\t" + GetNumber() + "\t" + GetBirthdate() +

                "\t" + GetContactType());

        }



        //Metodo Cambiar tipo

        public string ChangeType()

        {

            Console.WriteLine("Inserte el nuevo tipo");

            string newcontactType = Console.ReadLine();

            return contactType = newcontactType;

        }

        //Metodo Obtener tipo

        public void GetType()

        {

            Console.WriteLine("El nuevo tipo es: " + GetContactType());

        }

        //Metodo Obtener nº de contactos

        public void ContactNumber()

        {



            Console.WriteLine("El nº de contactos es: " + GetNumberContact());

        }



        public int GetContFamily()

        {

            return contfamilyContacts;

        }

        public int GetContFriend()

        {

            return contfriendContacts;

        }

        public int GetContCoworkers()

        {

            return contcoworkerContacts;

        }

        public int GetContClassMates()

        {

            return contClassMates;

        }

        public void NumberContact()

        {

            Console.WriteLine("El número de contactos es: " + GetNumberContact());



        }















    
    }
}
