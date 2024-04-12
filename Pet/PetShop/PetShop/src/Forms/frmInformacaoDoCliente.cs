using PetShop.src.Models;
using System.Security.Cryptography.X509Certificates;

namespace PetShop.src.Forms
{
    public partial class frmInformacaoDoCliente : Form
    {
        public int dadosRecebidos { get; set; }
        public int idCliente { get; set; }
        public int teste { get; set; }
        public frmInformacaoDoCliente()
        {
            InitializeComponent();
        }


        private void PreencherCampos(int idCliente)
        {
            dadosRecebidos = idCliente;
            this.idCliente = idCliente;
            LbListaDePets.Items.Clear();

            Cliente c = new Cliente();
            c.ConsultaCliente(dadosRecebidos);
            TxtIdCliente.Text = c.Id.ToString();
            TxtNomeDoCliente.Text = c.Nome.ToString();
            TxtTelefone.Text = c.Telefone.ToString();
            if (!String.IsNullOrEmpty(c.Cidade))
            {
                TxtCidade.Text = c.Cidade.ToString();
            }

            if (!String.IsNullOrEmpty(c.Bairro))
            {
                TxtBairro.Text = c.Bairro.ToString();
            }

            if (!String.IsNullOrEmpty(c.Endereco))
            {
                TxtEndereco.Text = c.Endereco.ToString();
            }

            if (!String.IsNullOrEmpty(c.Endereco))
            {
                txtObservacoesCliente.Text = c.Observacoes.ToString();
            }

            c.ObterPets(dadosRecebidos);
            if (c.PetsDoCliente != null)
            {
                foreach (Pets pet in c.PetsDoCliente)
                {
                    LbListaDePets.Items.Add($"{pet.Nome}");
                }
            }

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscaDeClientes buscaDeClientes = new frmBuscaDeClientes();
            buscaDeClientes.abertoPor = 2;
            if (buscaDeClientes.ShowDialog() == DialogResult.OK)
            {
                PreencherCampos(buscaDeClientes.IdCliente);
            }
        }

        private void frmInformacaoDoCliente_Load(object sender, EventArgs e)
        {
            PreencherCampos(idCliente);
        }

        

        private void LbListaDePets_Click(object sender, EventArgs e)
        {
            if (LbListaDePets.SelectedIndex != -1)
            {
                GbInformacaoDoPet.Visible = true;
                this.Width = 689;
            }
            
        }
    }
}
