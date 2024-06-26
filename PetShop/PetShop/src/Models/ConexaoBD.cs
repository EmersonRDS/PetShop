﻿using System.Data.SqlClient;

namespace PetShop.src.Models
{
    internal class ConexaoBD
    {
        SqlConnection conexao;

        public SqlConnection AbrirConexaoBD()
        {
            string stringDeConexao = "Data Source=<sua instância de bacno>;Initial Catalog=PetShop;Integrated Security=true";
            try
            {
                conexao = new SqlConnection(stringDeConexao);
                conexao.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conexao;
        }

        public void FecharConexaoBD()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public string BeginTran()
        {
            return "BEGIN TRAN";
        }

        public string RollBack()
        {
            return "ROLLBACK";
        }

        public string Commit()
        {
            return "COMMIT";
        }
    }

}
