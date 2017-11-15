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
    public partial class frmBuscar_Consulta : Form
    {
        private int id_consulta;

        public int Id_consulta
        {
            get { return id_consulta; }
            set { id_consulta = value; }
        }


        public frmBuscar_Consulta()
        {
            InitializeComponent();
        }

        private void frmBuscar_Consulta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'consultaMedicaDataSet.total_Costos' Puede moverla o quitarla según sea necesario.
            this.total_CostosTableAdapter.Fill(this.consultaMedicaDataSet.total_Costos);

        }

        private void fillByfecha_ConsultaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.total_CostosTableAdapter.FillByfecha_Consulta(this.consultaMedicaDataSet.total_Costos, ((System.DateTime)(System.Convert.ChangeType(fecha_ConsultaToolStripTextBox.Text, typeof(System.DateTime)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void fillByNombresCompletoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.total_CostosTableAdapter.FillByNombresCompleto(this.consultaMedicaDataSet.total_Costos, nombresToolStripTextBox.Text+"%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            id_consulta = 0;
            this.Close();
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {

            fecha_ConsultaToolStripTextBox.Text = "";
            nombresToolStripTextBox.Text = "";
            this.total_CostosTableAdapter.Fill(this.consultaMedicaDataSet.total_Costos);


        }

        private void btnAcentar_Click(object sender, EventArgs e)
        {
            if (dgvBusquedaConsulta.SelectedRows.Count > 0)
            {
                id_consulta = Convert.ToInt32(dgvBusquedaConsulta.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                id_consulta = Convert.ToInt32(dgvBusquedaConsulta.Rows[0].Cells[0].Value);
            }
            this.Close();
        }
    }
}
