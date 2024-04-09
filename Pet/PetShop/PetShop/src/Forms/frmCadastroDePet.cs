using PetShop.src.Models;
using System.Data.SqlClient;

namespace PetShop.src.Forms
{
    public partial class frmCadastroDePet : Form
    {
        private int dadosRecebidos;
        public frmCadastroDePet()
        {
            InitializeComponent();
            DtDataNascimento.MaxDate = DateTime.Now;
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscaDeClientes buscaDeClientes = new frmBuscaDeClientes();
            if (buscaDeClientes.ShowDialog() == DialogResult.OK)
            {
                dadosRecebidos = buscaDeClientes.IdCliente;

                Cliente c = new Cliente();
                c.ConsultaCliente(dadosRecebidos);
                txtIdTutor.Text = c.Id.ToString();
                txtNomeTutor.Text = c.Nome;
            }
        }

        private void txtIdTutor_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdTutor.Text))
            {
                // Remove o caracter se nao for numero
                txtIdTutor.Text = new string(txtIdTutor.Text.Where(char.IsDigit).ToArray());
            }
        }

        private void txtIdTutor_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtIdTutor.Text))
            {
                dadosRecebidos = Convert.ToInt32(txtIdTutor.Text);
                Cliente c = new Cliente();
                c.ConsultaCliente(dadosRecebidos);
                txtIdTutor.Text = c.Id.ToString();
                txtNomeTutor.Text = c.Nome;
            }
            else
            {
                MessageBox.Show("Digite um Id válido para o tutor");
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            string nome, raca, tipoDePelo,porte,observacoes;
            DateTime dataDeNascimento;
            int idTutor, vacinado, alergico;

            if (!(String.IsNullOrWhiteSpace(txtNomePet.Text) || String.IsNullOrWhiteSpace(txtRaca.Text) || String.IsNullOrWhiteSpace(txtTipoDePelagem.Text)
                || String.IsNullOrWhiteSpace(txtIdTutor.Text) || (!RdbPorteG.Checked && !RdbPorteM.Checked && !RdbPorteP.Checked) || (!RdbAlergicoSim.Checked && !RdbAlergicoNao.Checked)
                || (!RdbVacinadoNao.Checked && !RdbVacinadoSim.Checked)))
            {
                string campos = "Nome, idCLiente , Raca, TipoPelagem";
                
                nome = txtNomePet.Text;
                idTutor = Convert.ToInt32(txtIdTutor.Text);
                raca = txtRaca.Text;
                tipoDePelo = txtTipoDePelagem.Text;
                

                string valores = $"'{nome}', {idTutor}, '{raca}', '{tipoDePelo}'";

                if ((DtDataNascimento.Value.ToString("dd/MM/yyyy")) != DateTime.Today.ToString("dd/MM/yyyy"))
                {
                    dataDeNascimento = DtDataNascimento.Value;

                    campos += ", DataNascimento";
                    valores += $",Convert(smalldatetime, '{dataDeNascimento}')";
                }

                if (!String.IsNullOrEmpty(TxtObservacoes.Text))
                {
                    observacoes = TxtObservacoes.Text;

                    campos += ", Observacao";
                    valores += $", '{observacoes}'";
                }
                //valida porte
                if (RdbPorteG.Checked)
                {
                    porte = "G";
                }else if (RdbPorteM.Checked)
                {
                    porte = "M";
                }else
                {
                    porte = "P";
                }

                //valida alercico

                if (RdbAlergicoSim.Checked) {
                    alergico = 1;
                }else
                {
                    alergico = 0;
                }

                //valida vacinado
                if (RdbVacinadoSim.Checked)
                {
                    vacinado = 1;
                }else
                {
                    vacinado = 0;
                }

                campos += ", Porte, Alergia, Vacinado";
                valores += $",'{porte}', {alergico}, {vacinado}";


                ConexaoBD conexao = new ConexaoBD();
                SqlCommand comandoSql = new SqlCommand();


                try
                {
                    comandoSql.Connection = conexao.AbrirConexaoBD();
                    

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
            else
            {
                MessageBox.Show("Preencha as informações obrigatórias!\nInformações obrigatórias possuem um *");
            }
                
            
        }
    }
}
