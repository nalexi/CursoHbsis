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
    public partial class EditAutor : Form
    {
        public EditAutor()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.AutoresRow AutoresRow;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
             AutoresRow.Nome = tbEditNome.Text;
             AutoresRow.Descricao = tbEditDesc.Text;
            this.Close();
        }

        private void EditAutor_Load(object sender, EventArgs e)
        {

        }
    }
}
