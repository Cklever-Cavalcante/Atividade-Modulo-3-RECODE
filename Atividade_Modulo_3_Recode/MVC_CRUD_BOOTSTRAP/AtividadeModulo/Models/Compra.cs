using System;
using System.Collections.Generic;

#nullable disable

namespace AtividadeModulo.Models
{
    public partial class Compra
    {
        public int IdCliente { get; set; }
        public int? IdPacote { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Pacote IdPacoteNavigation { get; set; }
    }
}
