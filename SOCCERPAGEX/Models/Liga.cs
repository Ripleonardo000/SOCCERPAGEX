using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOCCERPAGEX.Models
{
    public class Liga
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Club> Clubes { get; set; } = new();
    }
}
