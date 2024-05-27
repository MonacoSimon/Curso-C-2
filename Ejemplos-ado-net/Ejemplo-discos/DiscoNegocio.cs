using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejemplo_discos
{
    class DiscoNegocio
    {
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Titulo, FechaLanzamiento, CantidadCanciones, IdEstilo, UrlImagenTapa, t.Descripcion from DISCOS as d, TIPOSEDICION as t where d.Id = t.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = (string)lector["FechaLanzamiento"].ToString();
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];
                    aux.IdEstilo = (int)lector["IdEstilo"];
                    aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    aux.Descipcion = new TipoEdicion();
                    aux.Descipcion.Descripcion = (string)lector["Descripcion"];

                    lista.Add(aux);
                }
                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
