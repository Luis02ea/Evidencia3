using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    
    public class CnClientes
    {
        private CdClientes objed_Clientes = new CdClientes();
        public List<Cliente> Listar()
        {
            return objed_Clientes.Listar();
        }

    }
    
}
