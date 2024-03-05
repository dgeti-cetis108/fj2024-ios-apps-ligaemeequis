public class Torneo
{
    public int Año { get; set; }
    public NombreDeTorneo Nombre { get; set; }
    public DateTime Inicio { get; set; }
    public DateTime Fin { get; set; }
    public List<Equipo> Equipos { get; set; }
}

public enum NombreDeTorneo
{
    Apertura, Clausura
}