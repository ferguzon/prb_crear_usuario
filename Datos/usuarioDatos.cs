using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class usuarioDatos
    {

        public void InsertarUsuarioDatos(Entidad.tblusuario usuario)
        {

            Entidad.dbpruebaEntities dc = null;

            try
            {

                dc = new Entidad.dbpruebaEntities();
                dc.tblusuario.Add(usuario);
                dc.SaveChanges();

            }
            catch (Exception err)
            {

                throw err;
            } // try

        } // fin del insertar

        public Entidad.tblusuario ObtenerUsuarioDatos(string loginUsuario)
        {

            Entidad.dbpruebaEntities dc = null;
            Entidad.tblusuario usuario = null;

            try
            {

                dc = new Entidad.dbpruebaEntities();
                usuario = dc.tblusuario.Where(u => u.loginUsuario == loginUsuario).First();

                return usuario;

            }
            catch (Exception err)
            {

                throw err;
            }

        } // fin del obtener usuario

        public void ActualizarUsuarioDatos(Entidad.tblusuario usuario)
        {

            Entidad.dbpruebaEntities dc = null;
            Entidad.tblusuario usuarioActualizar = null;

            try
            {

                dc = new Entidad.dbpruebaEntities();
                usuarioActualizar = new Entidad.tblusuario();

                usuarioActualizar = dc.tblusuario.Where(u => u.idUsuario == usuario.idUsuario).First();

                usuarioActualizar.nombreUsuario = usuario.nombreUsuario;
                usuarioActualizar.loginUsuario = usuario.loginUsuario;
                usuarioActualizar.claveUsuario = usuario.claveUsuario;
                usuarioActualizar.fechaModificacionUsuario = DateTime.Today;

                dc.SaveChanges();
                
            }
            catch (Exception err)
            {

                throw err;
            } // try

        } // fin del actualizar

        public List<Entidad.tblusuario> ObtenerUsuarioDatos()
        {

            Entidad.dbpruebaEntities dc = null;
            List<Entidad.tblusuario> lista = null;

            try
            {
                dc = new Entidad.dbpruebaEntities();
                lista = dc.tblusuario.ToList();

                return lista;

            }
            catch (Exception err)
            {

                throw err;
            }

        }
    }
}
