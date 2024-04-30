using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Insumo() { }
        public Insumo(string nome, string codBarras, string unidadeMedida, double Volume)
        {
            this.Nome = nome;
            this.CodBarras = codBarras;
            this.UnidadeMedida = unidadeMedida;
            this.Volume = Volume;
        }

        public List<Insumo> ListarInsumos()
        {
            List<Insumo> ListaInsumo = new List<Insumo>();

            string comando = "SELECT DISTINCT TOP 100 I.*, STRING_AGG(barras.CodBarras, ' , ') AS CodigosBarras " +
                "FROM Insumos as I " +
                "INNER JOIN BarrasInsumos as barras ON I.id = barras.IdInsumo " +
                "GROUP BY I.id, I.Custo, I.Estoque, I.Nome, I.UnidadeMedida, I.Volume";

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
                    i.CodBarras = reader["CodigosBarras"].ToString();
                    i.Estoque = Convert.ToDouble(reader["Estoque"].ToString());
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

        public List<Insumo> ListarInsumoComFiltro(string conteudo, string filtro)
        {
            List<Insumo> ListaInsumos = new List<Insumo>();

            string comando = "SELECT DISTINCT TOP 100 I.*, STRING_AGG(barras.CodBarras, ' , ') AS CodigosBarras " +
                "FROM Insumos as I " +
                "INNER JOIN BarrasInsumos as barras ON I.id = barras.IdInsumo ";

            switch (filtro)
            {
                case "Nome":
                    comando += $"WHERE I.Nome like '%{conteudo}%' ";
                    break;
                case "Cod. Barras":
                    comando += $"WHERE barras.CodBarras like '%{conteudo}%' ";
                    break;

            }

            comando+="GROUP BY I.id, I.Custo, I.Estoque, I.Nome, I.UnidadeMedida, I.Volume ";
                

            
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
                    i.CodBarras = reader["CodigosBarras"].ToString();
                    i.Estoque = Convert.ToDouble(reader["Estoque"].ToString());
                    i.UnidadeMedida = reader["UnidadeMedida"].ToString();
                    i.Volume = Convert.ToDouble(reader["Volume"].ToString());
                    ListaInsumos.Add(i);
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
            return ListaInsumos;
        }

        public bool ConsultaInsumo(int idInsumo)
        {
            string comando = $"SELECT DISTINCT I.*, STRING_AGG(barras.CodBarras, ' , ') AS CodigosBarras " +
                "FROM Insumos as I " +
                "INNER JOIN BarrasInsumos as barras ON I.id = barras.IdInsumo " +
                $"WHERE I.id = {idInsumo} " +
                $"GROUP BY I.id, I.Custo, I.Estoque, I.Nome, I.UnidadeMedida, I.Volume ";

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
                        this.Estoque = Convert.ToDouble(reader["Estoque"].ToString());
                        this.UnidadeMedida = reader["UnidadeMedida"].ToString();
                        this.Volume = Convert.ToDouble(reader["Volume"].ToString());
                        this.CodBarras = reader["CodigosBarras"].ToString();
                    }
                }
                else
                {
                    throw new Exception($"Insumo Id {idInsumo} não encontrado");
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexao.FecharConexaoBD();
            }
        }

        public string PreparaValores()
        {
            string comando = "";
            //Nome
            comando += $"'{Nome}',";
            //Custo
            comando += " 0,";
            //Estoque
            comando += " 0,";
            //UnidadeMedida
            comando += $"'{UnidadeMedida}',";
            //Volume
            comando += $"{Volume}";

            return comando;
        }

        public void CadastrarInsumo()
        {
            ConexaoBD conexao = new ConexaoBD();
            SqlCommand comandoSql = new SqlCommand();
            try
            {
                comandoSql.Connection = conexao.AbrirConexaoBD();
                //begin tran
                comandoSql.CommandText = conexao.BeginTran();
                comandoSql.ExecuteNonQuery();

                string campos = "Nome, Custo, Estoque, UnidadeMedida, Volume";
                string valores = PreparaValores();

                string comando = $"INSERT INTO Insumos ({campos}) VALUES ({valores}); SELECT SCOPE_IDENTITY();";

                comandoSql.CommandText = comando;

                //executa e coleta o ID
                int idInsumo = Convert.ToInt32(comandoSql.ExecuteScalar());
                string[] barras = CodBarras.Split(" ; ");
                foreach (var item in barras)
                {
                    if (!String.IsNullOrWhiteSpace(item.ToString()))
                    {
                        string inserirBarras = $"INSERT INTO BarrasInsumos (IdInsumo, CodBarras) VALUES ({idInsumo}, '{item}')";
                        comandoSql.CommandText = inserirBarras;
                        comandoSql.ExecuteNonQuery();
                    }
                }

                //commit
                comandoSql.CommandText = conexao.Commit();
                comandoSql.ExecuteNonQuery();
                MessageBox.Show("Insumo Cadastrado!");
            }
            catch (Exception ex)
            {
                //Rollback
                comandoSql.CommandText = conexao.RollBack();
                comandoSql.ExecuteNonQuery();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.FecharConexaoBD();
            }
        }
    }
}
