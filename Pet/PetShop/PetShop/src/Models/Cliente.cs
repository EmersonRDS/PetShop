using System.Data;
using System.Data.SqlClient;

namespace PetShop.src.Models
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public List<Pets> PetsDoCliente { get; set; }
        public string Observacoes { get; set; }
        public Cliente() { }

        public Cliente(string nome, string telefone, string endereco, string cidade, string bairro, string observacoes)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(nome))
                {
                    throw new Exception("Preencha o nome!");
                }
                else
                {
                    Nome = nome;
                }

                if (String.IsNullOrWhiteSpace(telefone))
                {
                    throw new Exception("Preencha o telefone!");
                }
                else
                {
                    Telefone = telefone;
                }

                Endereco = endereco;
                Cidade = cidade;
                Bairro = bairro;
                Observacoes = observacoes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string PreparaValores()
        {
            if (String.IsNullOrWhiteSpace(Nome) || String.IsNullOrWhiteSpace(Telefone))
            {
                throw new Exception("Cliente não cadastrado");
            }
            string comando = $"'{Nome}', '{Telefone}', ";

            if (String.IsNullOrWhiteSpace(Endereco))
            {
                comando += "NULL,";
            }
            else
            {
                comando += $"'{Endereco}',";
            }

            if (String.IsNullOrWhiteSpace(Cidade))
            {
                comando += "NULL,";
            }
            else
            {
                comando += $"'{Cidade}',";
            }

            if (String.IsNullOrWhiteSpace(Bairro))
            {
                comando += "NULL,";
            }
            else
            {
                comando += $"'{Bairro}',";
            }

            if (String.IsNullOrWhiteSpace(Observacoes))
            {
                comando += "NULL";
            }
            else
            {
                comando += $"'{Observacoes}'";
            }

            return comando;
        }
        public void CadastrarCliente()
        {
            ConexaoBD conexao = new ConexaoBD();
            SqlCommand comandoSql = new SqlCommand();

            

            try {
                comandoSql.Connection = conexao.AbrirConexaoBD();
                string campos = "Nome, Telefone, Endereco, Cidade, Bairro, Observacao";
                string valores = PreparaValores();

                string comando = $"INSERT INTO Clientes ({campos}) VALUES ({valores})";
            
                comandoSql.CommandText = comando;
            
                comandoSql.ExecuteNonQuery();
                conexao.FecharConexaoBD();
                MessageBox.Show("Cliente Cadastrado!");

            }catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.FecharConexaoBD();
            }
        }

        public List<Cliente> ListarClientes()
        {
            List<Cliente> ListaClientes = new List<Cliente>();
            
            string comando = "SELECT TOP 100 id,nome,telefone FROM Clientes";

            ConexaoBD conexao = new ConexaoBD();
            SqlCommand comandoSql = new SqlCommand();

            
            try
            {
                comandoSql.Connection = conexao.AbrirConexaoBD();

                comandoSql.CommandText = comando;

                SqlDataReader reader = comandoSql.ExecuteReader();

                while (reader.Read())
                {
                    Cliente c = new Cliente();
                    c.Id = Convert.ToInt32(reader["Id"]);
                    c.Nome = reader["Nome"].ToString();
                    c.Telefone = reader["Telefone"].ToString();
                    ListaClientes.Add(c);
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

            return ListaClientes;
        }

        public List<Cliente> ListarClientesComFiltro(string conteudo, string filtro)
        {
           List<Cliente> ListaClientes = new List<Cliente>();
            DataTable dt = new DataTable();

            string comando = $"SELECT TOP 100 id,nome,telefone FROM Clientes WHERE {filtro} LIKE '{conteudo}%'";

            ConexaoBD conexao = new ConexaoBD();
            SqlCommand comandoSql = new SqlCommand();

            try
            {
                comandoSql.Connection = conexao.AbrirConexaoBD();

                comandoSql.CommandText = comando;
                SqlDataReader reader = comandoSql.ExecuteReader();

                while (reader.Read())
                {
                    Cliente c = new Cliente();
                    c.Id = Convert.ToInt32(reader["Id"]);
                    c.Nome = reader["Nome"].ToString();
                    c.Telefone = reader["Telefone"].ToString();
                    ListaClientes.Add(c);
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
            return ListaClientes;
        }

        public void ConsultaCliente(int idCliente)
        {
            string comando = $"SELECT TOP 100 id,nome FROM Clientes WHERE id = {idCliente}";

            ConexaoBD conexao = new ConexaoBD();
            SqlCommand comandoSql = new SqlCommand();

            comandoSql.Connection = conexao.AbrirConexaoBD();

            comandoSql.CommandText = comando;
            try
            {
                SqlDataReader reader = comandoSql.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.Id = Convert.ToInt32(reader["Id"]);
                        this.Nome = reader["Nome"].ToString();
                    }
                }
                else
                {
                    throw new Exception($"Cliente Id {idCliente} não encontrado");
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
