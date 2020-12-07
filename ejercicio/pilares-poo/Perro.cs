using System;
public class Perro:Mamifero // herencia
{
    public bool EsDomestico { get; set; }
    public Perro()// polimorfismo
    {
       EsDomestico = true; 
    }
    public Perro(bool esDomestico)
    {
        EsDomestico = esDomestico;
    }
    public void Ladrar()// es abstraccion
    {
        Console.WriteLine("gua gua agua ");
    }

    public void Tamaño()
        {
            DescribirTamaño; 
            
        }
    private void DescribirTamaño()// encapsulamiento
    {
        Console.WriteLine("El Perro es Grande");
    }

}
