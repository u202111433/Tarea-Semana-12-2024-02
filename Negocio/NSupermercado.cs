using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NSupermercado
    {
        private DSupermercado dSupermercado = new DSupermercado();

        public string Modificar(Supermercado supermercado)
        {
            return dSupermercado.Modificar(supermercado);
        }
    }
}
