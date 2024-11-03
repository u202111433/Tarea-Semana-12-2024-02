using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProducto
    {
        //Registrar
        public String Registrar(Producto producto)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Producto.Add(producto);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Listar Todo
        public List<Producto> ListarTodo()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Producto.ToList();
                }
                return productos;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return productos;
            }
        }

        //Eliminar Fisico

        //Modificar
        public string Modificar(Producto producto)
        {
            try
            {
                using (var context=new BDEFEntities())
                {
                    Producto productoTemp = context.Producto.Find(producto,)
                }
                return "Modificado correctamente"
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
