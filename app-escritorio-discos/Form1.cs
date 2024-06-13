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
using System.Net;

namespace Ejemplo_discos
{
    public partial class Form1 : Form
    {
        private List<Disco> listaDisco;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cargar();   
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public void cargar()
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                listaDisco = negocio.listar();
                dgvDiscos.DataSource = listaDisco;
                dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
                cargarimagen(listaDisco[0].UrlImagenTapa);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            cargarimagen(seleccionado.UrlImagenTapa);
        }
        private void cargarimagen(string imagen)
        {
            try
            {
                pbDiscos.Load(imagen);
            }
            
            catch(WebException ex)
            {
                MessageBox.Show("sin internet");
                Close();
            }
            catch (Exception)
            {

                pbDiscos.Load("https://clipground.com/images/image-placeholder-clipart-1.png");
            }
        }

        private void btnAltaDisco_Click(object sender, EventArgs e)
        {
            frmAltaDisco alta = new frmAltaDisco();
            alta.ShowDialog();
            cargar();
        }
    }
}
