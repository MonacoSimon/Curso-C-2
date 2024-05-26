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

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("termine de trabajar con la otra ventana");
                    return;
                }
            }

            Form1 venatana = new Form1();
            venatana.MdiParent = this;
            venatana.Show();
        }

        private void tsbPerfil_Click(object sender, EventArgs e)
        {
            Form1 venatana = new Form1();
            venatana.ShowDialog();
        }

        
    }
}
