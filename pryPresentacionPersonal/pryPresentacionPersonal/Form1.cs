using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPresentacionPersonal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblPresentacion_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPresentar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = txtNombre.Text + " " + txtApellido.Text + " " + txtEdad.Text + " " + " " + txtCarrera.Text;
        }
    }
}
