using Dapper;
using Sap_Saep.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Sap_Saep
{
    internal class ServicoBancoDados
    {
        public string StringConexao = "Data Source=CEPEAS21104022; Database=saep_db; Integrated Security=True;Connect Timeout=30;";

        public Professor EfetuarLogin(string email, string senha)
        {
            using(var conexao = new SqlConnection(StringConexao))
            {
                var sql = @"SELECT * FROM Professor 
                            WHERE 
                                Email = @email AND 
                                Senha = @senha";
                conexao.Open();

                var parametros = new DynamicParameters();
                parametros.Add("@email", email);
                parametros.Add("@senha", senha);

                var resultado = conexao.QueryFirstOrDefault<Professor>(sql, parametros);

                return resultado;
            }
        }

        public List<Turma> ObterTurmasDoProfessor(int professorId)
        {
            using(var conexao =new SqlConnection(StringConexao))
            {
                var sql = @"SELECT Id, Nome FROM Turma WHERE IdProfessor = @idProfessor";

                var parametros = new DynamicParameters();
                parametros.Add("@idProfessor", professorId);

                conexao.Open();

                var resultado = conexao.Query<Turma>(sql, parametros).ToList();

                return resultado;
            }
        }

        public bool CadastrarTurma(string nome, int professorId)
        {
            using(var conexao =new SqlConnection(StringConexao))
            {
                var sql = @"INSERT INTO Turma (Nome, IdProfessor)
                            VALUES(@nome, @idProfessor)";

                var parametros = new DynamicParameters();
                parametros.Add("@nome", nome);
                parametros.Add("@idProfessor", professorId);

                conexao.Open();

                var resultado = conexao.Execute(sql, parametros);

                return resultado > 0;
            }
        }
    }
}
