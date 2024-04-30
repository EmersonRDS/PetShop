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
using static PetShop.src.Forms.frmBuscaDeClientes;

namespace PetShop.src.Forms
{
    public partial class frmBuscaDeInsumos : Form
    {
        public int idInsumo;
        public frmBuscaDeInsumos()
        {
            InitializeComponent();

            Insumo i = new Insumo();

            DtgListaDeInsumos.DataSource = i.ListarInsumos();
            FormataGrid();
        }

        public enum ColunasGrid
        {
            Id = 0,
            Nome,
            Custo,
            CodBarras,
            Estoque,
            UnidadeMedida,
            Volume
        }

        public void FormataGrid()
        {
            var g = DtgListaDeInsumos;
            g.Columns[(int)ColunasGrid.Id].Width = Convert.ToInt32(g.Width * 0.10);
            g.Columns[(int)ColunasGrid.Nome].Width = Convert.ToInt32(g.Width * 0.60);
            g.Columns[(int)ColunasGrid.Custo].Visible = false;
            g.Columns[(int)ColunasGrid.CodBarras].Width = Convert.ToInt32(g.Width * 0.25);
            g.Columns[(int)ColunasGrid.Estoque].Visible = false;
            g.Columns[(int)ColunasGrid.UnidadeMedida].Visible = false;
            g.Columns[(int)ColunasGrid.Volume].Visible = false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (CbFiltro.SelectedIndex == 0 || CbFiltro.SelectedIndex == 1)
            {
                if (!String.IsNullOrWhiteSpace(TxtConteudoParaFiltro.Text))
                {
                    Insumo insumo = new Insumo();
                    string filtro = CbFiltro.Text;
                    string conteudo = TxtConteudoParaFiltro.Text;

                    DtgListaDeInsumos.DataSource = insumo.ListarInsumoComFiltro(conteudo, filtro);
                }
                else
                {
                    Insumo insumo = new Insumo();
                    DtgListaDeInsumos.DataSource = insumo.ListarInsumos();
                    FormataGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione o Filtro");
            }
            FormataGrid();
            DtgListaDeInsumos.Focus();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Row = DtgListaDeInsumos.SelectedRows[0];
            idInsumo = Convert.ToInt32(Row.Cells[(int)ColunasGrid.Id].Value.ToString());
            DialogResult = DialogResult.OK;

            Close();
        }

        private void TxtConteudoParaFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                BtnBuscar_Click(sender, e);
            }
        }

        private void DtgListaDeInsumos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnConfirmar_Click(sender, e);
        }
    }
}
