using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHenriquez01.VISTA
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        public String usuarioEstado;

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            label1.Text = usuarioEstado;
        }

        private void clickParaMasInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAd = new FrmAcercaDe();
            frmAd.MdiParent = this;
            frmAd.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaVisualDeusuario frmLvu = new FrmListaVisualDeusuario();
            frmLvu.MdiParent = this;
            frmLvu.Show();
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmOp = new FrmOperaciones();
            frmOp.MdiParent = this;
            frmOp.btnResta.Enabled = false;



            frmOp.Show();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmOp = new FrmOperaciones(); //Utilisar Modifaller
            frmOp.MdiParent = this;
            frmOp.btnSuma.Enabled = false;



            frmOp.Show();
        }
    }
}
