using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValidacaoLogin validacao = new ValidacaoLogin();
            if (validacao.Validar(txtUser.Text, txtSenhaa.Text))
            {
                this.Hide();

                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.Show();
            }
            else 
            {
                iblMensage.Text = "usuário ou senha inválido!";
            }
        }

        private void iblMensage_Click(object sender, EventArgs e)
        {

        }
    }
}
