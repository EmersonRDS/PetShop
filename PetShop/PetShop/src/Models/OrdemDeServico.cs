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
        public string NomeCliente { get; set; }
        public int IdPet {  get; set; }
        public string NomePet { get; set; }
        public int EmAberto { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data {  get; set; }
        public string Procedimento { get; set; }
        public bool edicao = false;

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
            if (edicao)
            {
                comando += $"IdCliente = {IdCliente}";

                comando += $", IdPet = {IdPet}";

                comando += $",Valor = {Valor.ToString().Replace(",", ".")}";

                comando += $", Data = Convert(smalldatetime,'{Data.ToString("MM/dd/yyyy HH:mm:ss")}')";

                comando += $",Procedimento = '{Procedimento}'";

                comando += $", EmAberto = 1";
            }
            else
            {
                comando += $"{IdCliente}";

                comando += $", {IdPet}";

                comando += $",{Valor.ToString().Replace(",", ".")}";

                comando += $", Convert(smalldatetime,'{Data.ToString("MM/dd/yyyy HH:mm:ss")}')";

                comando += $",'{Procedimento}'";

                comando += $", 1";
            }
            
            return comando;
        }

        public void CadastrarOrdem() {
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

        public List<OrdemDeServico> ConsultarOrdens(DateTime dataInicial, DateTime dataFinal, string filtro, string filtroConteudo,int emAberto)
        {

            List<OrdemDeServico> ordemDeServicos= new List<OrdemDeServico>();

            string comando = "SELECT C.nome ClienteNome, P.Nome PetNome, OS.Id IdOrdem, OS.Valor, OS.Data " +
                "FROM OrdemDeServico AS OS " +
                "\r\nINNER JOIN Clientes AS C ON C.id = OS.IdCliente" +
                "\r\nINNER JOIN Pets AS P ON P.Id = OS.IdPet " +
                $"WHERE " +
                $"OS.data BETWEEN '{dataInicial.ToString("yyyy-MM-dd HH:mm:ss")}' and '{dataFinal.ToString("yyyy-MM-dd HH:mm:ss")}' " +
                $"AND EmAberto = {emAberto}";

            if (!String.IsNullOrWhiteSpace(filtroConteudo))
            {
                if (filtro == "Nome do Cliente")
                {
                    comando += $" AND C.Nome like '%{filtroConteudo}%'";
                }
                else
                {
                    comando += $" AND P.Nome like '%{filtroConteudo}%'";
                }
            }

            comando += " ORDER BY Os.Data";

            ConexaoBD conexao = new ConexaoBD();

            try
            {
                
                SqlCommand comandoSql = new SqlCommand();
                comandoSql.Connection = conexao.AbrirConexaoBD();
                comandoSql.CommandText = comando;

                SqlDataReader reader = comandoSql.ExecuteReader();

                while (reader.Read())
                {
                    OrdemDeServico ordem = new OrdemDeServico();
                    ordem.Id = Convert.ToInt32(reader["IdOrdem"]);
                    ordem.NomeCliente = reader["ClienteNome"].ToString();
                    ordem.NomePet= reader["PetNome"].ToString();
                    ordem.Valor = Convert.ToDecimal(reader["Valor"].ToString());
                    ordem.Data = Convert.ToDateTime(reader["data"]);
                    
                    ordemDeServicos.Add(ordem);
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

            return ordemDeServicos;
        }

        public void ConsultarOrdem()
        {
            string comando = $"SELECT * FROM OrdemDeServico where Id = {Id}";

            ConexaoBD conexao = new ConexaoBD();

            try
            {
                SqlCommand comandoSql = new SqlCommand();
                comandoSql.Connection = conexao.AbrirConexaoBD();
                comandoSql.CommandText = comando;

                SqlDataReader reader = comandoSql.ExecuteReader();

                while (reader.Read())
                {
                    IdCliente = Convert.ToInt32(reader["IdCliente"].ToString());
                    IdPet = Convert.ToInt32(reader["IdPet"].ToString());
                    EmAberto = Convert.ToInt32(reader["EmAberto"].ToString());
                    Valor = Convert.ToDecimal(reader["Valor"].ToString());
                    Data = Convert.ToDateTime(reader["data"]);
                    Procedimento = reader["Procedimento"].ToString();
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

        public void CancelarOrdem()
        {
            string comando = $"UPDATE OrdemDeServico SET EmAberto = 0 where Id = {Id}";

            ConexaoBD conexao = new ConexaoBD();

            try
            {
                SqlCommand comandoSql = new SqlCommand();
                comandoSql.Connection = conexao.AbrirConexaoBD();
                comandoSql.CommandText = comando;

                comandoSql.ExecuteNonQuery();
                MessageBox.Show($"Ordem {Id} cancelada!");

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

        public void finalizarOrdem()
        {
            string comando = $"UPDATE OrdemDeServico SET EmAberto = 2 where Id = {Id}";

            ConexaoBD conexao = new ConexaoBD();

            try
            {
                SqlCommand comandoSql = new SqlCommand();
                comandoSql.Connection = conexao.AbrirConexaoBD();
                comandoSql.CommandText = comando;

                comandoSql.ExecuteNonQuery();
                MessageBox.Show($"Ordem {Id} Finalizada!");

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

        public void AlterarOrdem()
        {
            ConexaoBD conexao = new ConexaoBD();
            SqlCommand comandoSql = new SqlCommand();

            try
            {
                comandoSql.Connection = conexao.AbrirConexaoBD();
                string valores = PreparaValores();

                string comando = $"UPDATE OrdemDeServico SET {valores} where Id = {Id}";

                comandoSql.CommandText = comando;

                comandoSql.ExecuteNonQuery();
                MessageBox.Show("Ordem de serviço Alterada!");

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
