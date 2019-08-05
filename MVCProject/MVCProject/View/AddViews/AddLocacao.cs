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
    public partial class AddLocacao : Form
    {
        public AddLocacao()
        {
            InitializeComponent();
        }

        public Locacao locacaoRow;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            locacaoRow = new Locacao
            {
                Livro = (int)comboBox1.SelectedValue,
                Usuario = (int)comboBoxUse.SelectedValue,
                Tipo = (int)numericUpDown1.Value,
                Devolucao = dateTimePicker1.Value
            };
            this.Close();
        }
    }
}
