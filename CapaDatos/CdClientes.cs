using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CdClientes
    {
        
        public List<Cliente> Listar()

        {
            List<Cliente> lista = new List<Cliente>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("Select IdCliente, Documento, NombreCompleto, Correo, Telefono, Estado From Cliente ");



                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);

                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cliente()
                            {
                                IdCliente = Convert.ToInt32(dr["IdCliente"].ToString()),
                                Documento = (dr["Documento"]).ToString(),
                                NombreCompleto = (dr["NombreCompleto"]).ToString(),
                                Correo = (dr["Correo"]).ToString(),
                                Telefono = (dr["Telefono"]).ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])


                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Cliente>();

                }




            }
            return lista;
        }
        
    }
}

