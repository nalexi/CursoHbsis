namespace MVCProject.View.EditViews
{
    partial class EditUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(66, 83);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(202, 20);
            this.tbSenha.TabIndex = 4;
            this.tbSenha.TextChanged += new System.EventHandler(this.tbSenha_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(66, 110);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(202, 20);
            this.tbEmail.TabIndex = 5;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(66, 50);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(202, 20);
            this.tbLogin.TabIndex = 6;
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(66, 17);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(202, 20);
            this.tbNome.TabIndex = 7;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 146);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(256, 37);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // EditUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 191);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditUsuario";
            this.Text = "EditUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btnSalvar;
    }
}