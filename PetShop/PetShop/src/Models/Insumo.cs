using System.Data.SqlClient;

namespace PetShop.src.Models
{
    internal class Insumo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Custo { get; set; }
        public string CodBarras { get; set; }
        public List<CodigoDeBarras> ListaCodBarras = new List<CodigoDeBarras>();
        public double Estoque { get; set; }
        public string UnidadeMedida { get; set; }
        public double Volume { get; set; }
        private bool update = false;

        public Insumo() { }
        public Insumo(string nome, string codBarras, string unidadeMedida, double Volume)
        {
            this.Nome = nome;
            this.CodBarras = codBarras;
            this.UnidadeMedida = unidadeMedida;
            this.Volume = Volume;
        }

        public Insumo(int id,string nome, string unidadeMedida, double Volume)
        {
            this.Id = id;
            this.Nome = nome;
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

            comando += "GROUP BY I.id, I.Custo, I.Estoque, I.Nome, I.UnidadeMedida, I.Volume ";



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
            ListaCodBarras.Clear();
            string comando = $"SELECT * FROM Insumos WHERE id = {idInsumo} ";

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
                    }
                }
                else
                {
                    throw new Exception($"Insumo Id {idInsumo} não encontrado");
                }

                reader.Close();

                comando = $"SELECT * FROM BarrasInsumos WHERE IdInsumo = {idInsumo} ";

                comandoSql.CommandText = comando;
                reader = comandoSql.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CodigoDeBarras codigoDeBarras = new CodigoDeBarras();
                        codigoDeBarras.Id = Convert.ToInt32(reader["Id"]);
                        codigoDeBarras.IdInsumo = Convert.ToInt32(reader["IdInsumo"]);
                        codigoDeBarras.Barras = reader["CodBarras"].ToString();
                        ListaCodBarras.Add(codigoDeBarras);
                    }
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
            if (update)
            {
                comando += $"Nome = '{Nome}',";
                comando += $"UnidadeMedida = '{UnidadeMedida}',";
                comando += $"Volume = {Volume}";
            }
            else
            {
                comando += $"'{Nome}',";
                comando += $"'{UnidadeMedida}',";
                comando += $"'{Volume}',";
                //Custo
                comando += " 0,";
                //Estoque
                comando += " 0";
            }

            return comando;
        }

        public void AlterarInsumo()
        {
            ConexaoBD conexao = new ConexaoBD();
            SqlCommand comandoSql = new SqlCommand();
            this.update = true;

            try
            {
                comandoSql.Connection = conexao.AbrirConexaoBD();
                string valores = PreparaValores();

                string comando = $"UPDATE Insumos SET {valores} " +
                    $"WHERE Id = {this.Id}";

                comandoSql.CommandText = comando;

                comandoSql.ExecuteNonQuery();
                conexao.FecharConexaoBD();

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

                string campos = "Nome, UnidadeMedida, Volume, Custo, Estoque";
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
