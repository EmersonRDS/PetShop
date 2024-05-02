using PetShop.src.Models;
using System.Data;

namespace PetShop.src.Forms
{
    public partial class frmCadastroDeCliente : Form
    {
        public bool alteraCliente { get; set; }

        public Cliente cliente { get; set; }

        public frmCadastroDeCliente()
        {
            InitializeComponent();
        }


        private void LimparCampos()
        {
            TxtNome.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            TxtObservacoes.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!alteraCliente)
            {
                try
                {
                    Cliente c = new Cliente(TxtNome.Text, txtTelefone.Text, txtEndereco.Text, txtCidade.Text, txtBairro.Text, TxtObservacoes.Text);

                    c.CadastrarCliente();
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    Cliente c = new Cliente(TxtNome.Text, txtTelefone.Text, txtEndereco.Text, txtCidade.Text, txtBairro.Text, TxtObservacoes.Text);
                    c.Id = cliente.Id;
                    c.AlterarCliente();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            // Verifica se o texto do Label não está vazio
            if (!string.IsNullOrEmpty(txtTelefone.Text))
            {
                // Remove o caracter se nao for numero
                txtTelefone.Text = new string(txtTelefone.Text.Where(char.IsDigit).ToArray());
            }
        }

        private void frmCadastroDeCliente_Load(object sender, EventArgs e)
        {
            if (alteraCliente)
            {
                TxtNome.Text = cliente.Nome;
                txtTelefone.Text = cliente.Telefone;
                txtBairro.Text = cliente.Bairro;
                txtCidade.Text = cliente.Cidade;
                txtEndereco.Text = cliente.Endereco;
                TxtObservacoes.Text = cliente.Observacoes;
                TxtNome.ReadOnly = true;
                txtTelefone.ReadOnly = true;
                txtBairro.ReadOnly = true;
                txtCidade.ReadOnly = true;
                txtEndereco.ReadOnly = true;
                TxtObservacoes.ReadOnly = true;

                LblLiberarCampos.Visible = true;
                btnCadastrar.Text = "Confirmar";
            }
        }

        private void TxtNome_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TxtNome.ReadOnly = false;
        }

        private void txtTelefone_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtTelefone.ReadOnly = false;
        }

        private void txtBairro_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtBairro.ReadOnly = false;
        }

        private void txtCidade_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtCidade.ReadOnly = false;
        }

        private void txtEndereco_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEndereco.ReadOnly = false;
        }

        private void TxtObservacoes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TxtObservacoes.ReadOnly = false;
        }
    }
}
