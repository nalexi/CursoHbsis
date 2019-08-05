namespace MVCProject.View.AddViews
{
    partial class AddLivro
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbIsbn = new System.Windows.Forms.TextBox();
            this.tbObserv = new System.Windows.Forms.TextBox();
            this.tbSinopse = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBoxGen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(20, 218);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(243, 45);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(108, 14);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(155, 20);
            this.numericUpDown1.TabIndex = 28;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(108, 38);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(155, 20);
            this.tbTitulo.TabIndex = 27;
            // 
            // tbIsbn
            // 
            this.tbIsbn.Location = new System.Drawing.Point(108, 67);
            this.tbIsbn.Name = "tbIsbn";
            this.tbIsbn.Size = new System.Drawing.Size(155, 20);
            this.tbIsbn.TabIndex = 26;
            // 
            // tbObserv
            // 
            this.tbObserv.Location = new System.Drawing.Point(108, 187);
            this.tbObserv.Name = "tbObserv";
            this.tbObserv.Size = new System.Drawing.Size(155, 20);
            this.tbObserv.TabIndex = 25;
            // 
            // tbSinopse
            // 
            this.tbSinopse.Location = new System.Drawing.Point(108, 159);
            this.tbSinopse.Name = "tbSinopse";
            this.tbSinopse.Size = new System.Drawing.Size(155, 20);
            this.tbSinopse.TabIndex = 24;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(108, 131);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 21);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.ValueMember = "Id";
            // 
            // comboBoxGen
            // 
            this.comboBoxGen.DisplayMember = "Tipo";
            this.comboBoxGen.FormattingEnabled = true;
            this.comboBoxGen.Location = new System.Drawing.Point(108, 100);
            this.comboBoxGen.Name = "comboBoxGen";
            this.comboBoxGen.Size = new System.Drawing.Size(155, 21);
            this.comboBoxGen.TabIndex = 22;
            this.comboBoxGen.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Observacao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Sinopse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Editora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Registro";
            // 
            // AddLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 280);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.tbIsbn);
            this.Controls.Add(this.tbObserv);
            this.Controls.Add(this.tbSinopse);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBoxGen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddLivro";
            this.Text = "AddLivro";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbIsbn;
        private System.Windows.Forms.TextBox tbObserv;
        private System.Windows.Forms.TextBox tbSinopse;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBoxGen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}