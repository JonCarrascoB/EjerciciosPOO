using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_CONTACTO
{
    class Program
    {
        static void Main(string[] args)
        {
                    Contacto contact1 = new Contacto("Miren", 944123456, new DateTime(1990, 02, 04));
                    //contact.GetName();
                    //contact.GetNumber();
                    //contact.GetBirthdate();
                    Contacto contact2 = new Contacto("Jon", 931212123, DateTime.Today);
                    Contacto contact3 = new Contacto("Ane", 0, new DateTime(1995, 05, 05));
                    Contacto contact4 = new Contacto("Julen", 944123321, new DateTime(1992, 02, 04));


                    //Comprobamos que las fechas sean correctas
                    DateTime limitdate = new DateTime(1900, 01, 01);
                    CompareDateTimes(contact1.GetBirthdate(), limitdate);
                    CompareDateTimes(contact2.GetBirthdate(), limitdate);
                    CompareDateTimes(contact3.GetBirthdate(), limitdate);
                    CompareDateTimes(contact4.GetBirthdate(), limitdate);



                    //Mostrar todos los contactos con sus datos
                    contact1.ShowContactData();
                    contact2.ShowContactData();
                    contact3.ShowContactData();
                    contact4.ShowContactData();

                    //Mostrar la edad
                    Console.WriteLine("La edad de " + contact1.GetName() + " es " + contact1.GetAge());
                    Console.WriteLine("La edad de " + contact2.GetName() + " es " + contact2.GetAge());
                    Console.WriteLine("La edad de " + contact3.GetName() + " es " + contact3.GetAge());
                    Console.WriteLine("La edad de " + contact4.GetName() + " es " + contact4.GetAge());

                    //Felicitar a los contactos
                    contact1.Congratulations();
                    contact2.Congratulations();
                    contact3.Congratulations();
                    contact4.Congratulations();

                    //TRabajamos con la clase Contacto2
                    Contacto2 c1 = new Contacto2("Miren", 944123456, new DateTime(1990, 03, 06), "FRIEND");

                    //contact.GetName();
                    //contact.GetNumber();
                    //contact.GetBirthdate();
                    Contacto2 c2 = new Contacto2("Jon", 931212123, DateTime.Today, "COWORKERS");
                    Contacto2 c3 = new Contacto2("Ane", 0, new DateTime(1995, 05, 05), "FAMILY");
                    Contacto2 c4 = new Contacto2("Julen", 944123321, new DateTime(1992, 02, 04), "CLASSMATES");
                    Contacto2 c5 = new Contacto2("Jone", 0, new DateTime(1992, 06, 06), "FRIEND");
                    Contacto2 c6 = new Contacto2("Mikel", 0, new DateTime(1997, 07, 07), "family");
                    Contacto2 c7 = new Contacto2();


                    Console.WriteLine("Cuenta de familiares en c1: " + c1.GetContFamily());
                    Console.WriteLine("Cuenta de familiares en c7: " + c7.GetContFamily());


                    //Mostrar todos los contactos con sus datos
                    c1.ShowContactData();
                    c2.ShowContactData();
                    c3.ShowContactData();
                    c4.ShowContactData();
                    c5.ShowContactData();
                    c6.ShowContactData();


                    c7.NumberContact();//para el total
                    Console.WriteLine("Cuenta de amigos en c7: " + c7.GetContFriend());
                    Console.WriteLine("Cuenta de coworkers en c7: " + c7.GetContCoworkers());
                    Console.WriteLine("Cuenta de classmates en c7: " + c7.GetContClassMates());


                    Console.ReadLine();
                }


                //Metodo comparar fechas lo tenemos que hacer en el Main

                public static DateTime CompareDateTimes(DateTime birthdate, DateTime limitdate)
                {

                    if (birthdate > limitdate)
                    {
                        return birthdate;
                    }
                    else
                    {
                        return DateTime.Today;
                    }

                }

            
        
    }
}
