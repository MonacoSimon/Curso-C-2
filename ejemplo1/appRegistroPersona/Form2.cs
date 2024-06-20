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
        private void cargar()
        {
            PersonaNegocio negocio = new PersonaNegocio();
            try
            {
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvPersona.Columns["domicilio"].Visible = false;
        }

        

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmRegistroPersona))
                {
                    MessageBox.Show("termine de trabajar con la otra ventana");
                    return;
                }
            }
            frmRegistroPersona ventana = new frmRegistroPersona();
            ventana.Show();
        }

        private void registroPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroPersona alta = new frmRegistroPersona();
            alta.ShowDialog();
        }
    }
}
