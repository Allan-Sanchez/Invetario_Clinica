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
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrincipal miprincipal = new FrmPrincipal();

            miprincipal.MdiParent = this;
            miprincipal.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios miUsuario = new frmUsuarios();

            miUsuario.MdiParent = this;
            miUsuario.Show();
        }

        private void costosTotalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCosto_Totales miscostos = new frmCosto_Totales();

            miscostos.MdiParent = this;
            miscostos.Show();
        }
    }
}
