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
    public partial class FrmEditora : Form
    {
        public FrmEditora()
        {
            InitializeComponent();
        }

        private void FrmEditora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

        }

        private void btnAddEditora_Click(object sender, EventArgs e)
        {
            AddEditora addEditora = new AddEditora();
            addEditora.ShowDialog();

            if (!string.IsNullOrEmpty(addEditora.editoraRow?.Nome))
                this.editorasTableAdapter.Insert(
                   addEditora.editoraRow.Nome,
                   addEditora.editoraRow.Descricao
                   );

            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var editorasSelect = ((System.Data.DataRowView)
              this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
              as MVCProject.SistemaBibliotecaDBDataSet.EditorasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    EditEditora editEditora = new EditEditora();
                    editEditora.EditorasRow = editorasSelect;
                    editEditora.ShowDialog();

                    this.editorasTableAdapter.Update(editEditora.EditorasRow);
                    break;
            }
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
        }
    }
}
