﻿using System;
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
                datos.setearConsulta("select D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Estilo, T.Descripcion TipoEdicion, D.IdEstilo, D.IdTipoEdicion from DISCOS D, ESTILOS E, TIPOSEDICION T where E.Id = IdEstilo AND T.Id = IdTipoEdicion");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantCanciones = (int)datos.Lector["CantidadCanciones"];
                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                    {
                        aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];
                    }
                    aux.Estilo = new Estilo();
                    aux.Estilo.Id = (int)datos.Lector["Id"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.TipoEdicion = new TipoEdicion();
                    aux.TipoEdicion.Id = (int)datos.Lector["Id"];
                    aux.TipoEdicion.Descripcion = (string)datos.Lector["TipoEdicion"];

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
        public void agregar(Discos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into DISCOS(Id, Titulo, FechaLanzamiento, CantidadCanciones, IdEstilo, IdTipoEdicion, UrlImagenTapa) values ('" + nuevo.Id + "','" + nuevo.Titulo + "', '" + nuevo.FechaLanzamiento + "', '" + nuevo.CantCanciones + "', @IdEstilo, @IdTipo, @UrlImagen)");
                datos.setearParametros("@IdEstilo", nuevo.Estilo.Id);
                datos.setearParametros("@IdTipo", nuevo.TipoEdicion.Id);
                datos.setearParametros("@UrlImagen", nuevo.UrlImagenTapa);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}
        }
        public void modificar(Discos selecionado)
        {

        }

    }

    
}
