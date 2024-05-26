using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDtp_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("la fecha seleccionada es: " + dtpFecha.Value.ToString("f"));

            DateTime feacha1;

            feacha1 = dtpFecha.Value;
            MessageBox.Show("la fecha seleccionada es: " + feacha1.ToString("f"));
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("la fecha seleccionada es: " + clFecha.SelectionStart.ToString("f"));

        }
    }
}
