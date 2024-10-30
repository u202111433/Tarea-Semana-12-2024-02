using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DSupermercado
    {
        public string Modificar(Supermercado supermercado)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Supermercado supermercadoTemp = new Supermercado();
                    supermercadoTemp.NombreReferencial = supermercado.NombreReferencial;
                    supermercadoTemp.Direccion = supermercado.Direccion;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
