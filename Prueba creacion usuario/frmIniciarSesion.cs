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
using System.Threading;

namespace Prueba_creacion_usuario
{
    public partial class frmIniciarSesion : Form
    {

        Thread th;

        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
                       

            Cursor.Current = Cursors.WaitCursor;

            if (txtLoginUsuario.Text != "")
            {

                Negocio.usuarioNegocio dc = null;
                Entidad.tblusuario usuario = null;

                try
                {

                    dc = new Negocio.usuarioNegocio();
                    usuario = dc.ObtenerUsuarioDatos(txtLoginUsuario.Text);

                    string clave = CreateMD5(txtClaveUsuario.Text.Trim());

                    if ((txtLoginUsuario.Text == usuario.loginUsuario) && (clave == usuario.claveUsuario))
                    {

                        //this.Hide();

                        //frmIngresoUsuario formIngreso = new frmIngresoUsuario();
                        //formIngreso.Show();

                        this.Close();
                        th = new Thread(openForm);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();


                    }
                    else
                    {

                        MessageBox.Show("El nombre de usuario o contraseña son incorrectos.");

                    }


                }
                catch (Exception)
                {

                    MessageBox.Show("Ocurrió un error al consultar la base de datos. Por favor verifique.");

                }// try

            }
            else
            {

                MessageBox.Show("El nombre de usuario está vacío.");

            } // if

            Cursor.Current = Cursors.Arrow;

        } // btnAceptar

        private void openForm()
        {

            Application.Run(new frmIngresoUsuario());

        }

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

        private void btnAceptar_KeyPress(object sender, KeyPressEventArgs e)
        {

         

        }

        private void txtLoginUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            clicAceptar(e);

        }

        private void txtClaveUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            clicAceptar(e);

        }

        private void clicAceptar(KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {

                btnAceptar.PerformClick();

            }


        }
    }
}
