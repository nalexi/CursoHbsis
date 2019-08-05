using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void locaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocacao frmLocacao = new FrmLocacao();
            frmLocacao.ShowDialog();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutor frmAutor = new FrmAutor();
            frmAutor.ShowDialog();
        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenero frmGenero = new FrmGenero();
            frmGenero.ShowDialog();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLivro frmLivro = new FrmLivro();
            frmLivro.ShowDialog();
        }

        private void editorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditora frmEditora = new FrmEditora();
            frmEditora.ShowDialog();
        }
    }
}
