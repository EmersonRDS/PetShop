using System.Data.SqlClient;

namespace PetShop.src.Models
{
    public class Pets
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdTutor { get; set; }
        public string Raca { get; set; }
        public int Vacinado { get; set; }
        public string TipoDePelagem { get; set; }

        public string Porte { get; set; }

        public int PossuiAlergia { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Observacoes { get; set; }

        public bool update = false;

        public Pets(string nome, int idTutor, string raca, string tipoDePelagem, DateTime dataDeNascimento, string observacoes)
        {
            Nome = nome;
            IdTutor = idTutor;
            Raca = raca;
            TipoDePelagem = tipoDePelagem;
            DataDeNascimento = dataDeNascimento;
            Observacoes = observacoes;
        }

        public Pets() { }

        public string PreparaValores()
        {
            string comando = "";
            if (!update)
            {
                comando += $"'{Nome}', {IdTutor}, '{Raca}', {Vacinado}, '{TipoDePelagem}', '{Porte}',{PossuiAlergia}";
            }
            else
            {
                comando += $"Nome = '{Nome}', IdCliente = {IdTutor}, Raca = '{Raca}', Vacinado = {Vacinado}, " +
                    $"TipoPelagem = '{TipoDePelagem}', Porte = '{Porte}', Alergia = {PossuiAlergia}";
            }


            if (DataDeNascimento.ToString("dd/MM/yyyy") == DateTime.Today.ToString("dd/MM/yyyy"))
            {
                if (!update)
                {
                    comando += ", NULL";
                }
            }
            else
            {
                if (update)
                {
                    comando += $",DataNascimento = Convert(smalldatetime,'{DataDeNascimento.ToString("MM/dd/yyyy")}')";
                }
                else
                {
                    comando += $",Convert(smalldatetime,'{DataDeNascimento.ToString("MM/dd/yyyy")}')";
                }
            }

            if (String.IsNullOrEmpty(Observacoes))
            {
                if (!update)
                {
                    comando += ", NULL";
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
                    comando += $",'{Observacoes}'";
                }
            }

            return comando;
        }

        public void CadastroDePet()
        {
            ConexaoBD conexao = new ConexaoBD();
            SqlCommand comandoSql = new SqlCommand();

            try
            {
                comandoSql.Connection = conexao.AbrirConexaoBD();
                string campos = "Nome, IdCliente, Raca, Vacinado, TipoPelagem, Porte, Alergia, DataNascimento, Observacao";
                string valores = PreparaValores();

                string comando = $"INSERT INTO Pets ({campos}) VALUES ({valores})";

                comandoSql.CommandText = comando;

                comandoSql.ExecuteNonQuery();
                conexao.FecharConexaoBD();
                MessageBox.Show("Pet Cadastrado!");

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

        public void AlterarPet()
        {
            ConexaoBD conexao = new ConexaoBD();
            SqlCommand comandoSql = new SqlCommand();
            this.update = true;

            try
            {
                comandoSql.Connection = conexao.AbrirConexaoBD();
                string valores = PreparaValores();

                string comando = $"UPDATE Pets SET {valores} " +
                    $"WHERE Id = {this.Id}";

                comandoSql.CommandText = comando;

                comandoSql.ExecuteNonQuery();
                MessageBox.Show("Pet Alterado!");

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
