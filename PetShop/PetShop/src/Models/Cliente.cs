using System.Data.SqlClient;

namespace PetShop.src.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public List<Pets> PetsDoCliente { get; set; }
        public string Observacoes { get; set; }
        private bool update = false;
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
            string comando = "";
            if (String.IsNullOrWhiteSpace(Nome) || String.IsNullOrWhiteSpace(Telefone))
            {
                throw new Exception("Cliente não cadastrado");
            }
            if (update)
            {
                comando = $"Nome = '{Nome}', Telefone = '{Telefone}'";
            }
            else
            {
                comando = $"'{Nome}', '{Telefone}', ";
            }


            if (String.IsNullOrWhiteSpace(Endereco))
            {
                if (!update)
                {
                    comando += "NULL,";
                }
            }
            else
            {
                if (update)
                {
                    comando += $", Endereco = '{Endereco}'";
                }
                else
                {
                    comando += $"'{Endereco}',";
                }
            }

            if (String.IsNullOrWhiteSpace(Cidade))
            {
                if (!update)
                {
                    comando += "NULL,";
                }
            }
            else
            {
                if (update)
                {
                    comando += $",Cidade = '{Cidade}'";
                }
                else
                {
                    comando += $"'{Cidade}',";
                }
            }

            if (String.IsNullOrWhiteSpace(Bairro))
            {
                if (!update)
                {
                    comando += "NULL,";
                }
            }
            else
            {
                if (update)
                {
                    comando += $",Bairro = '{Bairro}'";
                }
                else
                {
                    comando += $"'{Bairro}',";
                }
            }

            if (String.IsNullOrWhiteSpace(Observacoes))
            {
                if (!update)
                {
                    comando += "NULL";
                }
            }
            else
            {
                if (update)
                {
                    comando += $",Observacao = '{Observacoes}'";
                }
                else
                {
                    comando += $"'{Observacoes}'";
                }
            }

            return comando;
        }
        public void CadastrarCliente()
        {
            ConexaoBD conexao = new ConexaoBD();
            SqlCommand comandoSql = new SqlCommand();



            try
            {
                comandoSql.Connection = conexao.AbrirConexaoBD();
                string campos = "Nome, Telefone, Endereco, Cidade, Bairro, Observacao";
                string valores = PreparaValores();

                string comando = $"INSERT INTO Clientes ({campos}) VALUES ({valores})";

                comandoSql.CommandText = comando;

                comandoSql.ExecuteNonQuery();
                MessageBox.Show("Cliente Cadastrado!");

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
            string comando = $"SELECT * FROM Clientes WHERE id = {idCliente}";

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
                        this.Telefone = reader["Telefone"].ToString();
                        this.Bairro = reader["Bairro"].ToString();
                        this.Cidade = reader["Cidade"].ToString();
                        this.Endereco = reader["Endereco"].ToString();
                        this.Observacoes = reader["Observacao"].ToString();
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

        public void ObterPets(int idCliente)
        {
            string comando = $"SELECT * FROM Pets WHERE IdCliente = {idCliente}";

            ConexaoBD conexao = new ConexaoBD();
            SqlCommand comandoSql = new SqlCommand();

            try
            {

                comandoSql.Connection = conexao.AbrirConexaoBD();

                comandoSql.CommandText = comando;
                SqlDataReader reader = comandoSql.ExecuteReader();
                List<Pets> listaPets = new List<Pets>();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Pets pet = new Pets();
                        pet.Id = Convert.ToInt32(reader["Id"]);
                        pet.IdTutor = Convert.ToInt32(reader["IdCliente"]);
                        pet.Nome = reader["Nome"].ToString();
                        pet.Raca = reader["Raca"].ToString();
                        pet.Vacinado = Convert.ToInt32(reader["Vacinado"]);
                        pet.TipoDePelagem = reader["TipoPelagem"].ToString();
                        pet.Porte = reader["Porte"].ToString();
                        pet.PossuiAlergia = Convert.ToInt32(reader["Alergia"]);
                        if (!String.IsNullOrEmpty(reader["DataNascimento"].ToString()))
                        {
                            pet.DataDeNascimento = (DateTime)reader["DataNascimento"];
                        }
                        pet.Observacoes = reader["Observacao"].ToString();

                        listaPets.Add(pet);
                    }
                    if (listaPets.Count() > 0)
                    {
                        PetsDoCliente = listaPets;
                    }

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
        public void AlterarCliente()
        {
            ConexaoBD conexao = new ConexaoBD();
            SqlCommand comandoSql = new SqlCommand();
            this.update = true;

            try
            {
                comandoSql.Connection = conexao.AbrirConexaoBD();
                string valores = PreparaValores();

                string comando = $"UPDATE Clientes SET {valores} " +
                    $"WHERE Id = {this.Id}";

                comandoSql.CommandText = comando;

                comandoSql.ExecuteNonQuery();
                conexao.FecharConexaoBD();
                MessageBox.Show("Cliente Alterado!");

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
