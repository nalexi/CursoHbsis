namespace MVCProject.View.EditViews
{
    partial class EditLivro
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tbSinopse = new System.Windows.Forms.TextBox();
            this.tbObserv = new System.Windows.Forms.TextBox();
            this.tbIsbn = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.sistemaBibliotecaDBDataSet = new MVCProject.SistemaBibliotecaDBDataSet();
            this.editorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editorasTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.EditorasTableAdapter();
            this.generosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.GenerosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Editora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sinopse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Observacao";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.generosBindingSource;
            this.comboBox1.DisplayMember = "Tipo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "Id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.editorasBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "Id";
            // 
            // tbSinopse
            // 
            this.tbSinopse.Location = new System.Drawing.Point(104, 154);
            this.tbSinopse.Name = "tbSinopse";
            this.tbSinopse.Size = new System.Drawing.Size(155, 20);
            this.tbSinopse.TabIndex = 9;
            // 
            // tbObserv
            // 
            this.tbObserv.Location = new System.Drawing.Point(104, 182);
            this.tbObserv.Name = "tbObserv";
            this.tbObserv.Size = new System.Drawing.Size(155, 20);
            this.tbObserv.TabIndex = 10;
            // 
            // tbIsbn
            // 
            this.tbIsbn.Location = new System.Drawing.Point(104, 62);
            this.tbIsbn.Name = "tbIsbn";
            this.tbIsbn.Size = new System.Drawing.Size(155, 20);
            this.tbIsbn.TabIndex = 11;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(104, 33);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(155, 20);
            this.tbTitulo.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(104, 9);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(155, 20);
            this.numericUpDown1.TabIndex = 13;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 213);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(243, 45);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editorasBindingSource
            // 
            this.editorasBindingSource.DataMember = "Editoras";
            this.editorasBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // editorasTableAdapter
            // 
            this.editorasTableAdapter.ClearBeforeFill = true;
            // 
            // generosBindingSource
            // 
            this.generosBindingSource.DataMember = "Generos";
            this.generosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // generosTableAdapter
            // 
            this.generosTableAdapter.ClearBeforeFill = true;
            // 
            // EditLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 267);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.tbIsbn);
            this.Controls.Add(this.tbObserv);
            this.Controls.Add(this.tbSinopse);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditLivro";
            this.Text = "EditLivro";
            this.Load += new System.EventHandler(this.EditLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox tbSinopse;
        private System.Windows.Forms.TextBox tbObserv;
        private System.Windows.Forms.TextBox tbIsbn;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnSalvar;
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource editorasBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.EditorasTableAdapter editorasTableAdapter;
        private System.Windows.Forms.BindingSource generosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.GenerosTableAdapter generosTableAdapter;
    }
}