using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using RegistroNegocio;

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
                comando.CommandText = "SELECT p.Nombre, p.Apellido, p.FechaNacimiento, p.Dni, p.Email, p.EstadoCivil, d.Calle, d.Localidad, d.Provincia FROM Persona p JOIN Domicilio d ON p.Dni = d.DniPersona;";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Persona aux = new Persona();
                    Domicilio aux1 = new Domicilio();
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Apellido = (string)lector["Apellido"];
                    aux.FechaNacimiento = (DateTime)lector["FechaNacimiento"];
                    aux.Dni = (int)lector["Dni"];
                    aux.Email = (string)lector["Email"];
                    aux.calle = new Domicilio();
                    aux.localidad = new Domicilio();
                    aux.provincia = new Domicilio();
                    aux.provincia.Provincia = (string)lector["provincia"];
                    aux.calle.Calle = (string)lector["calle"];
                    aux.EstadoCivil = (string)lector["EstadoCivil"];
                    aux.localidad.Localidad = (string)lector["localidad"];

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

        public void agregar(Persona nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Inserción en la tabla Persona
                datos.setearConsulta("INSERT INTO Persona(Dni, Email, EstadoCivil, Nombre, Apellido, FechaNacimiento) VALUES(@Dni, @Email, @EstadoCivil, @Nombre, @Apellido, @FechaNacimiento)");
                datos.setearParametro("@Dni", nueva.Dni);
                datos.setearParametro("@Email", nueva.Email);
                datos.setearParametro("@EstadoCivil", nueva.EstadoCivil);
                datos.setearParametro("@Nombre", nueva.Nombre);
                datos.setearParametro("@Apellido", nueva.Apellido);
                datos.setearParametro("@FechaNacimiento", (DateTime)nueva.FechaNacimiento);
                datos.ejecutarAccion(); 
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

        public void agregarDomicilio(Domicilio domicilio, Persona nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO Domicilio(Calle, Numero, Piso, Depto, Localidad, Provincia, DniPersona) VALUES(@Calle, @Numero, @Piso, @Depto, @Localidad, @Provincia, @DniPersona)");
                datos.setearParametro("@Calle", domicilio.Calle);
                datos.setearParametro("@Numero", domicilio.Numero);
                datos.setearParametro("@Piso", domicilio.Piso);
                datos.setearParametro("@Depto", domicilio.Depto);
                datos.setearParametro("@Localidad", domicilio.Localidad);
                datos.setearParametro("@Provincia", domicilio.Provincia);
                datos.setearParametro("@DniPersona", nueva.Dni);
                datos.ejecutarAccion();
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

        public void modificar(Persona modificar)
        {

        }
    }
}
