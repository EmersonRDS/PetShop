using PetShop.src.Models;
using System.Data;

namespace PetShop.src.Forms
{
    public partial class frmCadastroDeCliente : Form
    {
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
            try
            {
                Cliente c = new Cliente(TxtNome.Text, txtTelefone.Text, txtEndereco.Text, txtCidade.Text, txtBairro.Text, TxtObservacoes.Text);

                c.CadastrarCliente();
                LimparCampos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
