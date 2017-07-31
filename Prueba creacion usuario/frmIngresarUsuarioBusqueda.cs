using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_creacion_usuario
{
    public partial class frmIngresarUsuarioBusqueda : Form
    {
        public frmIngresarUsuarioBusqueda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            datosUsuario nombre = new datosUsuario();
            nombre.nombreUsuario = txtNombreUsuario.Text;
            
        }
    }

    public class datosUsuario
    {

        public string nombreUsuario { get; set; }

    }
}
