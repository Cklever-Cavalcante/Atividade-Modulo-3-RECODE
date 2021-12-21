using System;
using System.Collections.Generic;

#nullable disable

namespace AtividadeModulo.Models
{
    public partial class Cliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CidadeReside { get; set; }
        public int IdCliente { get; set; }
        public string UfReside { get; set; }
        public string Email { get; set; }
        public string PaisReside { get; set; }

        public virtual Compra Compra { get; set; }
    }
}
