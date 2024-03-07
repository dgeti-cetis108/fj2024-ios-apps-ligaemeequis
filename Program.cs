

namespace LigaMx;

public class Program
{
    // propiedades
    public static List<Equipo> Equipos = new();
    public static Torneo Apertura2024 = new();
    public static List<Partido> Rol = new();

    // métodos
    static void Main(string[] args)
    {
        crearEquipoAmerica();
        crearEquipoNecaxa();
        definirNuevoTorneo(); // apertura 2024
        crearJornada1();
    }

    private static void crearJornada1()
    {
        Rol.Add(new Partido {Fecha=new DateTime(2024,01,14)...});
    }

    private static void definirNuevoTorneo()
    {
        Apertura2024.Año = 2024;
        Apertura2024.Inicio = new DateTime(2024,01,14);
        Apertura2024.Fin = new DateTime(2024,05,26);
        Apertura2024.Equipos = Equipos;
    }

    private static void crearEquipoNecaxa()
    {
        var equipo = new Equipo();
        equipo.Nombre = "Club Necaxa";
        equipo.Estadio = "Victoria, Aguascalientes";
        equipo.Entrenador = new Entrenador
        {
            Nombres = "Edudardo",
            Apellidos = "Fentanas",
            Edad = 50,
            AñosDeExperiencia = 8,
            CampeonatosGanados = 0
        };
        equipo.Patrocinador = new Patrocinador
        {
            Nombre = "Nissan",
            ConCuantoSeMochó = 1500000
        };
        equipo.Jugadores = new List<Jugador>();
        equipo.Jugadores.Add(new Jugador { Nombres = "Hugo", Apellidos = "Gonzlez", Número = 1 });
        equipo.Jugadores.Add(new Jugador { Nombres = "Luis", Apellidos = "Malagon", Número = 23 });
        equipo.Jugadores.Add(new Jugador { Nombres = "Angel", Apellidos = "Alonso", Número = 30 });
        equipo.Jugadores.Add(new Jugador { Nombres = "Fabricio", Apellidos = "Formiliano", Número = 2 });
        equipo.Jugadores.Add(new Jugador { Nombres = "Agustín", Apellidos = "Oliveros", Número = 3 });
        equipo.Jugadores.Add(new Jugador { Nombres = "Alexis", Apellidos = "Peña", Número = 4 });
        equipo.Jugadores.Add(new Jugador { Nombres = "Josecarlos", Apellidos = "Rankin", Número = 5 });
        equipo.Jugadores.Add(new Jugador { Nombres = "Juan", Apellidos = "Segonia", Número = 16 });
        equipo.Jugadores.Add(new Jugador { Nombres = "Edgar", Apellidos = "Mendez", Número = 17 });
        equipo.Jugadores.Add(new Jugador { Nombres = "Jair", Apellidos = "Pereira", Número = 18 });
        equipo.Jugadores.Add(new Jugador { Nombres = "Fernando", Apellidos = "Meza", Número = 21 });
        equipo.Jugadores.Add(new Jugador { Nombres = "Pablo", Apellidos = "Espinoza", Número = 33 });

        Equipos.Add(equipo);
    }

    private static void crearEquipoAmerica()
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

        Equipos.Add(america);
    }
}

