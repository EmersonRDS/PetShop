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

namespace PetShop.src.Forms
{
    public partial class frmCadastroDeInsumo : Form
    {
        public int dadosRecebidos;
        private bool novoCadastro;
        private bool emEdicao;
        public frmCadastroDeInsumo()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            TxtCodInusmo.Text = string.Empty;
            TxtCusto.Text = string.Empty;
            TxtDescricaoInsumo.Text = string.Empty;
            TxtEstoqueAtual.Text = string.Empty;
            TxtVolume.Text = string.Empty;
            LbCodigoBarras.Items.Clear();
            TxtAdicionarCodigoBarras.Text = string.Empty;
        }

        private void BtnBuscarInsumo_Click(object sender, EventArgs e)
        {
            frmBuscaDeInsumos buscaDeInsumos = new frmBuscaDeInsumos();
            if (buscaDeInsumos.ShowDialog() == DialogResult.OK)
            {
                dadosRecebidos = buscaDeInsumos.idInsumos;

                Insumo i = new Insumo();
                i.ConsultaInsumo(dadosRecebidos);
                TxtCodInusmo.Text = i.Id.ToString();

            }
        }


        private void BtnAdicionarCodigoBarras_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TxtAdicionarCodigoBarras.Text))
            {
                if (!VerificarCodigoBarras(TxtAdicionarCodigoBarras.Text))
                {
                    LbCodigoBarras.Items.Add(TxtAdicionarCodigoBarras.Text);
                }
                else
                {
                    MessageBox.Show("Código de barras já adicionado!");
                }

            }
            else
            {
                MessageBox.Show("Digite um código de barras!");
            }
        }

        private void btnRemoverCodigoBarras_Click(object sender, EventArgs e)
        {
            if (LbCodigoBarras.SelectedIndex != -1)
            {
                LbCodigoBarras.Items.RemoveAt(LbCodigoBarras.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione o código que deseja remover!");
            }
        }

        private bool VerificarCodigoBarras(string Barras)
        {
            foreach (var item in LbCodigoBarras.Items)
            {
                if (item.ToString() == Barras)
                {
                    return true;
                }
            }
            return false;
        }

        private void TxtAdicionarCodigoBarras_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtAdicionarCodigoBarras.Text))
            {
                // Remove o caracter se nao for numero
                TxtAdicionarCodigoBarras.Text = new string(TxtAdicionarCodigoBarras.Text.Where(char.IsDigit).ToArray());
            }
        }

        private void TxtCodInusmo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCodInusmo.Text))
            {
                // Remove o caracter se nao for numero
                TxtCodInusmo.Text = new string(TxtCodInusmo.Text.Where(char.IsDigit).ToArray());
            }
        }


        private void BtnNovo_Click(object sender, EventArgs e)
        {
            novoCadastro = true;

            BtnCancelar.Enabled = true;
            BtnSalvar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnNovo.Enabled = false;

            TxtAdicionarCodigoBarras.ReadOnly = false;
            btnRemoverCodigoBarras.Enabled = true;
            TxtDescricaoInsumo.ReadOnly = false;
            BtnAdicionarCodigoBarras.Enabled = true;
            TxtVolume.ReadOnly = false;
            CbUnidadeMedida.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (novoCadastro)
            {
                BtnSalvar.Enabled = false;
                BtnAlterar.Enabled = true;
                BtnNovo.Enabled = true;
                BtnCancelar.Enabled = false;
                btnRemoverCodigoBarras.Enabled = false;
                BtnAdicionarCodigoBarras.Enabled = false;

                TxtAdicionarCodigoBarras.ReadOnly = true;
                TxtDescricaoInsumo.ReadOnly = false;
                TxtVolume.ReadOnly = true;
                CbUnidadeMedida.Enabled = false;

                LimparCampos();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (novoCadastro)
            {
                if (!String.IsNullOrWhiteSpace(TxtDescricaoInsumo.Text) && !String.IsNullOrWhiteSpace(TxtVolume.Text)
                    && CbUnidadeMedida.SelectedIndex != -1 && LbCodigoBarras.Items.Count > 0)
                {
                    MessageBox.Show("Validou");
                }
                else
                {
                    MessageBox.Show("Preencha as informações obrigatórias!");
                }
            }
        }
    }
}
