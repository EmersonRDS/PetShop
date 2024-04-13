using System.Data.SqlClient;

namespace PetShop.src.Models
{
    internal class ConexaoBD
    {
        SqlConnection conexao;

        public SqlConnection AbrirConexaoBD()
        {
            string stringDeConexao = "Data Source=DESKTOP-E10U5KO\\SQLEXPRESS;Initial Catalog=DB_Pet_teste;Integrated Security=true";
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
    }

}
