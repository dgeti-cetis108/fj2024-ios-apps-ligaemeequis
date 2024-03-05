namespace LigaMx;

public class Program
{
    static void Main(string[] args)
    {
        var elAme = crearEquipoAmerica();
        Console.WriteLine(elAme);
    }

    private static Equipo crearEquipoAmerica()
    {
        var america = new Equipo();
        america.Nombre = "Club América";
        america.Estadio = "Azteca, CDMX";
        america.Entrenador = new Entrenador
        {
            Nombres = "André",
            Apellidos = "Soares Jardine",
            Edad = 44,
            AñosDeExperiencia = 10,
            CampeonatosGanados = 1
        };
        america.Patrocinador = new Patrocinador
        {
            Nombre = "Televisa",
            ConCuantoSeMochó = 2600000
        };
        america.Jugadores = new List<Jugador>();
        america.Jugadores.Add(new Jugador { Nombres = "Guillermo", Apellidos = "Ochoa", Número = 1 });
        america.Jugadores.Add(new Jugador { Nombres = "Henry", Apellidos = "Martin", Número = 21 });
        america.Jugadores.Add(new Jugador { Nombres = "Cabecita", Apellidos = "Rodriguez", Número = 10 });
        america.Jugadores.Add(new Jugador { Nombres = "Alvaro", Apellidos = "Fidalgo", Número = 8 });
        america.Jugadores.Add(new Jugador { Nombres = "Jorge", Apellidos = "Sanchez", Número = 2 });
        america.Jugadores.Add(new Jugador { Nombres = "Sebastian", Apellidos = "Caceres", Número = 4 });
        america.Jugadores.Add(new Jugador { Nombres = "Emilio", Apellidos = "Lara", Número = 5 });
        america.Jugadores.Add(new Jugador { Nombres = "Nestor", Apellidos = "Araujo", Número = 14 });
        america.Jugadores.Add(new Jugador { Nombres = "Miguel", Apellidos = "Layun", Número = 19 });
        america.Jugadores.Add(new Jugador { Nombres = "Israel", Apellidos = "Reyes", Número = 22 });
        america.Jugadores.Add(new Jugador { Nombres = "Ramon", Apellidos = "Juarez", Número = 29 });
        america.Jugadores.Add(new Jugador { Nombres = "Luis", Apellidos = "Fuentes", Número = 33 });

        return america;
    }
}

