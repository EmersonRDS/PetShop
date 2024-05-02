using System.Data.SqlClient;

namespace PetShop.src.Models
{
    internal class CodigoDeBarras
    {
        public int Id { get; set; }
        public int IdInsumo { get; set; }
        public string Barras { get; set; }

        public override string ToString()
        {
            return Barras;
        }

        public void CadastrarBarras()
        {
            ConexaoBD conexao = new ConexaoBD();
            SqlCommand comandoSql = new SqlCommand();
            try
            {
                comandoSql.Connection = conexao.AbrirConexaoBD();

                string inserirBarras = $"INSERT INTO BarrasInsumos (IdInsumo, CodBarras) VALUES ({IdInsumo}, '{Barras}')";
                comandoSql.CommandText = inserirBarras;
                comandoSql.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.FecharConexaoBD();
            }
        }

        public void ExcluirBarras()
        {
            ConexaoBD conexao = new ConexaoBD();
            SqlCommand comandoSql = new SqlCommand();
            try
            {
                comandoSql.Connection = conexao.AbrirConexaoBD();

                string deletarBarras = $"DELETE FROM BarrasInsumos WHERE id = {this.Id}";
                comandoSql.CommandText = deletarBarras;
                comandoSql.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.FecharConexaoBD();
            }
        }
    }
}
