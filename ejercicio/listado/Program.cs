using System;
using System.Collections.Generic;

namespace listado
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string> ();
            nombres.Add("Bianca");
            nombres.Add("Harol");
            nombres.Add("Jason");

            foreach (var nombre in nombres)
            {
               Console.WriteLine(nombre); 
            }

            List<int> numeros = new List<int> ();
            numeros .Add(1);
            numeros.Add(12);
            numeros .Add(10);

            foreach (var n in numeros)
            {
                Console.WriteLine(n);
            }
            List<Alumno> alumnos = new List<Alumno>();
            Alumno a = new Alumno(1, "Pedro");
            Alumno b= new Alumno(2, "Maria");
            Alumno c= new Alumno(1, "Juan");

             Alumno.Add(a);
            Alumno.Add(b);
            Alumno.Add(c);


        }
    }
}
