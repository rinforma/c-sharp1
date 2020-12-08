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
            Console.ReadLine();

            Gato g = new Gato();
            g.Nombre = "Leon";
            g.Patas = 4;
            g.Pelaje = "Pintado";
            g.Comer();
            g.Caminando();
            g.Miauya();
            Console.ReadLine();

            Mono m = new  Mono();
            m.Nombre = "kinkom";
            m.Silvestre = true;
            m.Patas = 4;
            m.colgar();
        
           Console.WriteLine(m.Nombre);
           Console.WriteLine(m.Patas);
           Console.WriteLine(m.Silvestre);
           
            ave v= new ave();
            v.Nombre = "colibris";
            v.volar();
            v.cantar();
            Console.ReadLine();

            Aguila ag = new Aguila();
            ag.Nombre = "Guacamaya";
            ag.Comer();
            ag.cantar();
            Console.WriteLine(ag.Nombre);

            Peces pe = new Peces();
            pe.Nombre = "Memo";
            pe.nadar();
            pe.Comer();

            Pez e = new Pez();
            e.Nombre = "guili";
            e.nadar();
            e.Comer();
            
        }
    }
}
