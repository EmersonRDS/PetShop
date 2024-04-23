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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PetShop.src.Forms
{
    public partial class frmListaDeOrdensDeServico : Form
    {
        public frmListaDeOrdensDeServico()
        {
            InitializeComponent();
        }

        private void CriarOrdem(List<OrdemDeServico> ordem)
        {
            PnlCards.Height = 354;
            PnlFiltros.Width = 801;
            PnlCards.Width = 776;
            PnlCards.Controls.Clear();
            int controladorHorizontal = 0;
            int controladorVertical = 0;
            int controladorHeight = 0;
            int eixoX1 = 50;
            int eixoX2 = 400;
            int eixoY = 20;
            bool diminuiuWidth = false;

            foreach (var item in ordem)
            {
                System.Windows.Forms.GroupBox groupBox = new System.Windows.Forms.GroupBox();
                groupBox.Text = $"{item.Id}";

                if (controladorVertical == 2)
                {
                    eixoY += 160;
                    controladorVertical = 0;
                    controladorHorizontal = 0;
                    controladorHeight++;
                }

                switch (controladorHorizontal)
                {
                    case 0:
                        groupBox.Location = new Point(eixoX1, eixoY);
                        controladorVertical++;
                        controladorHorizontal++;
                        if (controladorHeight >= 2)
                        {
                            PnlCards.Height += 146;
                            PnlFiltros.Width -= 9;
                            PnlCards.Width -= 5;
                        }
                        break;
                    case 1:
                        groupBox.Location = new Point(eixoX2, eixoY);
                        controladorVertical++;
                        break;
                }
                groupBox.Size = new Size(300, 146);

                PnlCards.Controls.Add(groupBox);

                if (!diminuiuWidth)
                {
                    PnlFiltros.Width -= 17;
                    PnlCards.Width -= 7;
                    diminuiuWidth = true;
                    PnlCards.Height += 20;
                }
            }
        }


        private void frmListaDeOrdensDeServico_Load(object sender, EventArgs e)
        {
            CBfiltro.SelectedIndex = 0;
            CbStatus.SelectedIndex = 0;
            DateTime hoje = DateTime.Now;
            DtDataInicial.Value = new DateTime(hoje.Year, hoje.Month, hoje.Day, 0, 0, 0);
            DtDataFinal.Value = new DateTime(hoje.Year, hoje.Month, hoje.Day, 23, 59, 59);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OrdemDeServico ordem = new OrdemDeServico();
            int status;
            if (CbStatus.SelectedItem.ToString() == "Em Aberto")
            {
                status = 1;
            }else if(CbStatus.SelectedItem.ToString() == "Fechado")
            {
                status = 2;
            }
            else
            {
                status = 0;
            }

            List<OrdemDeServico> listaOrdens = ordem.ConsultarOrdens(DtDataInicial.Value,DtDataFinal.Value,CBfiltro.SelectedItem.ToString(),TxtFiltro.Text,status);

            CriarOrdem(listaOrdens);

        }
    }
}
