using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class PersonaNegocio
    {
        public List<Persona> listar()
        {
            List<Persona> lista = new List<Persona>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=RegistroPersona; integrated security=true";
                comando.CommandText = "select Nombre, Apellido, FechaNacimiento, Dni, Email, EstadoCivil from Datos";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Persona aux = new Persona();
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Apellido = (string)lector["Apellido"];
                    aux.FechaNacimiento = (DateTime)lector["FechaNacimiento"];
                    aux.Dni = (int)lector["Dni"];
                    aux.Email = (string)lector["Email"];
                    aux.EstadoCivil = (string)lector["EstadoCivil"];

                    lista.Add(aux);
                }
                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
