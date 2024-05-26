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
            int resultado;
            
            try
            {
                resultado = calcular();
                lblResultado.Text = "EL RESULTADO ES: " + resultado;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ingresar solo numeros");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
             
            }
        }
        private int calcular()
        {
            int n1, n2, n3;
            try
            {
                n1 = int.Parse(txtNumero1.Text);
                n2 = int.Parse(txtNumero2.Text);
                n3 = n1 + n2;
                return n3;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
