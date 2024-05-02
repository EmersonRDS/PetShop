using PetShop.src.Models;
using System.Data;

namespace PetShop.src.Forms
{
    public partial class frmCadastroOrdemDeServico : Form
    {

        private int dadosRecebidos { get; set; }
        public Cliente c = new Cliente();
        private string observacoesPet;
        public bool abertoPorInformacoes;
        public bool abertoPorListaDeOrdens;
        public bool abertoEmEdicao;
        public int statusDaOrdem;
        public int petSelecionado = -1;
        public OrdemDeServico ordem = new OrdemDeServico();

        public frmCadastroOrdemDeServico()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            GbInformacoesDoPet.Visible = false;
            TxtIdCliente.Text = "";
            TxtNomeDoCliente.Text = "";
            LbListaDePets.Items.Clear();
            LbProcedimentos.Items.Clear();
            DtData.Value = DtData.MinDate;
            MTxtValor.Text = "00000";
        }

        public void PreencherCamposPets(int indexLista)
        {
            GbInformacoesDoPet.Visible = true;
            PnlIdade.Visible = false;
            PnlObservacoes.Visible = false;
            LblRacaDado.Text = c.PetsDoCliente[indexLista].Raca;
            LblPeloDado.Text = c.PetsDoCliente[indexLista].TipoDePelagem;
            LblPorteDado.Text = c.PetsDoCliente[indexLista].Porte;

            if (c.PetsDoCliente[indexLista].Vacinado == 1)
            {
                LblVacinadoDado.Text = "Vacinado";
            }
            else
            {
                LblVacinadoDado.Text = "Não Vacinado";
            }

            if (c.PetsDoCliente[indexLista].PossuiAlergia == 1)
            {
                LblVacinadoDado.Text = "Vacinado";
            }
            else
            {
                LblVacinadoDado.Text = "Não Vacinado";
            }

            if (!(c.PetsDoCliente[indexLista].DataDeNascimento.ToString() == "01/01/0001 00:00:00"))
            {
                PnlIdade.Visible = true;
                DateTime dataHoje = DateTime.Now;
                TimeSpan diferença = dataHoje.Subtract(c.PetsDoCliente[indexLista].DataDeNascimento);
                int anos = (int)(diferença.Days / 365.25);
                LblIdadeDado.Text = $"{anos}";
            }

            if (c.PetsDoCliente[indexLista].Observacoes != "")
            {
                PnlObservacoes.Visible = true;
                observacoesPet = c.PetsDoCliente[indexLista].Observacoes;
            }
        }

