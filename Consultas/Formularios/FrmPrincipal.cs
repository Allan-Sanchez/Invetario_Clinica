using Consultas.Clases;
using Consultas.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultas
{
    public partial class FrmPrincipal : Form
    {

        public bool nuevo = false;
        public int posicion;


        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'consultaMedicaDataSet.total_Costos' Puede moverla o quitarla según sea necesario.
            this.total_CostosTableAdapter.Fill(this.consultaMedicaDataSet.total_Costos);

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            id_CosultaTextBox.Text = "";
            medicoTextBox.Focus();
            HabilitarCampos();
            LimpiarCampos();

        }

        private void LimpiarCampos()
        {
            medicoTextBox.Text = "";
            nombresTextBox.Text = "";
            consultaTextBox.Text = "";
            costoTextBox.Text = "";
            otros_CostosTextBox.Text = "";
            observaconesTextBox.Text = "";
        }

        private void HabilitarCampos()
        {
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;

            tsbNuevo.Enabled = false;
            tsbEditar.Enabled = false;
            tsbCancelar.Enabled = true;
            tsbGuardar.Enabled = true;
            tsbBuscar.Enabled = false;
            tsbEliminar.Enabled = false;

            fecha_ConsultaDateTimePicker.Enabled = true;
            medicoTextBox.Enabled = true;
            nombresTextBox.Enabled = true;
            consultaTextBox.Enabled = true;
            costoTextBox.Enabled = true;
            otros_CostosTextBox.Enabled = true;
            observaconesTextBox.Enabled = true;
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            this.total_CostosTableAdapter.Fill(this.consultaMedicaDataSet.total_Costos);

        }

        private void DesabilitarCampos()
        {

            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;

            tsbNuevo.Enabled = true;
            tsbEditar.Enabled = true;
            tsbCancelar.Enabled = false;
            tsbGuardar.Enabled = false;
            tsbBuscar.Enabled = true;
            tsbEliminar.Enabled = true;

            fecha_ConsultaDateTimePicker.Enabled = false;
            medicoTextBox.Enabled = false;
            nombresTextBox.Enabled = false;
            consultaTextBox.Enabled = false;
            costoTextBox.Enabled = false;
            otros_CostosTextBox.Enabled = false;
            observaconesTextBox.Enabled = false;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            fecha_ConsultaDateTimePicker.Focus();
            posicion = total_CostosBindingSource.Position;
            HabilitarCampos();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rpt = MessageBox.Show("Esta seguro de eliminar al paciente de la tabla", "Confirmacion", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rpt == DialogResult.No) return;

            Consulta_Paciente.DeleteConsulta(Convert.ToInt32(id_CosultaTextBox.Text));
            MessageBox.Show("Paciente eliminado con exito", "Confirmacion");
            DesabilitarCampos();
            ActualizarDatos();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            if (nuevo)
            {
                Consulta_Paciente.InsertConsulta(medicoTextBox.Text, nombresTextBox.Text, consultaTextBox.Text, Convert.ToDecimal(costoTextBox.Text),
                    Convert.ToDecimal(otros_CostosTextBox.Text), fecha_ConsultaDateTimePicker.Value, observaconesTextBox.Text);
            }
            else
            {
                Consulta_Paciente.UpdateConsulta(medicoTextBox.Text, nombresTextBox.Text, consultaTextBox.Text, Convert.ToDecimal(costoTextBox.Text),
                    Convert.ToDecimal(otros_CostosTextBox.Text), fecha_ConsultaDateTimePicker.Value, observaconesTextBox.Text, Convert.ToInt32(id_CosultaTextBox.Text));
            }

            MessageBox.Show("Cambios realizados con exito", "Confirmacion");
            ActualizarDatos();
            DesabilitarCampos();
            if (!nuevo)
            {
                total_CostosBindingSource.Position = posicion;
            }
            

        }

        private bool ValidarCampos()
        {
            if (medicoTextBox.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre de el medico que atendio al paciente", "Error");
                medicoTextBox.Focus();
                return false;
            }
            if (nombresTextBox.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre de el paciente", "Error");
                nombresTextBox.Focus();
                return false;
            }
            if (consultaTextBox.Text == "")
            {
                MessageBox.Show("Debe ingresar el motivo de la consulta del paciente", "Error");
                consultaTextBox.Focus();
                return false;
            }
            if (costoTextBox.Text == "")
            {
                MessageBox.Show("Debe ingresar un Costo ", "Error");
                costoTextBox.Focus();
                return false;
            }
            if (otros_CostosTextBox.Text == "")
            {
                MessageBox.Show("Debe si no tiene otro costo el paciente por favor coloque [0] en la casilla", "Error");
                otros_CostosTextBox.Focus();
                return false;

            }
            if (!Utilidades.ValidarDecimal(costoTextBox.Text))
            {
                MessageBox.Show("Debe ingresar un Costo mayor a Cero", "Error");
                costoTextBox.Text = "";
                costoTextBox.Focus();
                return false;

            }

            if (!Utilidades.Numero_Mayor_Cero(costoTextBox.Text))
            {
                MessageBox.Show("Debe ingresar un Costo mayor a Cero", "Error");
                costoTextBox.Text = "";
                costoTextBox.Focus();
                return false;
            }
            if (!Utilidades.Numero_Mayor_Cero(otros_CostosTextBox.Text))
            {

                MessageBox.Show("Si no tiene otros costo debe colocar el numero {0}", "Error");
                otros_CostosTextBox.Text = "";
                otros_CostosTextBox.Focus();
                return false;
            }
            return true;

        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar_Consulta mibusqueda = new frmBuscar_Consulta();

            mibusqueda.ShowDialog();

            if (mibusqueda.Id_consulta == 0) return;

            total_CostosBindingSource.Position = total_CostosBindingSource.Find("id_Cosulta", mibusqueda.Id_consulta);

        }
    }
}
