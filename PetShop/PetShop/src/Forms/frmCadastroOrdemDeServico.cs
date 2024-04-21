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
        Cliente c = new Cliente();
        private string observacoesPet;
        public frmCadastroOrdemDeServico()
        {
            InitializeComponent();
        }

        public void PreencherCamposPets(int indexLista)
        {
            GbInformacoesDoPet.Visible = true;
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
    }
}
