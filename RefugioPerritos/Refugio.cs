using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugioPerritos
{
    public class Refugio
    {
        public string NombreRefugioId { get; set; }
        public string direccion { get; set; }
        public decimal telefono { get; set; }
        public string persona_a_cargo { get; set; }
        public DateTime hora_apertura { get; set; }
        public DateTime hora_cierre { get; set; }

    }
}
