using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugioPerritos
{
    public class Perrito
    {
        private int PerritoDNI;
        private string Nombre_perro;
        private int Edad_aprox;
        private string Color_cuerpo;
        private string Color_ojos;
        private bool Castrado;
        private DateTime Fecha_ingreso;
        private string NombreRefugioID;

        public int perritoDNI
        {
            get { return PerritoDNI; }
            set { PerritoDNI = value; }
        }
        
        public string nombre_perro
        {
            get { return Nombre_perro; }
            set { Nombre_perro = value; }
        }
        public int edad_aprox
        {
            get { return Edad_aprox; }
            set { Edad_aprox = value; }
        }
        public string color_cuerpo
        {
            get { return Color_cuerpo; }
            set { Color_cuerpo = value; }
        }
        public string color_ojos
        {
            get { return Color_ojos; }
            set { Color_ojos = value; }
        }
        public bool castrado
        {
            get { return Castrado; }
            set { Castrado = value; }
        }
        public DateTime fecha_ingreso
        {
            get { return Fecha_ingreso; }
            set { Fecha_ingreso = value; }
        }
        public string NombreRefugioId
        {
            get { return NombreRefugioID; }
            set { NombreRefugioID = value; }
        }

    }
}
