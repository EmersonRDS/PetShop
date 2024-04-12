using System.ComponentModel;
using System.Data.SqlClient;

namespace PetShop.src.Models
{
    internal class Pets
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

        public Pets(string nome, int idTutor, string raca, string tipoDePelagem, DateTime dataDeNascimento, string observacoes) {
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

            string valores = $"'{Nome}', {IdTutor}, '{Raca}', {Vacinado}, '{TipoDePelagem}', '{Porte}',{PossuiAlergia}";

            if (DataDeNascimento.ToString("dd/MM/yyyy") == DateTime.Today.ToString("dd/MM/yyyy"))
            {
                valores += ", NULL";
            }
            else
            {
                valores += $",Convert(smalldatetime,'{DataDeNascimento}')";
            }

            if (String.IsNullOrEmpty(Observacoes))
            {
                valores += ", NULL";
            }
            else
            {
                valores += $",'{Observacoes}'";
            }

            return valores;
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
    }
}
