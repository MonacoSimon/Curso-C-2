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

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hola mundo");
            string nombre = txtSaludar.Text;
            lblSaludar.Text = "hola " + nombre;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("te doy la bienvenida");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("gracias por usar la app");
        }

        
    }
}
