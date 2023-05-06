using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;
using Modelo;



namespace Controlador
{
    public class ArticuloNegocio
    {

        
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
                datos.SetConsulta("SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, a.precio,m.Id IdMarca, m.Descripcion Marca, c.Id IdCategoria, c.Descripcion Categoria " +
                    "from ARTICULOS A " +
                    "Join Marcas as m on A.IdMarca = M.Id " +
                    "Join CATEGORIAS as c on A.IdCategoria = C.Id");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id= (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Codigo = (int)datos.Lector["IdMarca"];
                    aux.Marca.Nombre = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Codigo = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Nombre = (string)datos.Lector["Categoria"];
                    aux.Precio = decimal.Round((decimal)datos.Lector["Precio"],2);
                    lista.Add(aux);
                }
                return lista;
        }
        
        public void agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valorTexto = articulo.Precio.ToString();
                valorTexto = Regex.Replace(valorTexto, "[,]", ".");
                datos.SetConsulta("Insert into articulos values(@codigo,@nombre,@descripcion,@idmarca,@idcategoria,@precio)");
                datos.setearParametro("@codigo", articulo.Codigo);
                datos.setearParametro("@nombre", articulo.Nombre);
                datos.setearParametro("@descripcion", articulo.Descripcion);
                datos.setearParametro("@idmarca", articulo.Marca.Codigo);
                datos.setearParametro("@idcategoria", articulo.Categoria.Codigo);
                datos.setearParametro("@precio", valorTexto);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetConsulta("delete from articulos where Id = @id");
                datos.setearParametro("@id", id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.SetConsulta("Update articulos set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idmarca, IdCategoria = @idcategoria, Precio = @precio where Id=@id");
                datos.setearParametro("@codigo", articulo.Codigo);
                datos.setearParametro("@nombre", articulo.Nombre);
                datos.setearParametro("@descripcion", articulo.Descripcion);
                datos.setearParametro("@idmarca", articulo.Marca.Codigo);
                datos.setearParametro("@idcategoria", articulo.Categoria.Codigo);
                datos.setearParametro("@precio", articulo.Precio);
                datos.setearParametro("@id", articulo.Id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
