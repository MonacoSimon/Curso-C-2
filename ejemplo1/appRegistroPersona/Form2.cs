using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace appRegistroPersona
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            PersonaNegocio negocio = new PersonaNegocio();
            dgvPersona.DataSource = negocio.listar();
        }
        private void ocultarColumnas()
        {
            dgvPersona.Columns["domicilio"].Visible = false;
        }
    }
}
