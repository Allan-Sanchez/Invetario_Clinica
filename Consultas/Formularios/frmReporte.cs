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
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'newConsultaMedicaDataSet1.total_Costos' Puede moverla o quitarla según sea necesario.
            this.total_CostosTableAdapter1.Fill(this.newConsultaMedicaDataSet1.total_Costos);
            // TODO: esta línea de código carga datos en la tabla 'consultaMedicaDataSet.total_Costos' Puede moverla o quitarla según sea necesario.
            this.total_CostosTableAdapter.Fill(this.consultaMedicaDataSet.total_Costos);

            this.reportViewer1.RefreshReport();
        }
    }
}
