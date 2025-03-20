namespace SistemaLogin
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtSenhaa = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.blMensagem = new System.Windows.Forms.Label();
            this.iblMensagem = new System.Windows.Forms.Label();
            this.iblMensage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(276, 298);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 35);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.AutoSize = true;
            this.txtSenha.BackColor = System.Drawing.Color.Transparent;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(159, 205);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(56, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "Senha";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(153, 137);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtSenhaa
            // 
            this.txtSenhaa.Location = new System.Drawing.Point(153, 239);
            this.txtSenhaa.Name = "txtSenhaa";
            this.txtSenhaa.PasswordChar = '*';
            this.txtSenhaa.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaa.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(159, 105);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(64, 20);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Text = "Usuário";
            // 
            // blMensagem
            // 
            this.blMensagem.AutoSize = true;
            this.blMensagem.Location = new System.Drawing.Point(738, 35);
            this.blMensagem.Name = "blMensagem";
            this.blMensagem.Size = new System.Drawing.Size(0, 13);
            this.blMensagem.TabIndex = 5;
            // 
            // iblMensagem
            // 
            this.iblMensagem.AutoSize = true;
            this.iblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.iblMensagem.Location = new System.Drawing.Point(589, 74);
            this.iblMensagem.Name = "iblMensagem";
            this.iblMensagem.Size = new System.Drawing.Size(10, 13);
            this.iblMensagem.TabIndex = 6;
            this.iblMensagem.Text = ".";
            // 
            // iblMensage
            // 
            this.iblMensage.AutoSize = true;
            this.iblMensage.ForeColor = System.Drawing.Color.Red;
            this.iblMensage.Location = new System.Drawing.Point(129, 272);
            this.iblMensage.Name = "iblMensage";
            this.iblMensage.Size = new System.Drawing.Size(10, 13);
            this.iblMensage.TabIndex = 7;
            this.iblMensage.Text = ".";
            this.iblMensage.Click += new System.EventHandler(this.iblMensage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 404);
            this.Controls.Add(this.iblMensage);
            this.Controls.Add(this.iblMensagem);
            this.Controls.Add(this.blMensagem);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenhaa);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label txtSenha;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtSenhaa;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.Label blMensagem;
        private System.Windows.Forms.Label iblMensagem;
        private System.Windows.Forms.Label iblMensage;
    }
}

