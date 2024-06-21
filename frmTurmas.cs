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
    public partial class frmTurmas : Form
    {
        public string NomeProfessor { get; set; }
        public int IdProfessor { get; set; }
        
        public frmTurmas()
        {
            InitializeComponent();
        }

        private void frmTurmas_Load(object sender, EventArgs e)
        {
            lblNomeProfessor.Text = NomeProfessor;

            CarregarDados();
        }

        private void btnCadastrarTurma_Click(object sender, EventArgs e)
        {
            var form = new frmTurmaCadastrar();

            form.IdProfessor = IdProfessor;

            form.ShowDialog();
        }

        private void CarregarDados()
        {
            var servicoBanco = new ServicoBancoDados();

            var listaTurmas = servicoBanco.ObterTurmasDoProfessor(IdProfessor);

            gridTurmas.DataSource = listaTurmas;
        }
    }
}
