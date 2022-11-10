using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugioPerritos
{
    public class ReglasDeNegocio
    {
        private AccesoADatos accesoADatos;

        public ReglasDeNegocio() 
        {
            accesoADatos = new AccesoADatos();
        }

        public Perrito SavePerrito(Perrito perrito) 
        {
            if (perrito.perritoDNI == 0)
               accesoADatos.InsertarPerrito(perrito);
                

            
            //else
            //{
            //    //accesoADatos.UpdatePerrito
            //    MessageBox.Show("Lol error, ya existe ese perrito");
            //}
            return perrito;
        }

        public List<Perrito> GetPerritos() 
        {
          return accesoADatos.GetPerritos();
        }
    }
}
