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
using CapaPresentacion;
using FontAwesome.Sharp;


namespace WindowsFormsApp3
{
    public partial class Inicio : Form
    {

        private static Usuarios UsuarioActual;
        private static IconMenuItem  MenuActivo = null;
        private static Form FormularioActivo = null;


        public Inicio(Usuarios objusuario = null)

        {
            if (objusuario == null) UsuarioActual = new Usuarios() { NombreCompleto = "Admin Predefinido", IdUsuario = 1 };

            else

                UsuarioActual = objusuario;
            

            InitializeComponent();
        }



        private void Inicio_Load(object sender, EventArgs e)
        {
            
            List<Permisos> ListaPermisos = new CnPermiso().Listar(UsuarioActual.IdUsuario);

            foreach (IconMenuItem iconmenu in MenuItems.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);

                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }


            }

            LabelUsuarioText.Text = UsuarioActual.NombreCompleto;
         
        }
       
        private void AbrirFormulario(IconMenuItem MenuItems, Form Formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.Black;

            }
            MenuItems.BackColor = Color.Silver;
            MenuActivo = MenuItems;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = Formulario;
            Formulario.TopLevel = false;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            Formulario.BackColor = Color.Black;
            panel2.Controls.Add(Formulario);
            Formulario.Show();



        }
        
        private void MenuInicioUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormUsuarios());

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SubmenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuInicioMantenimineto, new FormCategoria());
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuInicioMantenimineto, new FormProducto());
        }

        private void SubMenuRegistrar_Click(object sender, EventArgs e)
        {
           AbrirFormulario(MenuInicioVentas, new FormDetalleDeVentas());
        }

        private void SubMenuVerDetalle_Click(object sender, EventArgs e)
        {
         AbrirFormulario(MenuInicioVentas, new FormVentas());
        }

        private void SubMenurComprasRegistrarCompra_Click(object sender, EventArgs e)
        {
          AbrirFormulario(MenuInicioCompras, new FormDetalleDeCompras());
        }

        private void SubMenuComprasVerDetalles_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuInicioCompras, new FormDetalleDeCompras());
        }

        private void MenuInicioClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuInicioClientes, new FormClientes());
        }

        private void MenuInicioProvedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuInicioProvedores, new FormProvedores());

        }

        private void MenuInicioReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuInicioReportes, new FormReportes());
        }

        private void MenuInicioCompras_Click(object sender, EventArgs e)
        {

        }

        private void MenuInicioMantenimineto_Click(object sender, EventArgs e)
        {

        }

        private void MenuInicioVentas_Click(object sender, EventArgs e)
        {

        }

        private void MenuInicioAcercaDe_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuItems_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
