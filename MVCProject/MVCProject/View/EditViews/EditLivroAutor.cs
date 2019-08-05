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
    public partial class EditLivroAutor : Form
    {
        public EditLivroAutor()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LivroAutorRow LivroAutorRow;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            LivroAutorRow.Livro = (int)comboBox1.SelectedValue;
            LivroAutorRow.Autor = (int)comboBoxAut.SelectedValue;
            this.Close();
        }
    }
}
