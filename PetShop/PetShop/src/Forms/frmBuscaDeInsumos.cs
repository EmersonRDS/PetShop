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
    public partial class frmBuscaDeInsumos : Form
    {
        public int idInsumos;
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
    }
}
