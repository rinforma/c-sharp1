public class Facturadetalle
{
    public int Codigo { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }
    public Producto Producto { get; set; }

    public Facturadetalle(int codigo, int cantidad, Producto producto)
    {
        Codigo = codigo;
        Cantidad = cantidad;
        Producto = producto;
    }
}