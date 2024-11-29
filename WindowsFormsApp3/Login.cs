using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using System.Threading.Tasks;
//using Windows.Security.Credentials.UI;

namespace WindowsFormsApp3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        
        private async void iconButton1_Click(object sender, EventArgs e)

        {
         //   WindowsHelloHelper helloHelper = new WindowsHelloHelper();

            
           // bool isAuthenticated = await helloHelper.AuthenticateWithWindowsHelloAsync();

            //if (isAuthenticated)
            //{
                List<Usuarios> TEST = new CnUsuarios().Listar();
                Usuarios oUsuarios = new CnUsuarios().Listar().Where(u => u.Documento == TxtLoginUsuario.Text && u.Clave == TxtLoginClave.Text).FirstOrDefault();
                if (oUsuarios != null)
                {
                    Inicio form = new Inicio(oUsuarios);
                    form.Show();
                    this.Hide();
                    form.FormClosing += frm_closing;

                }

            //}
            else
            {
                MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        { 


            TxtLoginUsuario.Text = "";
            TxtLoginClave.Text = "";
            
            this.Show();

        }
        private void TxtLoginUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtLoginClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtLoginUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
