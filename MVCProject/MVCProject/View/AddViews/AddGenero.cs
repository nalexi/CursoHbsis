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
    public partial class AddGenero : Form
    {
        public AddGenero()
        {
            InitializeComponent();
        }

        public Genero generoRow;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            generoRow = new Genero
            {
                Tipo = tbAddTipo.Text,
                Descricao = tbAddDesc.Text,
                Editora = comboBox1.SelectedValue.ToString()
            };
            this.Close();
        }
    }
}
