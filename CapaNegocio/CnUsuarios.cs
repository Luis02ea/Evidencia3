using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio

{
    
    public class CnUsuarios
    {
        private CdUsuarios objed_usuarios = new CdUsuarios();
        public List<Usuarios> Listar()
        {
            return objed_usuarios.Listar();
        }
    }
    
}
