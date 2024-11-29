using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using System.Data.SqlClient;
using System.Windows.Documents;

namespace WindowsFormsApp3
{
    public partial class Probar_conexion : Form
    {
        public Probar_conexion()
        {
            InitializeComponent();
        }

        public void Probar_conexion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                CdUsuarios cdUsuarios = new CdUsuarios();


                List<Usuarios> listaUsuarios = cdUsuarios.Listar();


                StringBuilder resultado = new StringBuilder();


                foreach (var usuario in listaUsuarios)
                {
                    resultado.AppendLine($"ID: {usuario.IdUsuario}, Documento: {usuario.Documento}, Nombre: {usuario.NombreCompleto}, Correo: {usuario.Correo}, Estado: {usuario.Estado}, Rol: {usuario.oRol.Descripcion}");
                }

                if (resultado.Length > 0)
                {
                    MessageBox.Show(resultado.ToString(), "Lista de Usuarios");
                }
                else
                {
                    MessageBox.Show("No se encontraron usuarios.", "Resultado");
                }
            }
            catch (SqlException ex)
            {
                // Aquí se imprime el error capturado
                Console.WriteLine("Error en la consulta SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error");
                Console.WriteLine(ex.Message); 
              
            }
            */

        }

        private void button12_Click(object sender, EventArgs e)
        {
            /*
            string connectionString = "Data Source=LEAG\\SQLEXPRESS;Initial Catalog=Db_PuntoDeVentas;Integrated Security=True;Encrypt=False;Trust Server Certificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }catch(SqlException sqlEx)
                {
                    MessageBox.Show($"Error SQL al conectar a la base de datos: {sqlEx.Message}\nError número: {sqlEx.Number}", "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                CdUsuarios cdUsuarios = new CdUsuarios();


                List<Usuarios> listaUsuarios = cdUsuarios.Listar();


                StringBuilder resultado = new StringBuilder();


                foreach (var usuarios in listaUsuarios)
                {
                    resultado.AppendLine($"IdCliente: {usuarios.IdUsuario}, Documento: {usuarios.Documento}, Nombre: {usuarios.NombreCompleto}, Correo: {usuarios.Correo}, Estado: {usuarios.Estado}, Rol: {usuarios.oRol.Descripcion}");
                }

                if (resultado.Length < 0)
                {
                    MessageBox.Show(resultado.ToString(), "Lista de Usuarios");
                }
                else
                {
                    MessageBox.Show("No se encontraron usuarios.", "Resultado");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error");
            }
            /*

            */
        }


        private void button11_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                CdRol cdRol = new CdRol();


                List<Rol> listarRol = cdRol.Listar();


                StringBuilder resultado = new StringBuilder();


                foreach (var Rol in listarRol)
                {
                    resultado.AppendLine($", Rol: {Rol.Descripcion}");
                }

                if (resultado.Length > 0)
                {
                    MessageBox.Show(resultado.ToString(), "Lista de Usuarios");
                }
                else
                {
                    MessageBox.Show("No se encontraron Roles.", "Resultado");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error");
            }
            */
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                CdPermisos cdPermisos = new CdPermisos();

                List<Permisos> ListarPermisos = cdPermisos.Listar();

                StringBuilder resultado = new StringBuilder();
            }
            catch
            {

            }
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                CdClientes cdClientes = new CdClientes();


                List<Cliente> listaClientes = cdClientes.Listar();


                StringBuilder resultado = new StringBuilder();


                foreach (var cliente in listaClientes)
                {
                    resultado.AppendLine($"IdCliente: {cliente.IdCliente}, Documento: {cliente.Documento}, Nombre: {cliente.NombreCompleto}, Correo: {cliente.Correo}, Estado: {cliente.Estado} ");
                }

                if (resultado.Length > 0)
                {
                    MessageBox.Show(resultado.ToString(), "Lista de Clientes");
                }
                else
                {
                    MessageBox.Show("No se encontraron Clientes.", "Resultado");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error");
            }
            */
        }
    }
}



    

