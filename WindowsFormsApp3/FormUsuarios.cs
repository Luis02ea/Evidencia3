using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using System.Windows.Media;



namespace CapaPresentacion

{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
           
            CbEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CbEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            CbEstado.DisplayMember = "Texto";
            CbEstado.ValueMember = "Valor";
            CbEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CnRol().Listar();

            foreach (Rol item in listaRol)
            {
                CbRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            CbRol.DisplayMember = "Texto";
            CbRol.ValueMember = "Valor";
            CbRol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in DgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    CbBuscarPor.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            CbBuscarPor.DisplayMember = "Texto";
            CbBuscarPor.ValueMember = "Valor";
            CbBuscarPor.SelectedIndex = 0;

            //Mostrar Usuarios

            List<Usuarios> listaUsuarios = new CnUsuarios().Listar();

            foreach (Usuarios item in listaUsuarios)
            {
                DgvData.Rows.Add(new object[] {"", 
                    item.IdUsuario,
                    item.Documento,
                    item.NombreCompleto,
                    item.Correo,
                    item.Clave,
                    item.oRol.IdRol,   
                    item.oRol.Descripcion,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No activo"
             
                    //select u.IdUsuario,u.Documento,u.NombreCompleto,u.Correo,u.Clave,u.Estado, r.IdRol,r.Descripcion
                      //  From usuarios u inner join rol r on r.IdRol = u.IdRol 
                     
                });

            }


        }

       
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DgvData.Rows.Add(new object[] {"",textid.Text, TxtNoDocumentoUsua.Text, TxtNombreCompletoUsua.Text, 
                TxtCorreoUsua.Text, TxtClaveUsua.Text,
            ((OpcionCombo)CbRol.SelectedItem).Valor.ToString(),
            ((OpcionCombo)CbRol.SelectedItem).Texto.ToString(),
            ((OpcionCombo)CbEstado.SelectedItem).Valor.ToString(),
            ((OpcionCombo)CbEstado.SelectedItem).Texto.ToString()
            });
            Limpiar();
        }
        private void Limpiar()
        {
            textid.Text = "0";
            TxtNoDocumentoUsua.Text = "";
            TxtNombreCompletoUsua.Text = "";
            TxtCorreoUsua.Text = "";
            TxtClaveUsua.Text = "";
            TxtConfirmarClaveUsua.Text = "";
            CbRol.SelectedIndex = 0;
            CbEstado.SelectedIndex = 0;

 

        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtNombreCompletoUsua_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNoDocumentoUsua_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
