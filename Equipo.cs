public class Equipo
{
    // nombre, jugadores, entrenador, propietario, patrocinadores, sede, estadio
    public string Nombre { get; set; }
    public List<Jugador> Jugadores { get; set; }
    public Entrenador Entrenador { get; set; }
    public string Estadio { get; set; }
    public Patrocinador Patrocinador { get; set; }
}

