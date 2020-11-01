public class Clientes: Persona
{
    public double Saldo { get; set; }
    public Clientes(int codigo,string nombre, string telefono)
    {
        Codigo = codigo;
        Nombre = nombre;
        Telefono = telefono;
        
    }   
}