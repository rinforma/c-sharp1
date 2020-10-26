using System;

namespace inventario
{
    class Program
    {
    static void Main(string[] args)
    {
        Inventario inventario = new Inventario();

        string opcion = "";  

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Sistema de Inventario");
            Console.WriteLine("*********************");
            Console.WriteLine("");
            Console.WriteLine("1-productos");
            Console.WriteLine("2-Ingreso de Inventario");
            Console.WriteLine("3-Salida de Inventario");
            Console.WriteLine("4-Ajuste Negativo de Inventario");
                Console.WriteLine("5-Ajuste Positivo de Inventario");
            Console.WriteLine("0-Salir");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    inventario.listarproductos();
                    break;
                
                case "2":
                    inventario.ingresodeInventario();
                    break;
                case "3":
                    inventario.salidaInventario();
                    break; 
                case "4":
                    inventario.ajusteNegativoInventario();
                    break;  
                case "5":
                        inventario.ajustePositivoInventario();
                    break;  
                default:
                break;
            }
                
                if (opcion=="0"){
                    break;
            }                    
        }  
    }    
} }    

