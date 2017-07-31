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
    public partial class frmReporteUsuario : Form
    {
        public frmReporteUsuario()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmReporteUsuario_Load(object sender, EventArgs e)
        {

            Negocio.usuarioNegocio dc = null;

            try
            {

                dc = new Negocio.usuarioNegocio();

                dgvListaUsuarios.DataSource = dc.ObtenerListaUsuarioNegocio();
                dgvListaUsuarios.Refresh();

            }
            catch (Exception)
            {

                throw;
            }

            


        }
    }
}
