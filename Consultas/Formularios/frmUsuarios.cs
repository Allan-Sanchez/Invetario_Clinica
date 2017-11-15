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
    public partial class frmUsuarios : Form
    {

        public bool nuevo = false;
        public int posicion;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultaMedicaDataSet);

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'consultaMedicaDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.consultaMedicaDataSet.Usuarios);

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            HabilitarCampos();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            usuarioTextBox.Text = "";
            claveTextBox.Text = "";
            nombreTextBox.Text = "";
            apellidoTextBox.Text = "";
            iD_PerfilTextBox.Text = "";
        }

        private void HabilitarCampos()
        {
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;

            tsbNuevo.Enabled = false;
            tsbEditar.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbEliminar.Enabled = false;

            usuarioTextBox.Enabled = true;
            claveTextBox.Enabled = true;
            nombreTextBox.Enabled = true;
            apellidoTextBox.Enabled = true;
            iD_PerfilTextBox.Enabled = true;

        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            this.usuariosTableAdapter.Fill(this.consultaMedicaDataSet.Usuarios);

        }

        private void DesabilitarCampos()
        {
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;

            tsbNuevo.Enabled = true;
            tsbEditar.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = true;

            usuarioTextBox.Enabled = false;
            claveTextBox.Enabled = false;
            nombreTextBox.Enabled = false;
            apellidoTextBox.Enabled = false;
            iD_PerfilTextBox.Enabled = false;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            usuarioTextBox.Focus();
            usuariosBindingSource.Position = posicion;
            HabilitarCampos();

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

            DialogResult rpt = MessageBox.Show("Esta seguro de eliminar al usuario de la tabla", "Confirmacion", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rpt == DialogResult.No) return;

            Usuarios.DeleteUsuario(usuarioTextBox.Text);
            MessageBox.Show("Usuario Eliminado con exito", "Confirmacion");
            DesabilitarCampos();
            ActualizarDatos();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            if (nuevo)
            {
                Usuarios.InsertUsuario(usuarioTextBox.Text, claveTextBox.Text, nombreTextBox.Text,
                    apellidoTextBox.Text, Convert.ToInt32(iD_PerfilTextBox.Text));
            }
            else
            {
                Usuarios.UpdateUsuario(usuarioTextBox.Text, claveTextBox.Text, nombreTextBox.Text,
                    apellidoTextBox.Text, Convert.ToInt32(iD_PerfilTextBox.Text));
            }
            MessageBox.Show("Cambios realizados con exito", "Confirmacion");
            DesabilitarCampos();
            ActualizarDatos();
            if (!nuevo)
            {
                usuariosBindingSource.Position = posicion;
            }
        }

        private bool ValidarCampos()
        {
            if (usuarioTextBox.Text == "")
            {
                MessageBox.Show("Debes ingresar un nombre de usuario");
                usuarioTextBox.Focus();
                return false;
            }
            if (claveTextBox.Text == "")
            {
                MessageBox.Show("Debes ingresar una clave de usuario");
                claveTextBox.Focus();
                return false;
            }
            if (nombreTextBox.Text == "")
            {
                MessageBox.Show("Debes ingresar un Nombre");
                nombreTextBox.Focus();
                return false;
            }
            if (apellidoTextBox.Text == "")
            {
                MessageBox.Show("Debes ingresar un Apellido");
                apellidoTextBox.Focus();
                return false;
            }
            if (iD_PerfilTextBox.Text == "")
            {
                MessageBox.Show("Debes ingresar un ID Perfil");
                iD_PerfilTextBox.Focus();
                return false;
            }
            if (Convert.ToInt32(iD_PerfilTextBox.Text) <= 0 || Convert.ToInt32(iD_PerfilTextBox.Text) >= 3)
            {
                MessageBox.Show("Debes ingresar un rol de usuario estos son {1} O {2} ");
                iD_PerfilTextBox.Text = "";
                iD_PerfilTextBox.Focus();
                return false;
            }
            return true;
        }
    }
}
