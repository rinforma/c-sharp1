using System;
using System.Collections.Generic;
public class Orden
{
    public int Codigo { get; set; }

    public DateTime Fecha { get; set; }

    public string  NumerodeOrden { get; set; }

    public  Clientes Clientes { get; set; }
    public Vendedor  Vendedor { get; set; }

    public List<OrdenDetalle> ListaOrdenDetalle { get; set; }

    public Orden(int codigo, DateTime fecha, string numeroOrden,Clientes clientes, Vendedor vendedor)
    {
        Codigo = codigo;
        Fecha = fecha;
        NumerodeOrden = numeroOrden;
        Clientes = clientes;
        Vendedor = vendedor;
        ListaOrdenDetalle = new List<OrdenDetalle>();
    }
    public void AgregarProducto(Producto producto)
    {
        int nuevoCodigo = ListaOrdenDetalle.Count + 1;
        OrdenDetalle o = new OrdenDetalle(nuevoCodigo, 1, producto);
        ListaOrdenDetalle.Add(o);
    }
}