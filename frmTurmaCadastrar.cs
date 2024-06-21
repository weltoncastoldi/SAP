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
    public partial class frmTurmaCadastrar : Form
    {
        public int IdProfessor { get; set; }
        public frmTurmaCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeTurma.Text))
            {
                MessageBox.Show("Informe o nome da turma");
                return;
            }

            var servicoBanco = new ServicoBancoDados();

            var retorno = servicoBanco.CadastrarTurma(txtNomeTurma.Text, IdProfessor);

            if (retorno)
            {
                MessageBox.Show("Turma Cadastrada com sucesso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Não gravou no banco de dados");

            }
        }
    }
}
