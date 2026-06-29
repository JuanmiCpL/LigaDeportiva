public class Equipos
{
    public int Id_Equipo { get; set; } = 0;
    public string Nombre_Equipo { get; set; } = string.Empty;
    public string Ciudad { get; set; } = string.Empty;
    public string Estadio { get; set; } = string.Empty;
    public DateTime Fecha_Fundacion { get; set; }
    public string Nombre_Manager { get; set; } = string.Empty;

    public Equipos(string nombreEquipo, string ciudad, string estadio,
                   DateTime fechaFundacion, string nombreManager)
    {
        Nombre_Equipo = nombreEquipo;
        Ciudad = ciudad;
        Estadio = estadio;
        Fecha_Fundacion = fechaFundacion;
        Nombre_Manager = nombreManager;
    }

    public Equipos() { }
}