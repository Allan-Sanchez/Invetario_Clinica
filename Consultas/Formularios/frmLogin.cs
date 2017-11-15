using Consultas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultas.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (!Login.Validar_Usuario(txtUsuario.Text,txtClave.Text))
            {
                MessageBox.Show(Login.Mensaje,"Error");
                txtUsuario.Focus();
                return;
            }

            UsuarioLogeado usuarioLogeado = Login.GetUsuarios(txtUsuario.Text);

            FrmInicial inicio = new FrmInicial();

            this.Hide();
            inicio.Usuario_LOgiado = usuarioLogeado;
            inicio.Show();



        }

        private bool ValidarCampos()
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debes ingresar un nombre de Usuario", "Error");
                txtUsuario.Focus();
                return false;
            }
            if (txtClave.Text == "")
            {
                MessageBox.Show("Debes ingresar una Clave de Usuario", "Error");
                txtClave.Focus();
                return false;
            }
            return true;
        }
    }
}
