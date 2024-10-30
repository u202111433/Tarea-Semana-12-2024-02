using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProducto
    {
        private DProducto dProducto = new DProducto();
        
        public String Registrar(Producto producto)
        {
            return dProducto.Registrar(producto);
        }

        public List<Producto> ListaTodo()
        {
            return dProducto.ListarTodo();
        }
    }
}
