using System;
using System.Collections.Generic;

#nullable disable

namespace AtividadeModulo.Models
{
    public partial class Pacote
    {
        public Pacote()
        {
            Compras = new HashSet<Compra>();
        }

        public int IdPacote { get; set; }
        public int? NumAcompanhantes { get; set; }
        public string HospedagemSimNao { get; set; }
        public double Preco { get; set; }
        public DateTime DataIda { get; set; }
        public DateTime DataVolta { get; set; }

        public virtual Usa Usa { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
    }
}
