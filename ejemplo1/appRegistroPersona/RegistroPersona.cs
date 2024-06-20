using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace appRegistroPersona
{
    public partial class frmRegistroPersona : Form
    {
        public frmRegistroPersona()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            PersonaNegocio negocio = new PersonaNegocio();
            Domicilio domicilio = new Domicilio();
            try
            {
                persona.Nombre = txtbNombre.Text;
                persona.Apellido = txtbApellido.Text;
                if (DateTime.TryParse(dtpFechaNacimiento.Text, out DateTime fechaNacimiento))
                {
                    persona.FechaNacimiento = fechaNacimiento;
                }
                else
                {
                    MessageBox.Show("El formato de la fecha no es válido.");
                    return; // Salir del método si la conversión falla
                }
                persona.Dni = int.Parse(txtbDNI.Text);
                persona.Email = txtbEmail.Text;
                if (rdbCasado.Checked)
                    persona.EstadoCivil = "Casado/a";
                else if (rdbSoltero.Checked)
                    persona.EstadoCivil = "Soltero/a";
                else if (rdbDivorciado.Checked)
                    persona.EstadoCivil = "Divorciado/a";
                domicilio.Calle = txtbCalle.Text;
                domicilio.Numero = int.Parse(txtbNumeroCalle.Text);
                domicilio.Piso = int.Parse(txtbPiso.Text);
                domicilio.Depto = int.Parse(txtbDepto.Text);
                domicilio.Localidad = txtbLocalidad.Text;
                domicilio.Provincia = txtbProvincia.Text;
                negocio.agregar(persona);
                negocio.agregarDomicilio(domicilio, persona);
                MessageBox.Show("agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
