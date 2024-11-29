using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using CapaEntidad;



namespace CapaDatos
{
    public class CdPermisos
    {
    
        
            public List<Permisos> Listar(int IdUsuario)

            {

                List<Permisos> lista = new List<Permisos>();
                using (SqlConnection oconexion = new SqlConnection(Conexion.Cadena))
                 {
                    try
                    {
                        StringBuilder query = new StringBuilder();
                        query.AppendLine("Select p.IdRol, p.NombreMenu From Permisos p");
                        query.AppendLine("inner join Rol r on r.IdRol = p.IdRol");
                        query.AppendLine("inner join Usuarios u on u.IdRol = r.IdRol");
                        query.AppendLine("where u.IdUsuario = @IdUsuario");

                        /*
                        Select p.IdRol, p.NombreMenu From Permisos p
                        inner join Rol r on r.IdRol = p.IdRol
                        inner join Usuarios u on u.IdRol = r.IdRol
                        where u.IdUsuario = 1
                        */
                        

                        SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                        cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                        cmd.CommandType = CommandType.Text;

                        oconexion.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                

                                lista.Add(new Permisos()
                                {
                                    oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"])},
                                    NombreMenu = dr["NombreMenu"].ToString(),


                                });
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        lista = new List<Permisos>();
                       
                    }




                }
                return lista;
            }

        }

   }

