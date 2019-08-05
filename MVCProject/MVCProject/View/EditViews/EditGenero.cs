using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.EditViews
{
    public partial class EditGenero : Form
    {
        public EditGenero()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.GenerosRow GenerosRow;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            GenerosRow.Tipo = tbAddTipo.Text;
            GenerosRow.Descricao = tbEditDesc.Text;
            GenerosRow.Editora = comboBox1.SelectedValue.ToString();
            this.Close();
        }

        private void EditGenero_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

        }
    }
}
