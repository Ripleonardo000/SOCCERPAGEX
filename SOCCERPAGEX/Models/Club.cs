﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOCCERPAGEX.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Liga { get; set; }
        public List<Jugador> Jugadores { get; set; } = new();
    }
}
