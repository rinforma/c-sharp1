using System;

namespace pilares_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro p = new Perro();
            p.Nombre = "Rayer";
            p.Patas = 4;
            p.EsDomestico = true;
            p.Comer();
            p.Caminando();
            p.Ladrar();
            p.Tamaño();

            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);
            Console.WriteLine(p.EsDomestico);

            Gato g = new Gato();
            g.Nombre = "Leon";
            g.Patas = 4;
            g.Pelaje = "Pintado";
            g.Comer();
            g.Caminando();
            g.Miauya();

        }
    }
}
