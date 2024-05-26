using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            string direccion = txtDireccion.Text;
            lbAceptar.Items.Add(apellido);
            lbAceptar.Items.Add(edad);
            lbAceptar.Items.Add(nombre);
            lbAceptar.Items.Add(direccion);
        }
    }
}
