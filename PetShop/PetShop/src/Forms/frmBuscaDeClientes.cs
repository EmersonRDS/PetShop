using PetShop.src.Models;

namespace PetShop.src.Forms
{
    public partial class frmBuscaDeClientes : Form
    {

        public int IdCliente { get; private set; }
        public int abertoPor { get; set; }

        public enum ColunasGrid
        {
            Id = 0,
            Nome,
            Telefone,
            Endereco,
            Cidade,
            Bairro,
            Observacao
        }

        public enum enumOrigem
        {
            //começa por 1, pois se for 0 ele irá abrir a tela frmInformaçaoDoCliente quando for aberta a partir da tela frmCadastroDePet
            TelaInicial = 1,
            InformacaoDoCliente
        }
        public frmBuscaDeClientes()
        {
            InitializeComponent();
            Cliente c = new Cliente();

            DtgListaDeClientes.DataSource = c.ListarClientes();
            FormataGrid();

        }

        public void FormataGrid()
        {
            var g = DtgListaDeClientes;
            g.Columns[(int)ColunasGrid.Id].Width = Convert.ToInt32(g.Width * 0.10);
            g.Columns[(int)ColunasGrid.Nome].Width = Convert.ToInt32(g.Width * 0.45);
            g.Columns[(int)ColunasGrid.Telefone].Width = Convert.ToInt32(g.Width * 0.40);
            g.Columns[(int)ColunasGrid.Endereco].Visible = false;
            g.Columns[(int)ColunasGrid.Cidade].Visible = false;
            g.Columns[(int)ColunasGrid.Bairro].Visible = false;
            g.Columns[(int)ColunasGrid.Observacao].Visible = false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (CbFiltro.SelectedIndex == 0 || CbFiltro.SelectedIndex == 1)
            {
                if (!String.IsNullOrWhiteSpace(TxtConteudoParaFiltro.Text))
                {
                    Cliente c = new Cliente();
                    string filtro = CbFiltro.Text;
                    string conteudo = TxtConteudoParaFiltro.Text;

                    DtgListaDeClientes.DataSource = c.ListarClientesComFiltro(conteudo, filtro);
                }
                else
                {
                    Cliente c = new Cliente();
                    DtgListaDeClientes.DataSource = c.ListarClientes();
                    FormataGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione o Filtro");
            }
            FormataGrid();
            DtgListaDeClientes.Focus();
        }


        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (DtgListaDeClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow Row = DtgListaDeClientes.SelectedRows[0];
                IdCliente = Convert.ToInt32(Row.Cells[(int)ColunasGrid.Id].Value.ToString());
                DialogResult = DialogResult.OK;

                //quando é aberto pelo frmTelaInicial
                if (abertoPor == (int)enumOrigem.TelaInicial)
                {
                    frmInformacaoDoCliente informacaoDoCliente = new frmInformacaoDoCliente();
                    informacaoDoCliente.idCliente = IdCliente;
                    informacaoDoCliente.Show();

                }
                //quando é aberto pelo frmInformacaoDoCliente
                else if (abertoPor == (int)enumOrigem.InformacaoDoCliente)
                {
                    frmInformacaoDoCliente informacaoDoCliente = new frmInformacaoDoCliente();
                    informacaoDoCliente.idCliente = IdCliente;
                }
                Close();
            }
        }

        private void DtgListaDeClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnConfirmar_Click(sender, e);
        }

        private void TxtConteudoParaFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BtnBuscar_Click(sender, e);
            }
        }
    }
}