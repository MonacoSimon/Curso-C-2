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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            LvElementos.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboFavorito.Items.Add("rojo");
            cboFavorito.Items.Add("verde");
            cboFavorito.Items.Add("gris");
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            //textBox
            string nombre = txtNombre.Text;
            //date time picker
            DateTime fecha = dtpFechaNacimiento.Value;
            //operador ternario y checked box
            string chocolate = chbChocolate.Checked == true ? "le gusta el chocolate" : "no le gusta el chocolate";
            //radio button
            string tipo;
            if (rdtMuggle.Checked)
                tipo = "mugle";
            else if (rdtSquibs.Checked)
                tipo = "squibs";
            else
                tipo = "wizard";
            //combo box
            string colorFavorito = cboFavorito.SelectedItem.ToString();
            //numeric>UpDown
            string NumeroFavorito = numNumeroFavorito.Value.ToString();

            string mensaje = chocolate + ", es " + tipo + ", su color es " + colorFavorito + ", su numero es: " + NumeroFavorito;
            MessageBox.Show("nombre: " + nombre + "fecha" + fecha + ", " + mensaje);
        }
    }
}
