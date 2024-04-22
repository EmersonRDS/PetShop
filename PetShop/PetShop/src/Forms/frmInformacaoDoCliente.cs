using PetShop.src.Models;

namespace PetShop.src.Forms
{
    public partial class frmInformacaoDoCliente : Form
    {
        public int dadosRecebidos { get; set; }
        public int idCliente { get; set; }
        public bool estaAberto { get; set; }

        Cliente c = new Cliente();
        public frmInformacaoDoCliente()
        {
            InitializeComponent();
        }
        public void LimparCampos()
        {
            TxtIdCliente.Text = "";
            TxtNomeDoCliente.Text = "";
            TxtTelefone.Text = "";
            TxtCidade.Text = "";
            TxtBairro.Text = "";
            TxtEndereco.Text = "";
            txtObservacoesCliente.Text = "";
            TxtNomePet.Text = "";
            TxtIdade.Text = "";
            TxtRaca.Text = "";
            TxtTipoDePelagem.Text = "";
            LblPorte.Text = "";
            LblVacinado.Text = "Sim";
            LblAlergico.Text = "Sim";
            TxtObservacoesPet.Text = "";
        }

        private void PreencherCamposCliente(int idCliente)
        {
            dadosRecebidos = idCliente;
            this.idCliente = idCliente;
            LbListaDePets.Items.Clear();


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

        public void PreencherCamposPets(int indexLista)
        {
            TxtNomePet.Text = c.PetsDoCliente[indexLista].Nome;
            TxtRaca.Text = c.PetsDoCliente[indexLista].Raca;
            TxtTipoDePelagem.Text = c.PetsDoCliente[indexLista].TipoDePelagem;
            LblPorte.Text = c.PetsDoCliente[indexLista].Porte;

            if (c.PetsDoCliente[indexLista].Vacinado == 1)
            {
                LblVacinado.Text = "Sim";
            }
            else
            {
                LblVacinado.Text = "Não";
            }

            if (c.PetsDoCliente[indexLista].PossuiAlergia == 1)
            {
                LblAlergico.Text = "Sim";
            }
            else
            {
                LblAlergico.Text = "Não";
            }

            if (!(c.PetsDoCliente[indexLista].DataDeNascimento.ToString() == "01/01/0001 00:00:00"))
            {
                DateTime dataHoje = DateTime.Now;
                TimeSpan diferença = dataHoje.Subtract(c.PetsDoCliente[indexLista].DataDeNascimento);
                int anos = (int)(diferença.Days / 365.25);
                TxtIdade.Text = $"{anos}";
            }
            else
            {
                TxtIdade.Text = "";
            }

            TxtObservacoesPet.Text = c.PetsDoCliente[indexLista].Observacoes;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscaDeClientes buscaDeClientes = new frmBuscaDeClientes();
            buscaDeClientes.abertoPor = 2;
            if (buscaDeClientes.ShowDialog() == DialogResult.OK)
            {
                LimparCampos();
                PreencherCamposCliente(buscaDeClientes.IdCliente);
            }
        }

        private void frmInformacaoDoCliente_Load(object sender, EventArgs e)
        {
            PreencherCamposCliente(idCliente);
        }

        private void LbListaDePets_Click(object sender, EventArgs e)
        {
            if (LbListaDePets.SelectedIndex != -1)
            {

                GbInformacaoDoPet.Visible = true;
                PreencherCamposPets(LbListaDePets.SelectedIndex);
                if (this.Width < 659)
                {
                    for (int i = 359; i < 660; i += 20)
                    {
                        this.Width = i;
                        System.Timers.Timer timer = new System.Timers.Timer(1);
                        timer.Start();
                    }
                }

            }

        }

        private void BtnAlterarPet_Click(object sender, EventArgs e)
        {

            if (LbListaDePets.SelectedIndex != -1)
            {
                frmCadastroDePet cadastroDePet = new frmCadastroDePet();
                cadastroDePet.alteraPet = true;
                cadastroDePet.pet = c.PetsDoCliente[LbListaDePets.SelectedIndex];
                cadastroDePet.Show();
            }
            else
            {
                MessageBox.Show("Selecione um pet!");
            }

        }

        private void BtnAlterarCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmCadastroDeCliente cadastroDeCliente = new frmCadastroDeCliente();
            cadastroDeCliente.alteraCliente = true;
            c.Id = idCliente;
            cadastroDeCliente.cliente = c;
            cadastroDeCliente.ShowDialog();

        }

        private void BtnOrdemDeServico_Click(object sender, EventArgs e)
        {
            frmCadastroOrdemDeServico ordemDeServico = new frmCadastroOrdemDeServico();
            ordemDeServico.c = c;
            ordemDeServico.abertoPorInformacoes = true;
            if (LbListaDePets.SelectedIndex != -1)
            {
                ordemDeServico.petSelecionado = LbListaDePets.SelectedIndex;
            }
            ordemDeServico.Show();
        }

        private void TxtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                PreencherCamposCliente(Convert.ToInt32(TxtIdCliente.Text));
            }

        }

        private void TxtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtIdCliente.Text))
            {
                // Remove o caracter se nao for numero
                TxtIdCliente.Text = new string(TxtIdCliente.Text.Where(char.IsDigit).ToArray());
            }
        }
    }
}
