using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.AddViews
{
    public partial class AddUsuario : Form
    {
        public AddUsuario()
        {
            InitializeComponent();
        }

        public Usuario usuarioRow;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            usuarioRow = new Usuario
            {
                Nome = tbNome.Text,
                Login = tbLogin.Text,
                Senha = tbSenha.Text,
                Email = tbEmail.Text,
            };
            this.Close();
        }
    }
}
