namespace LigaAccesoDatos;

public abstract class Persona
{
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public DateTime Fecha_Nacimiento { get; set; }

    public Persona(string nombre, string apellido, DateTime fechaNacimiento)
    {
        Nombre = nombre;
        Apellido = apellido;
        Fecha_Nacimiento = fechaNacimiento;
    }

    public Persona() { }

    public abstract string Jugador();
    public abstract string ManagerTecnicos();
    public virtual string ObtenerInfo()
    {
        return $"Nombre: {Nombre} {Apellido} | Fecha Nac.: {Fecha_Nacimiento:dd/MM/yyyy}";
    }
}