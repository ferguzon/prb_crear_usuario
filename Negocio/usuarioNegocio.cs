using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class usuarioNegocio
    {

        public void InsertarUsuarioNegocio(Entidad.tblusuario usuario)
        {

            Datos.usuarioDatos dc = null;

            try
            {

                dc = new Datos.usuarioDatos();
                dc.InsertarUsuarioDatos(usuario);

            }
            catch (Exception err)
            {

                throw err;
            }

        } // fin de insertar

        public Entidad.tblusuario ObtenerUsuarioDatos(string loginUsuario)
        {

            Datos.usuarioDatos dc = null;
            Entidad.tblusuario usuario = null;

            try
            {

                dc = new Datos.usuarioDatos();
                usuario = dc.ObtenerUsuarioDatos(loginUsuario);

                return usuario;

            }
            catch (Exception err)
            {

                throw err;
            }

        } // fin del obtener usuario

        public void ActualizarUsuarioNegocio(Entidad.tblusuario usuario)
        {

            Datos.usuarioDatos dc = null;

            try
            {

                dc = new Datos.usuarioDatos();
                dc.ActualizarUsuarioDatos(usuario);

            }
            catch (Exception err)
            {

                throw err;
            }

        } // fin de insertar


    }
}
