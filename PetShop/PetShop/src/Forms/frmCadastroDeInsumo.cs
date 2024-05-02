using PetShop.src.Models;
using System.Data;

namespace PetShop.src.Forms
{
    public partial class frmCadastroDeInsumo : Form
    {
        public int dadosRecebidos;
        private bool novoCadastro;
        private bool emEdicao;
        private Insumo insumo = new Insumo();
        public frmCadastroDeInsumo()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            TxtCodInsumo.Text = string.Empty;
            TxtCusto.Text = string.Empty;
            TxtDescricaoInsumo.Text = string.Empty;
            TxtEstoqueAtual.Text = string.Empty;
            TxtVolume.Text = string.Empty;
            LbCodigoBarras.Items.Clear();
            TxtAdicionarCodigoBarras.Text = string.Empty;
        }

        private void PreencherInsumo(int idInsumo)
        {
            LimparCampos();
            try
            {
                bool consultaInsumo = insumo.ConsultaInsumo(idInsumo);

                if (consultaInsumo)
                {
                    TxtCodInsumo.Text = insumo.Id.ToString();
                    TxtDescricaoInsumo.Text = insumo.Nome;
                    TxtCusto.Text = insumo.Custo.ToString();
                    TxtEstoqueAtual.Text = insumo.Estoque.ToString();
                    TxtVolume.Text = insumo.Volume.ToString();

                    switch (insumo.UnidadeMedida)
                    {
                        case "Litro":
                            CbUnidadeMedida.SelectedIndex = 0;
                            break;

                        case "Kg":
                            CbUnidadeMedida.SelectedIndex = 1;
                            break;
                    }


                    foreach (CodigoDeBarras item in insumo.ListaCodBarras)
                    {
                        if (!String.IsNullOrWhiteSpace(item.ToString()))
                        {
                            LbCodigoBarras.Items.Add(item.Barras);
                        }
                    }
                }
                else
                {
                    throw new Exception("Digite um ID válido!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnBuscarInsumo_Click(object sender, EventArgs e)
        {
            frmBuscaDeInsumos buscaDeInsumos = new frmBuscaDeInsumos();
            if (buscaDeInsumos.ShowDialog() == DialogResult.OK)
            {
                dadosRecebidos = buscaDeInsumos.idInsumo;

                PreencherInsumo(dadosRecebidos);

            }
        }


        private void BtnAdicionarCodigoBarras_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TxtAdicionarCodigoBarras.Text))
            {
                if (!VerificarCodigoBarras(TxtAdicionarCodigoBarras.Text))
                {
                    LbCodigoBarras.Items.Add(TxtAdicionarCodigoBarras.Text);
                    TxtAdicionarCodigoBarras.Clear();
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
            if (!string.IsNullOrEmpty(TxtCodInsumo.Text))
            {
                // Remove o caracter se nao for numero
                TxtCodInsumo.Text = new string(TxtCodInsumo.Text.Where(char.IsDigit).ToArray());
            }
        }


        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            novoCadastro = true;

            BtnCancelar.Enabled = true;
            BtnSalvar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnNovo.Enabled = false;

            TxtAdicionarCodigoBarras.ReadOnly = false;
            TxtCodInsumo.ReadOnly = false;
            btnRemoverCodigoBarras.Enabled = true;
            TxtDescricaoInsumo.ReadOnly = false;
            BtnAdicionarCodigoBarras.Enabled = true;
            TxtVolume.ReadOnly = false;
            CbUnidadeMedida.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnSalvar.Enabled = false;
            BtnAlterar.Enabled = true;
            BtnNovo.Enabled = true;
            BtnCancelar.Enabled = false;
            btnRemoverCodigoBarras.Enabled = false;
            BtnAdicionarCodigoBarras.Enabled = false;

            TxtAdicionarCodigoBarras.ReadOnly = true;
            TxtCodInsumo.ReadOnly = false;
            TxtDescricaoInsumo.ReadOnly = false;
            TxtVolume.ReadOnly = true;
            CbUnidadeMedida.Enabled = false;

            if (novoCadastro)
            {
                novoCadastro = false;
            }
            else if (emEdicao)
            {
                emEdicao = false;
            }
            LimparCampos();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(TxtDescricaoInsumo.Text) && !String.IsNullOrWhiteSpace(TxtVolume.Text)
                && CbUnidadeMedida.SelectedIndex != -1 && LbCodigoBarras.Items.Count > 0)
            {
                if (novoCadastro)
                {
                    string codigosDeBarras = "";
                    foreach (var item in LbCodigoBarras.Items)
                    {
                        codigosDeBarras += $"{item.ToString()} ; ";
                    }
                    Insumo i = new Insumo(TxtDescricaoInsumo.Text, codigosDeBarras, CbUnidadeMedida.SelectedItem.ToString(), Convert.ToDouble(TxtVolume.Text));
                    i.CadastrarInsumo();
                    BtnCancelar_Click(sender, e);
                }
                else if (emEdicao)
                {
                    Insumo i = new Insumo(insumo.Id,TxtDescricaoInsumo.Text, CbUnidadeMedida.SelectedItem.ToString(), Convert.ToDouble(TxtVolume.Text));

                    try
                    {
                        i.AlterarInsumo();

                        //verifica se algum barras consta no banco mas foi retirado da lista

                        //verificar cada codigo existente no banco
                        foreach (CodigoDeBarras codigoDeBarrasBanco in insumo.ListaCodBarras)
                        {
                            bool encontrado = false;
                            //verificar cada barras presente na listbox
                            foreach (string barrasNaListBox in LbCodigoBarras.Items)
                            {
                                if (codigoDeBarrasBanco.Barras == barrasNaListBox)
                                {
                                    encontrado = true;
                                }
                            }
                            //se nao foi encontrado algum barras do banco na list box, realiza a sua exclusao
                            if (!encontrado)
                            {
                                codigoDeBarrasBanco.ExcluirBarras();
                            }
                        }

                        //verifica todos os barras da lista e insere caso algum nao conste no banco

                        //verificar cada barras presente na listbox
                        foreach (string barrasNaListBox in LbCodigoBarras.Items)
                        {
                            bool encontrado = false;
                            CodigoDeBarras codParaInserir = new CodigoDeBarras();

                            //verificar cada codigo existente no banco
                            foreach (CodigoDeBarras codigoDeBarrasBanco in insumo.ListaCodBarras)
                            {
                                //codParaInserir.IdInsumo = codigoDeBarrasBanco.IdInsumo;
                                if (barrasNaListBox == codigoDeBarrasBanco.Barras)
                                {
                                    encontrado = true;
                                }
                            }
                            //se nao foi encontrado algum barras da list box no banco, realiza a sua inclusao
                            if (!encontrado)
                            {
                                codParaInserir.IdInsumo = insumo.Id;
                                codParaInserir.Barras = barrasNaListBox;
                                codParaInserir.CadastrarBarras();
                            }
                        }
                        MessageBox.Show("Insumo alterado!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    BtnCancelar_Click(sender, e);
                    PreencherInsumo(insumo.Id);
                }
            }
            else
            {
                MessageBox.Show("Preencha as informações obrigatórias!");
            }
        }

        private void TxtAdicionarCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BtnAdicionarCodigoBarras_Click(sender, e);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TxtCodInsumo.Text))
            {
                BtnAlterar.Enabled = false;
                BtnNovo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnSalvar.Enabled = true;
                emEdicao = true;

                TxtCodInsumo.ReadOnly = true;
                btnRemoverCodigoBarras.Enabled = true;
                BtnAdicionarCodigoBarras.Enabled = true;
                LbCodigoBarras.Enabled = true;
                TxtVolume.ReadOnly = false;
                TxtDescricaoInsumo.ReadOnly = false;
                CbUnidadeMedida.Enabled = true;
                TxtAdicionarCodigoBarras.ReadOnly = false;

            }
            else
            {
                MessageBox.Show("Selecione um Insumo");
            }
        }

        private void TxtCodInusmo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                PreencherInsumo(Convert.ToInt32(TxtCodInsumo.Text));
            }
        }
    }
}
