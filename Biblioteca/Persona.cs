namespace Biblioteca;
public class Persona
{
    public int Edad { get; set; }   

    public string Nombre { get; set; } 

    public Persona(string nombre, int edad)
    {
        this.Nombre = nombre;
        this.Edad = edad;
    }    

    public bool EsMayorEdad() => Edad >= 18 ? true : false;
}