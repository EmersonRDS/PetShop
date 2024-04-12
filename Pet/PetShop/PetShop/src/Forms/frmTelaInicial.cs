using PetShop.src.Forms;

namespace PetShop
{
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void ListaDeClientes_Click(object sender, EventArgs e)
        {
            frmBuscaDeClientes buscaDeCliente = new frmBuscaDeClientes();
            buscaDeCliente.abertoPor = 1;
            buscaDeCliente.ShowDialog();
        }


        private void CadastrarCliente_Click(object sender, EventArgs e)
        {
            frmCadastroDeCliente cadastroDeCliente = new frmCadastroDeCliente();
            cadastroDeCliente.ShowDialog();
        }

        private void CadastrarPet_Click(object sender, EventArgs e)
        {
            frmCadastroDePet cadastroDePet = new frmCadastroDePet();

            cadastroDePet.ShowDialog();
        }
    }
}
