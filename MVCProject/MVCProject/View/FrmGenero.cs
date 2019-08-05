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
    public partial class FrmGenero : Form
    {
        public FrmGenero()
        {
            InitializeComponent();
        }

        private void FrmGenero_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

        }

        private void BtnAddGenero_Click(object sender, EventArgs e)
        {
            AddGenero addGenero = new AddGenero();
            addGenero.ShowDialog();

            if (!string.IsNullOrEmpty(addGenero.generoRow?.Tipo.ToString()))
                this.generosTableAdapter.Insert(
                   addGenero.generoRow.Tipo,
                   addGenero.generoRow.Descricao,
                   addGenero.generoRow.Editora
                   );

            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var generoSelect = ((System.Data.DataRowView)
              this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
              as MVCProject.SistemaBibliotecaDBDataSet.GenerosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    EditGenero editgenero = new EditGenero();
                    editgenero.GenerosRow = generoSelect;
                    editgenero.ShowDialog();

                    this.generosTableAdapter.Update(editgenero.GenerosRow);
                    break;
            }
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
        }
    }
}
