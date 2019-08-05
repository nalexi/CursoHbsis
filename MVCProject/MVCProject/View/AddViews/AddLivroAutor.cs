using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.AddViews
{
    public partial class AddLivroAutor : Form
    {
        public AddLivroAutor()
        {
            InitializeComponent();
        }

        public LivroAutor livroAutorRow;

        private void AddLivroAutor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Autores'. Você pode movê-la ou removê-la conforme necessário.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            livroAutorRow = new LivroAutor
            {
                Livro = (int)comboBox1.SelectedValue,
                Autor = (int)comboBoxAut.SelectedValue
            };
        }
    }
}
