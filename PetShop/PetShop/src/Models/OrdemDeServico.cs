using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.src.Models
{
    public class OrdemDeServico
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdPet {  get; set; }
        public int EmAberto { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data {  get; set; }
        public string Procedimento { get; set; }

        public OrdemDeServico() { }
        public OrdemDeServico(int idCliente, int idPet, decimal valor, DateTime data, string procedimento)
        {
            IdCliente = idCliente;
            IdPet = idPet;
            Valor = valor;
            Data = data;
            Procedimento = procedimento;
        }

        public string PreparaValores()
        {
            string comando = "";

            comando += $"{IdCliente}";

            comando += $", {IdPet}";

            comando += $",{Valor.ToString().Replace(",",".")}";

            comando += $", Convert(smalldatetime,'{Data.ToString("MM/dd/yyyy")}')";

            comando += $",'{Procedimento}'";

            comando += $", 1";

            return comando;
        }

        public void cadastrarOrdem() {
            ConexaoBD conexao = new ConexaoBD();
            SqlCommand comandoSql = new SqlCommand();

            try
            {
                comandoSql.Connection = conexao.AbrirConexaoBD();
                string campos = "IdCliente, IdPet, Valor, Data, Procedimento, EmAberto";
                string valores = PreparaValores();

                string comando = $"INSERT INTO OrdemDeServico ({campos}) VALUES ({valores})";

                comandoSql.CommandText = comando;

                comandoSql.ExecuteNonQuery();
                MessageBox.Show("Ordem de serviço Cadastrada!");

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
