using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sap_Saep
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var bancoDados = new ServicoBancoDados();

            var professor = bancoDados.EfetuarLogin(txtEmail.Text, txtSenha.Text);

            if (professor == null)
            {
                MessageBox.Show("Usuário ou senha não encontrados");
            }

            var form = new frmTurmas();

            form.IdProfessor = professor.Id;
            form.NomeProfessor = professor.Nome;

            form.Show();
            this.Hide();
        }
    }
}
