using Dapper;
using Sap_Saep.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
