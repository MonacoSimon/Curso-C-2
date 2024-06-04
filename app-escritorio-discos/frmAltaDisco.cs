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

namespace Ejemplo_discos
{
    public partial class frmAltaDisco : Form
    {
        public frmAltaDisco()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Disco disco = new Disco();
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                disco.Titulo = txtbTitulo.Text;
                disco.CantidadCanciones = int.Parse(txtbCantidadCanciones.Text);
                disco.UrlImagenTapa = txtbUrlImagenTapa.Text;
                //disco.FechaLanzamiento = dtpFechaLanzamiento.Text;

                negocio.agregar(disco);
                MessageBox.Show("disco agregado correctamente");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
