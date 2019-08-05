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
    public partial class AddLivro : Form
    {
        public AddLivro()
        {
            InitializeComponent();
        }

        public Livro livroRow;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            livroRow = new Livro
            {
                Registro = (int)numericUpDown1.Value,
                Titulo = tbTitulo.Text,
                Isbn = tbIsbn.Text,
                Genero = (int)comboBoxGen.SelectedValue,
                Editora = (int)comboBoxGen.SelectedValue,
                Sinopse = tbSinopse.Text,
                Observacao = tbObserv.Text,
            };
            this.Close();
        }
    }
}
