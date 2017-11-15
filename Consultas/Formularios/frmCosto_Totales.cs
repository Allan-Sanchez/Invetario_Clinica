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
    public partial class frmCosto_Totales : Form
    {
       
        public frmCosto_Totales()
        {
            InitializeComponent();
        }

        private void frmCosto_Totales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'consultaMedicaDataSet.total_Costos' Puede moverla o quitarla según sea necesario.
            this.total_CostosTableAdapter.Fill(this.consultaMedicaDataSet.total_Costos);

            txtCosto.Text = String.Format("{0:C2}", Consulta_Paciente.Suma_Consultas());
            txtOtros_Costos.Text = String.Format("{0:C2}", Consulta_Paciente.Suma_Otros_Costos());
            txtTotal_Costos.Text = String.Format("{0:C2}", Consulta_Paciente.Suma_Total());
           txtTOTAL_IVA.Text = String.Format("{0:C2}", Consulta_Paciente.SUMA_CON_IVA());     

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult rpt = MessageBox.Show("Esta seguro de eliminar al paciente de la tabla", "Confirmacion", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rpt == DialogResult.No) return;

            Consulta_Paciente.DeleteConsulta(Convert.ToInt32(id_CosultaTextBox.Text));
            MessageBox.Show("Paciente eliminado con exito", "Confirmacion");
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            this.total_CostosTableAdapter.Fill(this.consultaMedicaDataSet.total_Costos);
            txtCosto.Text = String.Format("{0:C2}", Consulta_Paciente.Suma_Consultas());
            txtOtros_Costos.Text = String.Format("{0:C2}", Consulta_Paciente.Suma_Otros_Costos());
            txtTotal_Costos.Text = String.Format("{0:C2}", Consulta_Paciente.Suma_Total());
            txtTOTAL_IVA.Text = String.Format("{0:C2}", Consulta_Paciente.SUMA_CON_IVA());   
        }

        private void btnBorrar_Solo_uno_Click(object sender, EventArgs e)
        {
            DialogResult rpt = MessageBox.Show("Esta seguro de eliminar a todos  los pacientes de la tabla", "Confirmacion", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rpt == DialogResult.No) return;

            Consulta_Paciente.DeleteTodas_las_Consultas();
            MessageBox.Show("Datos Borrados Exitosamente", "Confirmacion");
            this.total_CostosTableAdapter.Fill(this.consultaMedicaDataSet.total_Costos);
            txtCosto.Text = "0";
            txtOtros_Costos.Text = "0";
            txtTotal_Costos.Text = "0";
            txtTOTAL_IVA.Text = "0";
        }


    }
}