        private void BuscaDeCliente(int idCliente)
        {
            LbListaDePets.Items.Clear();
            c.ConsultaCliente(idCliente);
            TxtIdCliente.Text = c.Id.ToString();
            TxtNomeDoCliente.Text = c.Nome;

            c.ObterPets(idCliente);
            if (c.PetsDoCliente != null)
            {
                foreach (Pets pet in c.PetsDoCliente)
                {
                    LbListaDePets.Items.Add($"{pet.Nome}");
                }
            }
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {

            frmBuscaDeClientes buscaDeClientes = new frmBuscaDeClientes();
            if (buscaDeClientes.ShowDialog() == DialogResult.OK)
            {
                dadosRecebidos = buscaDeClientes.IdCliente;

                BuscaDeCliente(dadosRecebidos);
            }
        }

        private void LbListaDePets_Click(object sender, EventArgs e)
        {
            if (LbListaDePets.SelectedIndex != -1)
            {
                PreencherCamposPets(LbListaDePets.SelectedIndex);
            }
        }

        private void frmCadastroOrdemDeServico_Load(object sender, EventArgs e)
        {
            PnlIdade.Visible = false;
            PnlObservacoes.Visible = false;
            GbInformacoesDoPet.Visible = false;
            DtData.MinDate = DateTime.Now;
            if (abertoPorInformacoes)
            {
                BuscaDeCliente(c.Id);
                if (petSelecionado != -1)
                {
                    PreencherCamposPets(petSelecionado);
                    LbListaDePets.SelectedIndex = petSelecionado;
                }
            }
            else if (abertoPorListaDeOrdens)
            {
                ordem.ConsultarOrdem();
                if (ordem.EmAberto == 1) // status em aberto
                {
                    BtnAlterar.Enabled = true;
                    BtnFinalizar.Enabled = true;
                    BtnCancelar.Enabled = true;
                    BtnSalvar.Enabled = false;
                }
                else
                {
                    BtnAlterar.Enabled = true;
                    BtnFinalizar.Enabled = false;
                    BtnCancelar.Enabled = false;
                    BtnSalvar.Enabled = false;
                }

                DtData.Enabled = false;
                TxtIdCliente.ReadOnly = true;
                MTxtValor.ReadOnly = true;
                LbListaDePets.Enabled = false;
                TxtAdicionarProcedimento.ReadOnly = true;
                BtnAdicionarInsumo.Enabled = false;
                btnRemoverInsumo.Enabled = false;
                LbProcedimentos.Enabled = false;
                TxtCodInsumo.ReadOnly = true;
                btnPesquisaInsumo.Enabled = false;
                btnRemoverInsumo.Enabled = false;
                BtnAdicionarInsumo.Enabled = false;
                btnRemoverProcedimento.Enabled = false;
                BtnAdicionarProcedimento.Enabled = false;
                BtnBuscarCliente.Enabled = false;

                //preencher campos
                TxtCodigoOrdem.Text = ordem.Id.ToString();

                DtData.MinDate = Convert.ToDateTime(ordem.Data.ToString("dd/MM/yyyy"));
                DtData.Value = ordem.Data;

                if (ordem.Valor.ToString().Length < 6) //6 por causa do .
                {
                    string texto = ordem.Valor.ToString();
                    for (int i = texto.Length; i < 6; i++)
                    {
                        texto = texto.PadLeft(i + 1, '0');
                    }
                    MTxtValor.Text = texto;
                }
                else
                {
                    MTxtValor.Text = ordem.Valor.ToString();
                }


                BuscaDeCliente(ordem.IdCliente);

                for (int i = 0; i < LbListaDePets.Items.Count; i++)
                {
                    Pets pet = c.PetsDoCliente[i];
                    if (pet.Id == ordem.IdPet)
                    {
                        LbListaDePets.SelectedItem = pet.Nome;
                        PreencherCamposPets(LbListaDePets.SelectedIndex);
                    }
                }

                string[] procedimentos = ordem.Procedimento.Split(" ; ");
                foreach (var item in procedimentos)
                {
                    if (!string.IsNullOrWhiteSpace(item))
                    {
                        LbProcedimentos.Items.Add(item);
                    }
                }
            }
        }

        private void LblObservacoes_MouseHover(object sender, EventArgs e)
        {
            TTObservacao.SetToolTip((Control)sender, observacoesPet);
        }

        private void TxtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(TxtIdCliente.Text))
                {
                    BuscaDeCliente(Convert.ToInt32(TxtIdCliente.Text));
                }
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
        private bool VerificarProcedimentos(string procedimento)
        {
            foreach (var item in LbProcedimentos.Items)
            {
                if (item.ToString() == procedimento)
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnAdicionarProcedimento_Click(object sender, EventArgs e)
        {
            if (TxtAdicionarProcedimento.Text != "")
            {
                if (!VerificarProcedimentos(TxtAdicionarProcedimento.Text))
                {
                    LbProcedimentos.Items.Add(TxtAdicionarProcedimento.Text);
                    TxtAdicionarProcedimento.Text = "";
                }
                else
                {
                    MessageBox.Show("Procedimento já adicionado!");
                }
            }
            else
            {
                MessageBox.Show("Digite um procedimento!");
            }
        }

        private void TxtAdicionarProcedimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BtnAdicionarProcedimento_Click((Control)sender, e);
            }
        }

