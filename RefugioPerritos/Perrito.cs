using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugioPerritos
{
    public class Perrito
    {
        public int perritoDNI { get; set; }
        public string nombre_perro { get; set; }
        public int edad_aprox { get; set; }
        public string color_cuerpo { get; set; }
        public string color_ojos { get; set; }
        public bool castrado { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public string NombreRefugioId { get; set; }

    }
}
