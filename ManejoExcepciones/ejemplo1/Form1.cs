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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;
            try
            {

                n1 = int.Parse(txtNumero1.Text);
                n2 = int.Parse(txtNumero2.Text);
                n3 = n1 + n2;

                lblResultado.Text = "EL RESULTADO ES: " + n3.ToString();

            }
            catch (FormatException ex)
            {
                MessageBox.Show("no seas boludo flaco, ingresa un numero.");
                MessageBox.Show(ex.ToString());
                
            }
            

        }
    }
}
