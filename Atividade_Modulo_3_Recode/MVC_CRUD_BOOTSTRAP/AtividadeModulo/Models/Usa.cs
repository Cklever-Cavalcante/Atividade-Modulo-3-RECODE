using System;
using System.Collections.Generic;

#nullable disable

namespace AtividadeModulo.Models
{
    public partial class Usa
    {
        public int IdPacote { get; set; }
        public int? IdDestino { get; set; }

        public virtual Destino IdDestinoNavigation { get; set; }
        public virtual Pacote IdPacoteNavigation { get; set; }
    }
}