        private void btnRemoverProcedimento_Click(object sender, EventArgs e)
        {
            if (LbProcedimentos.SelectedIndex != -1)
            {
                LbProcedimentos.Items.RemoveAt(LbProcedimentos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione o procedimento para remover");
            }
        }

        private decimal ObterValor(string valor)
        {
            string converter = new string(valor.Where(char.IsDigit).ToArray());
            converter = converter.Substring(0, converter.Length - 2) + "," + converter.Substring(converter.Length - 2);
            return Convert.ToDecimal(converter);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (DtData.Value != DtData.MinDate && TxtIdCliente.Text != "" &&
                ObterValor(MTxtValor.Text) != 00.0M && LbProcedimentos.Items.Count > 0
                && LbListaDePets.SelectedIndex != -1)
            {
                try
                {
                    string procedimentos = "";
                    foreach (var item in LbProcedimentos.Items)
                    {
                        procedimentos += item.ToString() + " ; ";
                    }

                    ordem = new OrdemDeServico(Convert.ToInt32(TxtIdCliente.Text), c.PetsDoCliente[LbListaDePets.SelectedIndex].Id,
                        ObterValor(MTxtValor.Text), DtData.Value, procedimentos);
                    if (abertoEmEdicao)
                    {
                        ordem.Id = Convert.ToInt32(TxtCodigoOrdem.Text);
                        DialogResult confirmaAlteracao = MessageBox.Show($"Confirma alterações da Ordem de Serviço {ordem.Id}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirmaAlteracao == DialogResult.Yes)
                        {
                            ordem.edicao = true;
                            ordem.AlterarOrdem();
                            LimparCampos();
                            frmCadastroOrdemDeServico_Load(sender, e);
                        }
                    }
                    else
                    {
                        ordem.CadastrarOrdem();

                        LimparCampos();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Preencha as informações obrigatórias");
            }
        }

        private void MTxtValor_Leave(object sender, EventArgs e)
        {
            string texto = MTxtValor.Text;
            texto = new string(texto.Where(char.IsDigit).ToArray());
            if (texto.Length < 5)
            {
                int x = 0; // para adicionar no máximo 2 zeros a direita
                for (int i = texto.Length; x < 2 && i < 5; i++)
                {
                    texto = texto.PadRight(i + 1, '0');
                    x++;
                }
                for (int i = texto.Length; i < 5; i++)
                {
                    texto = texto.PadLeft(i + 1, '0');
                }

                MTxtValor.Text = texto.ToString();
            }
        }

        private void MTxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                MTxtValor_Leave((Control)sender, e);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            abertoEmEdicao = true;

            BtnAlterar.Enabled = false;
            BtnFinalizar.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnSalvar.Enabled = true;

            DtData.Enabled = true;
            TxtIdCliente.ReadOnly = false;
            MTxtValor.ReadOnly = false;
            LbListaDePets.Enabled = true;
            TxtAdicionarProcedimento.ReadOnly = false;
            BtnAdicionarInsumo.Enabled = true;
            btnRemoverInsumo.Enabled = true;
            LbProcedimentos.Enabled = true;
            TxtCodInsumo.ReadOnly = false;
            btnPesquisaInsumo.Enabled = true;
            btnRemoverInsumo.Enabled = true;
            BtnAdicionarInsumo.Enabled = true;
            btnRemoverProcedimento.Enabled = true;
            BtnAdicionarProcedimento.Enabled = true;
            BtnBuscarCliente.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (abertoEmEdicao)
            {
                abertoEmEdicao = false;
                LimparCampos();
                frmCadastroOrdemDeServico_Load(sender, e);
            }
            else
            {
                DialogResult confirmaCancelamento = MessageBox.Show($"Deseja cancelar a Ordem de Serviço {ordem.Id}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmaCancelamento == DialogResult.Yes)
                {
                    ordem.CancelarOrdem();
                }
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult confirmaFinalizacao = MessageBox.Show($"Deseja finalizar a Ordem de Serviço {ordem.Id}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmaFinalizacao == DialogResult.Yes)
            {
                ordem.finalizarOrdem();
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            LblObservacoes_MouseHover(sender, e);
        }
    }
}