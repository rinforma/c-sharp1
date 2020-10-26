using System;

namespace Funsiones
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno(1, "Bianca" , "Zamadhi");
            Alumno b = new Alumno(2, "Harol" , "Roberto");
            Alumno c = new Alumno(3, "Jason" , "Cruz");
           
            a.inactivarAlumno();

            Console.WriteLine(a.nombreCompleto());
            Console.WriteLine(b.nombreCompleto());
            Console.WriteLine(c.nombreCompleto());

            a.activarAlumno();

            Console.WriteLine(" ");

            Console.WriteLine(a.nombreCompleto());
            Console.WriteLine(b.nombreCompleto());
            Console.WriteLine(c.nombreCompleto());


        }
    }
}
