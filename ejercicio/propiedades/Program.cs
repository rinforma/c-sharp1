using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.Id = 1;
            a.PrimerNombre = "Bianca";
            a.SegundoNombre = "zamadhi";

            Alumno b = new Alumno();
            b.Id = 2;
            b.PrimerNombre = "Harol";
            b.SegundoNombre = "Roberto";

            Alumno c = new Alumno(3);
            b.PrimerNombre = "Jason";
            
            Alumno d = new Alumno("Bianca" , "Zamadhi");

            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
            
            Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre);
        }
    }
}
