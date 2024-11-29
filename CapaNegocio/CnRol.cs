using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    
    public class CnRol
    {
        private CdRol objecd_Rol = new CdRol();

        public List<Rol> Listar()
        {
            return objecd_Rol.Listar();
        }
    }
    
}
