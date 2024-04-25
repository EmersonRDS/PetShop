using PetShop.src.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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
                groupBox.Name = $"GbOrdemDeServico{item.Id}";
                // coloca o proximo GroupBox para baixo quando a linha ja possui 2 GroupBox e zera os campos, para repetir o processo
                if (controladorVertical == 2)
                {
                    eixoY += 160;
                    controladorVertical = 0;
                    controladorHorizontal = 0;
                    controladorHeight++;
                }
                //Adiciona os dois GroupBox na linha, aumenta o controlador vertical em 1 sempre que executado
                switch (controladorHorizontal)
                {
                    case 0:
                        groupBox.Location = new Point(eixoX1, eixoY);
                        controladorVertical++;
                        controladorHorizontal++;
                        if (controladorHeight >= 2)
                        {
                            PnlCards.Height += 146;
                        }
                        break;
                    case 1:
                        groupBox.Location = new Point(eixoX2, eixoY);
                        controladorVertical++;
                        break;
                }
                groupBox.Size = new Size(300, 146);
                groupBox.DoubleClick += SelecionarCard;

                PnlCards.Controls.Add(groupBox);
                //adiciona os labels com as informações da Ordem de serviço
                Label labelCLiente = new Label();
                labelCLiente.Text = $"Cliente: {item.NomeCliente}";
                labelCLiente.AutoSize = true;
                labelCLiente.Location = new Point(20, 20);
                labelCLiente.DoubleClick += SelecionarCard;
                groupBox.Controls.Add(labelCLiente);

                Label labelPet = new Label();
                labelPet.Text = $"Pet: {item.NomePet}";
                labelPet.AutoSize = true;
                labelPet.Location = new Point(20, 40);
                labelPet.DoubleClick += SelecionarCard;
                groupBox.Controls.Add(labelPet);

                Label labelValor = new Label();
                labelValor.Text = $"Valor: R$ {item.Valor}";
                labelValor.AutoSize = true;
                labelValor.Location = new Point(20, 60);
                labelValor.DoubleClick += SelecionarCard;
                groupBox.Controls.Add(labelValor);

                Label labelData = new Label();
                labelData.AutoSize = true;
                labelData.Text = $"Horário: {item.Data.ToString("dd/MM/yyyy - HH:mm")}";
                labelData.Location = new Point(20, 80);
                labelData.DoubleClick += SelecionarCard;
                groupBox.Controls.Add(labelData);

                //Diminui a Width dos paineis para não criar uma barra de scroll horizontal
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

        private void SelecionarCard(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.GroupBox)
            {
                System.Windows.Forms.GroupBox groupBox = sender as System.Windows.Forms.GroupBox;

                string groupBoxIdOrdem = groupBox.Text;
                frmCadastroOrdemDeServico cadastroOrdemDeServico = new frmCadastroOrdemDeServico();
                cadastroOrdemDeServico.abertoPorListaDeOrdens = true;
                cadastroOrdemDeServico.ordem.Id = Convert.ToInt32(groupBoxIdOrdem);
                cadastroOrdemDeServico.Show();
            }
            if (sender is Label)
            {
                // Obtém o GroupBox pai do Label
                System.Windows.Forms.GroupBox groupBox = ((sender as Label).Parent) as System.Windows.Forms.GroupBox;
                if (groupBox != null)
                {
                    SelecionarCard(groupBox, e);
                }
            }
        }

    }
}
