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
    public partial class FrmInicial : Form
    {
        private UsuarioLogeado usuario_LOgiado;

        internal UsuarioLogeado Usuario_LOgiado
        {
            get { return usuario_LOgiado; }
            set { usuario_LOgiado = value; }
        }


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

        private void FrmInicial_Load(object sender, EventArgs e)
        {
            tsbUsuario.Text=usuario_LOgiado.nombre +" "+ usuario_LOgiado.apellido;

            EstableserPermisos();
        }

        private void EstableserPermisos()
        {
            if (usuario_LOgiado.id_perfil!=1)
            {
                procesosToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = false;
            }
        }


        private void FrmInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            salirToolStripMenuItem_Click(sender, e);
        }
    }
}
