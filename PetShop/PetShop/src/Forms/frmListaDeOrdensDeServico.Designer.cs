namespace PetShop.src.Forms
{
    partial class frmListaDeOrdensDeServico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDeOrdensDeServico));
            PnlFiltros = new Panel();
            LblStatus = new Label();
            CbStatus = new ComboBox();
            LblFiltroConteudo = new Label();
            TxtFiltro = new TextBox();
            LblFiltro = new Label();
            CBfiltro = new ComboBox();
            LblDataFinal = new Label();
            DtDataFinal = new DateTimePicker();
            LblDataInicial = new Label();
            DtDataInicial = new DateTimePicker();
            BtnBuscar = new Button();
            PnlCards = new Panel();
            PnlFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // PnlFiltros
            // 
            PnlFiltros.BackColor = Color.Teal;
            PnlFiltros.Controls.Add(LblStatus);
            PnlFiltros.Controls.Add(CbStatus);
            PnlFiltros.Controls.Add(LblFiltroConteudo);
            PnlFiltros.Controls.Add(TxtFiltro);
            PnlFiltros.Controls.Add(LblFiltro);
            PnlFiltros.Controls.Add(CBfiltro);
            PnlFiltros.Controls.Add(LblDataFinal);
            PnlFiltros.Controls.Add(DtDataFinal);
            PnlFiltros.Controls.Add(LblDataInicial);
            PnlFiltros.Controls.Add(DtDataInicial);
            PnlFiltros.Controls.Add(BtnBuscar);
            PnlFiltros.Location = new Point(-1, 0);
            PnlFiltros.Name = "PnlFiltros";
            PnlFiltros.Size = new Size(801, 86);
            PnlFiltros.TabIndex = 0;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Location = new Point(594, 9);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(39, 15);
            LblStatus.TabIndex = 10;
            LblStatus.Text = "Status";
            // 
            // CbStatus
            // 
            CbStatus.FormattingEnabled = true;
            CbStatus.Items.AddRange(new object[] { "Em Aberto", "Fechado", "Cancelado" });
            CbStatus.Location = new Point(594, 27);
            CbStatus.Name = "CbStatus";
            CbStatus.Size = new Size(101, 23);
            CbStatus.TabIndex = 9;
            // 
            // LblFiltroConteudo
            // 
            LblFiltroConteudo.AutoSize = true;
            LblFiltroConteudo.Location = new Point(443, 9);
            LblFiltroConteudo.Name = "LblFiltroConteudo";
            LblFiltroConteudo.Size = new Size(34, 15);
            LblFiltroConteudo.TabIndex = 8;
            LblFiltroConteudo.Text = "Filtro";
            // 
            // TxtFiltro
            // 
            TxtFiltro.Location = new Point(443, 27);
            TxtFiltro.Name = "TxtFiltro";
            TxtFiltro.PlaceholderText = "Digite o conteúdo";
            TxtFiltro.Size = new Size(138, 23);
            TxtFiltro.TabIndex = 7;
            // 
            // LblFiltro
            // 
            LblFiltro.AutoSize = true;
            LblFiltro.Location = new Point(315, 9);
            LblFiltro.Name = "LblFiltro";
            LblFiltro.Size = new Size(58, 15);
            LblFiltro.TabIndex = 6;
            LblFiltro.Text = "Filtrar por";
            // 
            // CBfiltro
            // 
            CBfiltro.FormattingEnabled = true;
            CBfiltro.Items.AddRange(new object[] { "Nome do Cliente", "Nome do Pet" });
            CBfiltro.Location = new Point(315, 27);
            CBfiltro.Name = "CBfiltro";
            CBfiltro.Size = new Size(115, 23);
            CBfiltro.TabIndex = 5;
            // 
            // LblDataFinal
            // 
            LblDataFinal.AutoSize = true;
            LblDataFinal.Location = new Point(175, 9);
            LblDataFinal.Name = "LblDataFinal";
            LblDataFinal.Size = new Size(59, 15);
            LblDataFinal.TabIndex = 4;
            LblDataFinal.Text = "Data Final";
            // 
            // DtDataFinal
            // 
            DtDataFinal.CustomFormat = "dd/MM/yyyy HH:mm";
            DtDataFinal.Format = DateTimePickerFormat.Custom;
            DtDataFinal.Location = new Point(175, 27);
            DtDataFinal.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            DtDataFinal.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            DtDataFinal.Name = "DtDataFinal";
            DtDataFinal.Size = new Size(127, 23);
            DtDataFinal.TabIndex = 3;
            // 
            // LblDataInicial
            // 
            LblDataInicial.AutoSize = true;
            LblDataInicial.Location = new Point(35, 9);
            LblDataInicial.Name = "LblDataInicial";
            LblDataInicial.Size = new Size(65, 15);
            LblDataInicial.TabIndex = 2;
            LblDataInicial.Text = "Data Inicial";
            // 
            // DtDataInicial
            // 
            DtDataInicial.CustomFormat = "dd/MM/yyyy HH:mm";
            DtDataInicial.Format = DateTimePickerFormat.Custom;
            DtDataInicial.Location = new Point(35, 27);
            DtDataInicial.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            DtDataInicial.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            DtDataInicial.Name = "DtDataInicial";
            DtDataInicial.Size = new Size(127, 23);
            DtDataInicial.TabIndex = 1;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(708, 27);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(58, 23);
            BtnBuscar.TabIndex = 0;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // PnlCards
            // 
            PnlCards.Location = new Point(12, 92);
            PnlCards.Name = "PnlCards";
            PnlCards.Size = new Size(776, 354);
            PnlCards.TabIndex = 1;
            // 
            // frmListaDeOrdensDeServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(PnlCards);
            Controls.Add(PnlFiltros);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "frmListaDeOrdensDeServico";
            Text = "Busca de Ordens de Serviço";
            Load += frmListaDeOrdensDeServico_Load;
            PnlFiltros.ResumeLayout(false);
            PnlFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlFiltros;
        private Panel PnlCards;
        private Button BtnBuscar;
        private DateTimePicker DtDataInicial;
        private Label LblDataInicial;
        private Label LblDataFinal;
        private DateTimePicker DtDataFinal;
        private Label LblFiltro;
        private ComboBox CBfiltro;
        private TextBox TxtFiltro;
        private Label LblStatus;
        private ComboBox CbStatus;
        private Label LblFiltroConteudo;
    }
}