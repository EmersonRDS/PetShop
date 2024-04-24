using PetShop.src.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            }else if (abertoPorListaDeOrdens)
            {
                BtnAlterar.Enabled = true;
                BtnFinalizar.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnSalvar.Enabled = false;

                //preencher campos
                TxtCodigoOrdem.Text = ordem.Id.ToString();
                ordem.ConsultarOrdem();
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
                BuscaDeCliente(Convert.ToInt32(TxtIdCliente.Text));
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
                try{
                    string procedimentos = "";
                    foreach (var item in LbProcedimentos.Items)
                    {
                        procedimentos += item.ToString() + " ; ";
                    }
                    ordem = new OrdemDeServico(Convert.ToInt32(TxtIdCliente.Text), c.PetsDoCliente[LbListaDePets.SelectedIndex].Id,
                        ObterValor(MTxtValor.Text), DtData.Value, procedimentos);

                    ordem.cadastrarOrdem();

                    LimparCampos();
                }catch (Exception ex)
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
    }
}