using System;
using System.Collections.Generic;

#nullable disable

namespace AtividadeModulo.Models
{
    public partial class Destino
    {
        public Destino()
        {
            Usas = new HashSet<Usa>();
        }

        public int IdDestino { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public virtual ICollection<Usa> Usas { get; set; }
    }
}
