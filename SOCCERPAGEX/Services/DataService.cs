using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;








using SOCCERPAGEX.Services;
using SOCCERPAGEX.Models;

using System.Collections.Generic;

namespace SOCCERPAGEX.Services
{
    public static class DataService
    {
        public static List<Liga> ObtenerLigas()
        {
            return new List<Liga>
            {
                new Liga
                {
                    Id = 1,
                    Nombre = "Liga de Arabia Saudi",
                    Clubes = new List<Club>
                    {
                        new Club
                        {
                            Id = 1,
                            Nombre = "Al - nassr",
                            Liga = "Liga de Arabia",
                            Jugadores = new List<Jugador>
                            {
                                new Jugador { Id = 1, Nombre = "Cristiano Ronaldo", Posicion = "Delantero", Edad = 32, Nacionalidad = "Portugal", ClubId = 1 },
                                new Jugador { Id = 2, Nombre = "Jugador 2", Posicion = "Portero", Edad = 28, Nacionalidad = "Mexicana", ClubId = 1 }
                            }
                        },
                        new Club
                        {
                            Id = 2,
                            Nombre = "no me acuerdo otro equipo",
                            Liga = "Liga de Arabia",
                            Jugadores = new List<Jugador>
                            {
                                new Jugador { Id = 3, Nombre = "Jugador 3", Posicion = "Mediocampista", Edad = 24, Nacionalidad = "Mexicana", ClubId = 2 },
                                new Jugador { Id = 4, Nombre = "Jugador 4", Posicion = "Defensa", Edad = 30, Nacionalidad = "Mexicana", ClubId = 2 }
                            }
                        }
                    }
                },
                new Liga
                {
                    Id = 2,
                    Nombre = "Premier League",
                    Clubes = new List<Club>
                    {
                        // Agrega más clubes y jugadores aquí

                        new Club
                        {
                            Id = 3,
                            Nombre = "Chelsea",
                            Liga = "Liga de Inglaterra",
                            Jugadores = new List<Jugador>
                            {
                                new Jugador { Id = 5, Nombre = "Moi", Posicion = "Delantero", Edad = 32, Nacionalidad = "Santo Domingo", ClubId = 3 },
                                new Jugador { Id = 6, Nombre = "Jugador 2", Posicion = "Portero", Edad = 28, Nacionalidad = "Mexicana", ClubId = 3 }
                            }
                        },
                    }
                }
            };
        }
    }
}

