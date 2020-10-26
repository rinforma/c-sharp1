using System;

namespace inventario
{
    class Program
    {
        static string[,] productos = new string[5,3]
        {
            {"001","Iphonex", "0"},
            {"002","Lapton Dell", "5"},
            {"003", "Monitor Samsung", "2"},
            {"004", "Mause", "100"},
            {"005", "Headset", "25"},
        };

        static void listarproductos(){
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listar productos");
            Console.WriteLine("**********************");
            Console.WriteLine("Codigo, Descripcion y Existencia");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(productos[i, 0] + " | " + productos[i, 1] + " | " + productos[i, 2]);
            }
                  Console.ReadLine();
        }
         static  void  movimientoInventario ( string  codigo , int  cantidad , string  tipoMovimiento ) {
            for ( int  i  =  0 ; i  <  5 ; i ++ )
            {
                if  (productos [ i , 0 ] ==  codigo ) {
                    if ( tipoMovimiento  ==  " + " ) {
                        productos [ i , 2 ] = ( Int32 . Parse ( productos [ i , 2 ]) +  cantidad ). ToString ();
                    } else {
                        productos [ i , 2 ] = ( Int32 . Parse ( productos [ i , 2 ]) -  cantidad ). ToString ();
                    }
                }
            }
        }
        static void ingresodeInventario(){

            string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Ingreso de producto al Inventario");
            Console.WriteLine("*********************************");
            Console.Write("Ingrese el codigo del producto:");
            codigo = Console.ReadLine();
            Console.WriteLine("Ingreso la cantidad del producto");
            cantidad = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "+");

        }   
           static void ajusteNegativoInventario() {
			string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Ajuste Negativo de Inventario");
            Console.WriteLine("***********");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "-");
		}
            static void ajustePositivoInventario() {
			string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Ajuste Positivo de Inventario");
            Console.WriteLine("***********");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "+");
		}
             static void salidaInventario() {
            string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Salida de Productos del Inventario");
            Console.WriteLine("************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "-");
        }
        static void Main(string[] args)
        {
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
                 Console.WriteLine("5-Ajuiste Positivo de Inventario");
                Console.WriteLine("0-Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        listarproductos();
                        break;
                    
                    case "2":
                        ingresodeInventario();
                        break;
                    case "3":
                       salidaInventario();
                        break; 
                    case "4":
                       ajusteNegativoInventario();
                        break;  
                    case "5":
                         ajustePositivoInventario();
                        break;  
                    default:
                    break;
                }
                    
                    if (opcion=="0"){
                        break;
                }                    
            }  
        }
    }
}
