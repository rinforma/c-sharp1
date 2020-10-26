public class Alumno
{
    // construccion de las propiedades
    public int Id { get; set; }

    public string PrimerNombre { get; set; }

    public string SegundoNombre { get; set; }
    
    //construccion del constructor para inicialisar las variables

    public Alumno(){
        Id=1;
    }

    public Alumno(int id){
        Id=Id;
    }
    public Alumno(string primerNombre, string segundoNombre){
        PrimerNombre = primerNombre;
        SegundoNombre = segundoNombre;
    }
}
