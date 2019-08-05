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
    public partial class FrmLivroAutor : Form
    {
        public FrmLivroAutor()
        {
            InitializeComponent();
        }

        private void FrmLivroAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.LivroAutor' table. You can move, or remove it, as needed.
            this.livroAutorTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.LivroAutor);

        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livAutSelect = ((System.Data.DataRowView)
              this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
              as MVCProject.SistemaBibliotecaDBDataSet.LivroAutorRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    EditLivroAutor editLivroAutor = new EditLivroAutor();
                    editLivroAutor.LivroAutorRow = livAutSelect;
                    editLivroAutor.ShowDialog();

                    this.livroAutorTableAdapter.Update(editLivroAutor.LivroAutorRow);
                    break;
                case 1:

                    break;
            }
            this.livroAutorTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.LivroAutor);
        }

        private void btnAddLivAut_Click(object sender, EventArgs e)
        {
            AddLivroAutor addLivroAutor = new AddLivroAutor();
            addLivroAutor.ShowDialog();

            if (!string.IsNullOrEmpty(addLivroAutor.livroAutorRow?.Livro.ToString()))
                this.livroAutorTableAdapter.Insert(
                   addLivroAutor.livroAutorRow.Livro,
                   addLivroAutor.livroAutorRow.Autor
                   );

            this.livroAutorTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.LivroAutor);
        }
    }
}


