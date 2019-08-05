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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Usuarios);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuarioSelect = ((System.Data.DataRowView)
              this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
              as MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.usuariosTableAdapter.DesativaQuery(usuarioSelect.Id);
                    break;
                case 1:
                    EditUsuario editUsuario = new EditUsuario();
                    editUsuario.UsuariosRow = usuarioSelect;
                    editUsuario.ShowDialog();

                    this.usuariosTableAdapter.Update(editUsuario.UsuariosRow);

                    break;
            }
            this.usuariosTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Usuarios);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUsuario addUsuario = new AddUsuario();
            addUsuario.ShowDialog();

            if (!string.IsNullOrEmpty(addUsuario.usuarioRow?.Nome))
                this.usuariosTableAdapter.Insert(
                   addUsuario.usuarioRow.Nome,
                   addUsuario.usuarioRow.Login,
                   addUsuario.usuarioRow.Senha,
                   addUsuario.usuarioRow.Email,
                   true,
                   1,
                   1,
                   DateTime.Now,
                   DateTime.Now
                   );

            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
        }
    }
}
