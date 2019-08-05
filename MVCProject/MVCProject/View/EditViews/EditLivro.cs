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
    public partial class EditLivro : Form
    {
        public EditLivro()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow LivrosRow;

        private void EditLivro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            LivrosRow.Registro = (int)numericUpDown1.Value;
            LivrosRow.Titulo = tbTitulo.Text;
            LivrosRow.Isbn = tbIsbn.Text;
            LivrosRow.Genero = (int)comboBox1.SelectedValue;
            LivrosRow.Editora = (int)comboBox2.SelectedValue;
            LivrosRow.Sinopse = tbSinopse.Text;
            LivrosRow.Observacoes = tbObserv.Text;
            this.Close();
        }
    }
}
