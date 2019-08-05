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
    public partial class FrmAutor : Form
    {
        public FrmAutor()
        {
            InitializeComponent();
        }

        private void FrmAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);

        }

        private void btnAddAutor_Click(object sender, EventArgs e)
        {
            AddAutor addAutor = new AddAutor();
            addAutor.ShowDialog();

            if (!string.IsNullOrEmpty(addAutor.autorRow?.Nome))
                this.autoresTableAdapter.Insert(
                   addAutor.autorRow.Nome,
                   addAutor.autorRow.Descricao
                   );

            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var autoresSelect = ((System.Data.DataRowView)
              this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
              as MVCProject.SistemaBibliotecaDBDataSet.AutoresRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    EditAutor editAutor = new EditAutor();
                    editAutor.AutoresRow = autoresSelect;
                    editAutor.ShowDialog();

                    this.autoresTableAdapter.Update(editAutor.AutoresRow);
                    break;
            }
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
        }
    }
}
