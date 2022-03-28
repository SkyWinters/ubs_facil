using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WebApplication1.Model;
namespace WebApplication1.Controller
{
    public class CadastroPessoas
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public string CadastroPessoa(/*string nome, string cpf*/)
        {
            string retorno = cmd.CommandText = "SELECT * FROM TB_ADMIN"; 

            //cmd.Parameters.AddWithValue("",);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Cadastrado com Sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao conectar com BD";
            }
            return retorno;

        }
    }
}