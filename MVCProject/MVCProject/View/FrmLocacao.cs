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
    public partial class FrmLocacao : Form
    {
        public FrmLocacao()
        {
            InitializeComponent();
        }

        private void FrmLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Locacao);

        }

        private void btnLocacao_Click(object sender, EventArgs e)
        {
            AddLocacao addLocacao = new AddLocacao();
            addLocacao.ShowDialog();

          if (!string.IsNullOrEmpty(addLocacao.locacaoRow?.Livro.ToString()))
            this.locacaoTableAdapter.Insert(
               addLocacao.locacaoRow.Livro,
               addLocacao.locacaoRow.Usuario,
               addLocacao.locacaoRow.Tipo,
               DateTime.Now,
               true,
               1,
               1,
               DateTime.Now,
               DateTime.Now
               );

            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            var locacaoSelect = ((System.Data.DataRowView)
                 this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                 as MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.locacaoTableAdapter.DesativaQuery(locacaoSelect.Id);
                    break;
                case 1:
                    EditLocacao editLocacao = new EditLocacao();
                    editLocacao.LocacaoRow = locacaoSelect;
                    editLocacao.ShowDialog();

                    this.locacaoTableAdapter.Update(editLocacao.LocacaoRow);

                    break;
            }
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);

        }
    }
}
