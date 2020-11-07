using System
using System.Collections.Generic;

public class Factura
{
    public int Codigo { get; set; }
    public DateTime Fecha { get; set; }
    public string  NumerodeFactura { get; set; }
    public Acreedor Acreedor { get; set; }
    public Proveedor Proveedor { get; set; }
    public List<FacturaDetalle> ListaFacturaDetalle { get; set; }
    public double Total { get; set; }
    public double Subtotal { get; set; }
    public double Impuesto { get; set; }

    public Factura(int codigo, DateTime fecha, string NumerodeOrden, Acreedor acreedor, Proveedor proveedor)
    {
      Codigo = codigo;
      NumerodeFactura = numeroFactura;
      Acreedor = acreedor;
      Proveedor = proveedor_;
      ListaFacturaDetalle = new List<FacturaDetalle>();
      
    }
    public void  AgregarProducto(Pruducto producto)
    {
        int nuevoCodigo = ListaFacturaDetalle.Count + 1;
        int cantidad = 1;
        FacturaDdetalle o = new FacturaDetalle(1,1,producto);
        ListaFacturaDetalle.Add(o);
        Total += cantidad * producto.precio;
        Subtotal = Total * producto.precio;
        Impuesto = Total * 0.15;

    }
}