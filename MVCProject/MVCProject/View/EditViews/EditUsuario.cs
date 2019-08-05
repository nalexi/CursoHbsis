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
    public partial class EditUsuario : Form
    {
        public EditUsuario()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow UsuariosRow;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuariosRow.Nome = tbNome.Text;
            UsuariosRow.Login = tbLogin.Text;
            UsuariosRow.Senha = tbSenha.Text;
            UsuariosRow.Email = tbEmail.Text;
            this.Close();
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
