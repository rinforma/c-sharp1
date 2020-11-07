using System;

namespace proyectof
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosdePrueba datos = new DatosdePrueba();

            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de facturacion");
                Console.WriteLine("======================");
                Console.WriteLine("");
                Console.WriteLine( "1. Lista de Productos");
                Console.WriteLine( "2. Crear Factura");
                Console.WriteLine( "3. Lista de Acreedores");
                Console.WriteLine( "4. Lista de Proveedores");
                Console.WriteLine( "5. Lista de Facturas");
                Console.WriteLine( "0. Avandonar Facturacion"); 
                opcion = Console.ReadLine();

                switch (opcion = "")
                {
                    
                    default:
                }         
            }

        }
    }
}
