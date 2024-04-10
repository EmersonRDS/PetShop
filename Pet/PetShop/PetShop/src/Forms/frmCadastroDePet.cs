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

        private void LimparCampos()
        {
            txtIdTutor.Text = string.Empty;
            txtNomePet.Text = string.Empty;
            txtNomeTutor.Text = string.Empty;
            txtRaca.Text = string.Empty;
            txtTipoDePelagem.Text = string.Empty;
            TxtObservacoes.Text = string.Empty;
            RdbAlergicoNao.Checked = false;
            RdbAlergicoSim.Checked = false;
            RdbPorteG.Checked = false;
            RdbPorteM.Checked = false;
            RdbPorteP.Checked = false;
            RdbVacinadoNao.Checked = false;
            RdbVacinadoSim.Checked = false;
            DtDataNascimento.Value = DtDataNascimento.MaxDate;
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
            string nome, raca, tipoDePelo, porte, observacoes;
            DateTime dataDeNascimento;
            int idTutor, vacinado, alergico;

            if (!(String.IsNullOrWhiteSpace(txtNomePet.Text) || String.IsNullOrWhiteSpace(txtRaca.Text) || String.IsNullOrWhiteSpace(txtTipoDePelagem.Text)
                || String.IsNullOrWhiteSpace(txtIdTutor.Text) || (!RdbPorteG.Checked && !RdbPorteM.Checked && !RdbPorteP.Checked) || (!RdbAlergicoSim.Checked && !RdbAlergicoNao.Checked)
                || (!RdbVacinadoNao.Checked && !RdbVacinadoSim.Checked)))
            {
                nome = txtNomePet.Text;
                idTutor = Convert.ToInt32(txtIdTutor.Text);
                raca = txtRaca.Text;
                tipoDePelo = txtTipoDePelagem.Text;
                dataDeNascimento = DtDataNascimento.Value;
                observacoes = TxtObservacoes.Text;

                Pets pets = new Pets(nome, idTutor, raca, tipoDePelo, dataDeNascimento, observacoes);

                //valida porte
                if (RdbPorteG.Checked)
                {
                    porte = "G";
                }
                else if (RdbPorteM.Checked)
                {
                    porte = "M";
                }
                else
                {
                    porte = "P";
                }

                pets.Porte = porte;

                //valida alergico

                if (RdbAlergicoSim.Checked)
                {
                    alergico = 1;
                }
                else
                {
                    alergico = 0;
                }
                pets.PossuiAlergia = alergico;

                //valida vacinado
                if (RdbVacinadoSim.Checked)
                {
                    vacinado = 1;
                }
                else
                {
                    vacinado = 0;
                }
                pets.Vacinado = vacinado;

                try
                {
                    pets.CadastroDePet();
                    LimparCampos();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Preencha as informações obrigatórias!\nInformações obrigatórias possuem um *");
            }
        }

        private void txtIdTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                txtIdTutor_Leave(sender, e);
            }
        }
    }
}