using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players
{
    public class Giocatore
    {
        [Key]
        public int GiocatoreId { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        public double Punteggio { get; set; }

        public int PartiteGiocate { get; set; }

        public int PartiteVinte { get; set; }
    }
}


