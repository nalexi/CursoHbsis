using MVCProject.View.AddViews;
using MVCProject.View.EditViews;
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
    public partial class FrmLivro : Form
    {
        public FrmLivro()
        {
            InitializeComponent();
        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Livros);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livroSelect = ((System.Data.DataRowView)
              this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
              as MVCProject.SistemaBibliotecaDBDataSet.LivrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.livrosTableAdapter.DesativaQuery(livroSelect.Id);
                    break;
                case 1:
                    EditLivro editLivro = new EditLivro();
                    editLivro.LivrosRow = livroSelect;
                    editLivro.ShowDialog();

                    this.livrosTableAdapter.Update(editLivro.LivrosRow);

                    break;
            }
            this.livrosTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Livros);
        }

        private void btnAddLivro_Click(object sender, EventArgs e)
        {
            AddLivro addLivro = new AddLivro();
            addLivro.ShowDialog();

            if (!string.IsNullOrEmpty(addLivro.livroRow?.Titulo))
                this.livrosTableAdapter.Insert(
                   addLivro.livroRow.Registro,
                   addLivro.livroRow.Titulo,
                   addLivro.livroRow.Isbn,
                   addLivro.livroRow.Genero,
                   addLivro.livroRow.Editora,
                   addLivro.livroRow.Sinopse,
                   addLivro.livroRow.Observacao,
                   true,
                   1,
                   1,
                   DateTime.Now,
                   DateTime.Now
                   );

            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
        }
    }
}
