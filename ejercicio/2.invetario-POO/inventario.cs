using System;
using System.Collections.Generic;

    public class Inventario
{
    public List<Producto> ListadeProductos { get; set; }
    
public Inventario()
{
    ListadeProductos = new List<Producto>();
    Producto a = new Producto("001", "Iphonex", 0);
    Producto b = new Producto("002", "Lapto Dell", 5);
    Producto c = new Producto("003", "Monitor Samsung", 2);
    Producto d = new Producto("004", "Mause", 100);
    Producto e = new Producto("005", "Hadeset", 25);

    ListadeProductos.Add(a);
    ListadeProductos.Add(b);
    ListadeProductos.Add(c);
    ListadeProductos.Add(d);
    ListadeProductos.Add(e);
}
    public void listarproductos(){
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Listar productos");
        Console.WriteLine("**********************");
        Console.WriteLine("Codigo, Descripcion y Existencia");

        foreach (var producto in ListadeProductos)
        {
           Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Existencia.ToString()); 
        }
        Console.ReadLine();
    }
        private void  movimientoInventario ( string  codigo , int  cantidad , string  tipoMovimiento ) {

        foreach (var producto in ListadeProductos)
        {
        if  (producto.Codigo ==  codigo ) {
                if ( tipoMovimiento  ==  " + " ) {
                    producto.Existencia = producto.Existencia +  cantidad;
                } else {
                    producto.Existencia = producto.Existencia -  cantidad;
                }
            } 
         } 
        
    }
        public void ingresodeInventario(){

        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso de producto al Inventario");
        Console.WriteLine("*********************************");
        Console.Write("Ingrese el codigo del producto:");
        codigo = Console.ReadLine();
        Console.Write("Ingreso la cantidad del producto");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "+");

    }   
    public void salidaInventario() {
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
        public void ajusteNegativoInventario() {
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
        public void ajustePositivoInventario() {
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
}
