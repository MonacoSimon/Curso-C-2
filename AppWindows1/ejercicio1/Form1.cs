using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("bienvenido!");
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Hasta la proxima!");
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("se hizo click!");
            //this.BackColor = Color.Blue;

            if (txtSaludo.Text == "")
                txtSaludo.BackColor = Color.Red;
            else
                txtSaludo.BackColor = System.Drawing.SystemColors.Control;
        }

        private void frmPrincipal_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("presiono el boton izquierdo, atencion");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("presiono el boton derecho, atencion");
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("presiono el boton del medio, atencion!");
        }

        private void lblSaludo_MouseMove(object sender, MouseEventArgs e)
        {
            lblSaludo.BackColor = Color.Cyan;
            lblSaludo.Cursor = Cursors.Hand;
        }

        private void lblSaludo_MouseLeave(object sender, EventArgs e)
        {
            lblSaludo.BackColor = System.Drawing.SystemColors.Control;
            lblSaludo.Cursor = Cursors.Arrow;
        }

        private void txtSaludo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtOtro_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("tiene " + txtOtro.Text.Length +" caracteres");
        }
    }
}
