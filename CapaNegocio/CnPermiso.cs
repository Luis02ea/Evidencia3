using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    
    public class CnPermiso
    {
        private CdPermisos objecd_Permiso = new CdPermisos();

        public List <Permisos> Listar(int IdUsuario)
        {
            return objecd_Permiso.Listar(IdUsuario);
        }
    }
    
}
