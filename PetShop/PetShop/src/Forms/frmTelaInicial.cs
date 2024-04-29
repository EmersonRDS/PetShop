using PetShop.src.Forms;

namespace PetShop
{
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }



        private void BtnInformacoesDoCliente_Click(object sender, EventArgs e)
        {
            frmBuscaDeClientes buscaDeCliente = new frmBuscaDeClientes();
            buscaDeCliente.abertoPor = 1;
            buscaDeCliente.Show();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            frmCadastroDeCliente cadastroDeCliente = new frmCadastroDeCliente();
            cadastroDeCliente.Show();
        }

        private void BtnCadastrarPet_Click(object sender, EventArgs e)
        {
            frmCadastroDePet cadastroDePet = new frmCadastroDePet();

            cadastroDePet.Show();
        }

        private void btnCadastrarOrdem_Click(object sender, EventArgs e)
        {
            frmCadastroOrdemDeServico ordemDeServico = new frmCadastroOrdemDeServico();
            ordemDeServico.Show();
        }

        private void btnListarOrdem_Click(object sender, EventArgs e)
        {
            frmListaDeOrdensDeServico listaDeOrdens = new frmListaDeOrdensDeServico();
            listaDeOrdens.Show();
        }

        private void btnCadastroDeInsumo_Click(object sender, EventArgs e)
        {
            frmCadastroDeInsumo cadastroDeInsumo = new frmCadastroDeInsumo();
            cadastroDeInsumo.Show();
        }
    }
}
