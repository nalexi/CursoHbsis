namespace MVCProject.View.EditViews
{
    partial class EditLocacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.sistemaBibliotecaDBDataSet = new MVCProject.SistemaBibliotecaDBDataSet();
            this.sistemaBibliotecaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.UsuariosTableAdapter();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Devolucao";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.livrosBindingSource;
            this.comboBox1.DisplayMember = "Titulo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "Id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.usuariosBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(78, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "Id";
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemaBibliotecaDBDataSetBindingSource
            // 
            this.sistemaBibliotecaDBDataSetBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            this.sistemaBibliotecaDBDataSetBindingSource.Position = 0;
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.sistemaBibliotecaDBDataSetBindingSource;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.sistemaBibliotecaDBDataSetBindingSource;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(78, 69);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(15, 122);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(263, 40);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // EditLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 172);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditLocacao";
            this.Text = "EditLocacao";
            this.Load += new System.EventHandler(this.EditLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource sistemaBibliotecaDBDataSetBindingSource;
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSalvar;
    }
}