using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Net;


namespace AccesoDB
{
    public class DiscosNegocio
    {
        public List<Discos> listar()
        {
            List<Discos> lista = new List<Discos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Estilo, T.Descripcion TipoEdicion from DISCOS D, ESTILOS E, TIPOSEDICION T where E.Id = IdEstilo AND T.Id = IdTipoEdicion");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["Fecha de Lanzamiento"];
                    aux.CantCanciones = (int)datos.Lector["Cantidad de Canciones"];
                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                    {
                        aux.UrlImagenTapa = (string)datos.Lector["Imagen de Tapa"];
                    }
                    aux.Estilo = new Estilo();
                    aux.Estilo.Id = (int)datos.Lector["Id"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.TipoEdicion = new TipoEdicion();
                    aux.TipoEdicion.Id = (int)datos.Lector["Id"];
                    aux.TipoEdicion.Descricion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
