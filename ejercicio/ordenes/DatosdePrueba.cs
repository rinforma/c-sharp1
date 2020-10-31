using System;
using System.Collections.Generic;

public class DatosdePrueba
{
    public List<Producto> ListadeProductos { get; set; }

    public List<Clientes> listadeClientes { get; set; }

    public List<Vendedor>  ListadeVendedores{ get; set; }

    public List<Orden> ListaOrdenes { get; set; }
    

    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        listadeClientes = new List<Clientes>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        cargarVendedores();

        ListaOrdenes = new List <Orden>();


    }
     private void cargarProductos() // en capsulamiento
    {
        Producto P1 = new Producto(1, "Mause", 250);
        ListadeProductos.Add(P1);

        Producto P2 = new Producto(2, "Teclado", 350);
        ListadeProductos.Add(P2);

        Producto P3 = new Producto(3, "Monitor", 4000);
        ListadeProductos.Add(P3);

    }
    private void cargarClientes()
    {
        Clientes c1 = new Clientes(1, "Pedro", "9999999");
        Console.WriteLine("");
        listadeClientes.Add(c1);
        Clientes c2 = new Clientes(2, "Marcos", "8888888");
        Console.WriteLine("");
        listadeClientes.Add(c2);    
    }
    private void cargarVendedores()
    {
        Vendedor v1 = new Vendedor(1, "Esequiel", "v002");
        ListadeVendedores.Add(v1);
        Vendedor v2 = new Vendedor(2, "Moises", "v003");
        ListadeVendedores.Add(v2);
        
    }
    public void ListarProducto()
    {
        Console.Clear();
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("==================");
        Console.WriteLine("");

        foreach (var Producto in ListadeProductos)
        {
            Console.WriteLine(Producto.Codigo + " | " + Producto.Descripcion + " | " + Producto.Precio );
        }
        Console.Read();
    }
        public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("=================");
        Console.WriteLine("");

        foreach (var Cliente in listadeClientes)
        {
            Console.WriteLine(Cliente.Codigo + " | " + Cliente.Nombre + " | " + Cliente.Telefono );
        }
        Console.Read();
    }
    public void ListarVendedores()
    {
        Console.Clear();
        Console.WriteLine("Lista de Vendedores");
        Console.WriteLine("===================");
        Console.WriteLine("");

        foreach (var Vendedor in ListadeVendedores)
        {
            Console.WriteLine(Vendedor.Codigo + " | " + Vendedor.Nombre + " | " + Vendedor.CodigoVendedor );
        }
        Console.Read();
    }
    public void CrearOrden()
    {
        Console.WriteLine("Creando Orden");
        Console.WriteLine("=============");
        Console.WriteLine("");
         
        Console.WriteLine("Ingrese el Codigo del Cliente");
        string codigoCliete = Console.ReadLine();
      
        Clientes cliente = listadeClientes.Find(C =>C.Codigo.ToString() == codigoCliete);
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        }else

        {
            Console.WriteLine("Cliente:" + cliente.Nombre);
            Console.WriteLine("");
        }  
        Console.WriteLine("Ingrese el Codigo del Vendedor");
        string CodigoVendedor = Console.ReadLine();
        Vendedor vendedor = ListadeVendedores.Find(V =>V.Codigo.ToString() == CodigoVendedor);
        if (vendedor == null)
        {
           Console.WriteLine("Vendedor no encontrado");
           Console.ReadLine();
           return;
        } else{
            Console.WriteLine("Vendedor:" + vendedor.Nombre);
            Console.WriteLine("");
        }
        int nuevoCodigo = ListaOrdenes.Count + 1; 

        Orden nuevaOrden = new Orden(1, DateTime.Now,"SPS"+ nuevoCodigo, cliente, vendedor);
        ListaOrdenes.Add(nuevaOrden);

        while (true)
        {
            Console.WriteLine("Ingrese el Producto:");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(P =>P.Codigo.ToString() == codigoProducto);
           if (producto == null)
        {
            Console.WriteLine("Producto no encontrado");
           Console.ReadLine();
        }else{
            Console.WriteLine("Producto agregado:" + producto.Descripcion + " con precio de:" + producto.Precio);
            nuevaOrden.AgregarProducto(producto);
        }

            Console.WriteLine("Desea Continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                    break;
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Total de la Orde es:" + nuevaOrden.Total);
        Console.ReadLine();

    } 
    public void ListarOrdenes()
    {
        Console.WriteLine("Lista de Ordenes");
        Console.WriteLine("================");
        Console.WriteLine(""); 
        Console.WriteLine ( " Codigo | Fecha | Total " );
        Console.WriteLine ( " Cliente | Vendedor " );
        Console.WriteLine ( " ====================== " );
        Console.WriteLine ( " " );  

        foreach (var orden in ListaOrdenes)
    {
           Console.WriteLine(orden.Codigo + " | "  + orden.Fecha + " | " + orden.Total); 
           Console.WriteLine(orden.Clientes.Nombre + " | "  + orden.Vendedor.Nombre ); 

        foreach (var detalle in orden.ListaOrdenDetalle)   
        {
            Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
        }
            Console.WriteLine();
        }
            Console.ReadLine();
    }   
}   

 