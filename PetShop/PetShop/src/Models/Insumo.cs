using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.src.Models
{
    internal class Insumo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Custo { get; set; }
        public string CodBarras { get; set; }
        public double Estoque{ get; set; }
        public string UnidadeMedida{ get; set; }
        public double Volume {  get; set; }


        public List<Insumo> ListarInsumos()
        {
            List<Insumo> ListaInsumo = new List<Insumo>();

            string comando = "SELECT TOP 100 * FROM Insumos";

            ConexaoBD conexao = new ConexaoBD();
            SqlCommand comandoSql = new SqlCommand();

            try
            {
                comandoSql.Connection = conexao.AbrirConexaoBD();

                comandoSql.CommandText = comando;

                SqlDataReader reader = comandoSql.ExecuteReader();

                while (reader.Read())
                {
                    Insumo i = new Insumo();
                    i.Id = Convert.ToInt32(reader["Id"]);
                    i.Nome = reader["Nome"].ToString();
                    i.Custo = Convert.ToDecimal(reader["Custo"].ToString());
                    i.CodBarras = reader["CodBarras"].ToString();
                    i.Estoque = Convert.ToDouble(reader["Nome"].ToString());
                    i.UnidadeMedida = reader["UnidadeMedida"].ToString();
                    i.Volume = Convert.ToDouble(reader["Volume"].ToString());
                    ListaInsumo.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.FecharConexaoBD();
            }

            return ListaInsumo;
        }

        public void ConsultaInsumo(int idInsumo)
        {
            string comando = $"SELECT * FROM Insumos WHERE id = {idInsumo}";

            ConexaoBD conexao = new ConexaoBD();
            SqlCommand comandoSql = new SqlCommand();


            try
            {
                comandoSql.Connection = conexao.AbrirConexaoBD();

                comandoSql.CommandText = comando;
                SqlDataReader reader = comandoSql.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.Id = Convert.ToInt32(reader["Id"]);
                        this.Nome = reader["Nome"].ToString();
                        this.Custo = Convert.ToDecimal(reader["Custo"].ToString());
                        this.Estoque = Convert.ToDouble(reader["Nome"].ToString());
                        this.UnidadeMedida = reader["UnidadeMedida"].ToString();
                        this.Volume = Convert.ToDouble(reader["Volume"].ToString());
                    }
                }
                else
                {
                    throw new Exception($"Insumo Id {idInsumo} não encontrado");
                }
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
