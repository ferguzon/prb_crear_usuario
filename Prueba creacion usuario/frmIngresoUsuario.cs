using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Prueba_creacion_usuario
{
    public partial class frmIngresoUsuario : Form
    {
        public frmIngresoUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            if (tssEstado.Text == "Creando")
            {

                GuardarUsuario();
                limpiarFormulario();

            }
            else
            {

                ActualizarUsuario();
                limpiarFormulario();

            }
            

        } // fin del guardar

        public void GuardarUsuario()
        {

            Negocio.usuarioNegocio dc = null;
            Entidad.tblusuario usuario = null;

            try
            {

                dc = new Negocio.usuarioNegocio();
                usuario = new Entidad.tblusuario();

                usuario.nombreUsuario = txtNombreUsuario.Text.ToUpper().Trim();
                usuario.loginUsuario = txtLoginUsuario.Text.Trim();
                usuario.claveUsuario = CreateMD5(txtClaveUsuario.Text.Trim());
                usuario.fechaCreacionUsuario = DateTime.Today;
                usuario.fechaModificacionUsuario = DateTime.Today;

                dc.InsertarUsuarioNegocio(usuario);

                MessageBox.Show("La información se almacenó correctamente.");

            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrió un error al guardar");
            } // fin del try

        } // fin del método guardar

        public void ActualizarUsuario()
        {

            Negocio.usuarioNegocio dc = null;
            Entidad.tblusuario usuario = null;

            try
            {

                dc = new Negocio.usuarioNegocio();
                usuario = new Entidad.tblusuario();

                usuario.nombreUsuario = txtNombreUsuario.Text.ToUpper().Trim();
                usuario.loginUsuario = txtLoginUsuario.Text.Trim();
                //usuario.claveUsuario = CreateMD5(txtClaveUsuario.Text.Trim());
                usuario.fechaModificacionUsuario = DateTime.Today;
                usuario.idUsuario = int.Parse(tssIdUsuario.Text);

                dc.ActualizarUsuarioNegocio(usuario);

                MessageBox.Show("La información se almacenó correctamente.");

            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrió un error al guardar");
            } // fin del try

        } // fin del método actualizar

        protected static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            return sb.ToString();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

            limpiarFormulario();
            tssEstado.Text = "Creando";

        } // fin del nuevo

        public void limpiarFormulario()
        {

            txtClaveUsuario.Text = string.Empty;
            txtLoginUsuario.Text = string.Empty;
            txtNombreUsuario.Text = string.Empty;
            txtNombreUsuario.Focus();

        }

        private void tsMenuAgregar_Click(object sender, EventArgs e)
        {

            string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el login de usuario a buscar:", "Login a buscar", "user");

            Negocio.usuarioNegocio dc = null;
            Entidad.tblusuario usuario = null;
                        
            try
            {

                Cursor.Current = Cursors.WaitCursor;

                dc = new Negocio.usuarioNegocio();
                usuario = new Entidad.tblusuario();

                usuario = dc.ObtenerUsuarioDatos(input.ToString());
                txtNombreUsuario.Text = usuario.nombreUsuario;
                txtLoginUsuario.Text = usuario.loginUsuario;
                txtClaveUsuario.Text = usuario.claveUsuario;
                tssIdUsuario.Text = usuario.idUsuario.ToString();
                txtClaveUsuario.Enabled = false;

                Cursor.Current = Cursors.Arrow;

                tssEstado.Text = "Editando";

            }
            catch (Exception)
            {

                MessageBox.Show("El usuario no se encontró en la base de datos. Por favor verifique la información ingresada.", "Dato no encontrado");
                
            }

        }

        private void frmIngresoUsuario_Load(object sender, EventArgs e)
        {

            tssEstado.Text = "Creando";
           
            //tsMenu.ImageScalingSize = new Size(40, 40);

        }

        private void txtClaveUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

           

        }

        private void clicAceptar(KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {

                

            }


        }

        private void listadoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmReporteUsuario formReporte = new frmReporteUsuario();
            formReporte.Show();

        }
    }
}
