public class Producto
{
    public int Codigo { get; set; }

    public string Descripcion { get; set; }

    public double Precio { get; set; }

    public Procduto(int codigo, string descripcion, double precio)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Precio = precio;

    }
}