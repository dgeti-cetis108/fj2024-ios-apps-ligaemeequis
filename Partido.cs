public class Partido
{
    public DateTime Fecha { get; set; }
    public int Jornada { get; set; }
    public Equipo EquipoA { get; set; }
    public Equipo EquipoB { get; set; }
    public bool EquipoAEsCasa { get; set; }
    
}