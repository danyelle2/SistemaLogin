using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            InitializeComponent();
            this.FormClosing += AppClose;
        }

        private void btnPagina1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pagina1 pagina1 = new Pagina1();
            pagina1.Show();
        }

        private void btnPagina2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pagina2 pagina2 = new Pagina2();
            pagina2.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
        public void AppClose(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja encerrar a aplicação?", "Encerrar programa", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }
    }
}
