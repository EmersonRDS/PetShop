﻿namespace PetShop.src.Forms
{
    partial class frmCadastroOrdemDeServico
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroOrdemDeServico));
            LblPedido = new Label();
            TxtCodigoPedido = new TextBox();
            TxtNomeDoCliente = new TextBox();
            LblIdCliente = new Label();
            TxtIdCliente = new TextBox();
            BtnBuscarCliente = new Button();
            LblNomeCliente = new Label();
            LbListaDePets = new ListBox();
            LblListaDePets = new Label();
            DtData = new DateTimePicker();
            LblData = new Label();
            GbInformacoesDoPet = new GroupBox();
            PnlIdade = new Panel();
            LblIdadeDado = new Label();
            LblIdade = new Label();
            PnlAlergicoObservacao = new Panel();
            PnlObservacoes = new Panel();
            LblObservacoes = new Label();
            LblAlergicoDado = new Label();
            PnlPorteVacinado = new Panel();
            LblPorteDado = new Label();
            LblPorte = new Label();
            LblVacinadoDado = new Label();
            PnlRacaPelo = new Panel();
            LblRacaDado = new Label();
            LblPeloDado = new Label();
            LblRaca = new Label();
            LblPelo = new Label();
            MTxtValor = new MaskedTextBox();
            LblValor = new Label();
            dataGridView1 = new DataGridView();
            BtnAdicionarInsumo = new Button();
            btnRemoverInsumo = new Button();
            textBox1 = new TextBox();
            btnPesquisaInsumo = new Button();
            textBox2 = new TextBox();
            LblIdInsumo = new Label();
            LblDescricaoInsumo = new Label();
            LblProcedimentos = new Label();
            LbProcedimentos = new ListBox();
            TxtAdicionarProcedimento = new TextBox();
            btnRemoverProcedimento = new Button();
            BtnAdicionarProcedimento = new Button();
            BtnCadastrar = new Button();
            TTObservacao = new ToolTip(components);
            GbInformacoesDoPet.SuspendLayout();
            PnlIdade.SuspendLayout();
            PnlAlergicoObservacao.SuspendLayout();
            PnlObservacoes.SuspendLayout();
            PnlPorteVacinado.SuspendLayout();
            PnlRacaPelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LblPedido
            // 
            LblPedido.AutoSize = true;
            LblPedido.Location = new Point(12, 9);
            LblPedido.Name = "LblPedido";
            LblPedido.Size = new Size(103, 15);
            LblPedido.TabIndex = 0;
            LblPedido.Text = "Código do Pedido";
            // 
            // TxtCodigoPedido
            // 
            TxtCodigoPedido.Location = new Point(12, 26);
            TxtCodigoPedido.Name = "TxtCodigoPedido";
            TxtCodigoPedido.Size = new Size(100, 23);
            TxtCodigoPedido.TabIndex = 1;
            // 
            // TxtNomeDoCliente
            // 
            TxtNomeDoCliente.Location = new Point(416, 27);
            TxtNomeDoCliente.Name = "TxtNomeDoCliente";
            TxtNomeDoCliente.PlaceholderText = "Nome do Cliente";
            TxtNomeDoCliente.ReadOnly = true;
            TxtNomeDoCliente.Size = new Size(197, 23);
            TxtNomeDoCliente.TabIndex = 3;
            // 
            // LblIdCliente
            // 
            LblIdCliente.AutoSize = true;
            LblIdCliente.Location = new Point(295, 9);
            LblIdCliente.Name = "LblIdCliente";
            LblIdCliente.Size = new Size(72, 15);
            LblIdCliente.TabIndex = 4;
            LblIdCliente.Text = "Cod. Cliente";
            // 
            // TxtIdCliente
            // 
            TxtIdCliente.Location = new Point(295, 27);
            TxtIdCliente.Name = "TxtIdCliente";
            TxtIdCliente.Size = new Size(72, 23);
            TxtIdCliente.TabIndex = 5;
            TxtIdCliente.TextChanged += TxtIdCliente_TextChanged;
            TxtIdCliente.KeyPress += TxtIdCliente_KeyPress;
            // 
            // BtnBuscarCliente
            // 
            BtnBuscarCliente.Image = Properties.Resources.BuscarCliente;
            BtnBuscarCliente.Location = new Point(373, 27);
            BtnBuscarCliente.Name = "BtnBuscarCliente";
            BtnBuscarCliente.Size = new Size(37, 23);
            BtnBuscarCliente.TabIndex = 6;
            BtnBuscarCliente.UseVisualStyleBackColor = true;
            BtnBuscarCliente.Click += BtnBuscarCliente_Click;
            // 
            // LblNomeCliente
            // 
            LblNomeCliente.AutoSize = true;
            LblNomeCliente.Location = new Point(416, 9);
            LblNomeCliente.Name = "LblNomeCliente";
            LblNomeCliente.Size = new Size(44, 15);
            LblNomeCliente.TabIndex = 2;
            LblNomeCliente.Text = "Cliente";
            // 
            // LbListaDePets
            // 
            LbListaDePets.FormattingEnabled = true;
            LbListaDePets.ItemHeight = 15;
            LbListaDePets.Location = new Point(12, 84);
            LbListaDePets.Name = "LbListaDePets";
            LbListaDePets.Size = new Size(149, 79);
            LbListaDePets.TabIndex = 29;
            LbListaDePets.Click += LbListaDePets_Click;
            // 
            // LblListaDePets
            // 
            LblListaDePets.AutoSize = true;
            LblListaDePets.Location = new Point(12, 66);
            LblListaDePets.Name = "LblListaDePets";
            LblListaDePets.Size = new Size(84, 15);
            LblListaDePets.TabIndex = 30;
            LblListaDePets.Text = "Pets do cliente";
            // 
            // DtData
            // 
            DtData.CustomFormat = "dd/MM/yyyy - HH:mm";
            DtData.Format = DateTimePickerFormat.Custom;
            DtData.Location = new Point(129, 26);
            DtData.Name = "DtData";
            DtData.Size = new Size(142, 23);
            DtData.TabIndex = 33;
            // 
            // LblData
            // 
            LblData.AutoSize = true;
            LblData.Location = new Point(129, 8);
            LblData.Name = "LblData";
            LblData.Size = new Size(104, 15);
            LblData.TabIndex = 34;
            LblData.Text = "Horário do Pedido";
            // 
            // GbInformacoesDoPet
            // 
            GbInformacoesDoPet.Controls.Add(PnlIdade);
            GbInformacoesDoPet.Controls.Add(PnlAlergicoObservacao);
            GbInformacoesDoPet.Controls.Add(PnlPorteVacinado);
            GbInformacoesDoPet.Controls.Add(PnlRacaPelo);
            GbInformacoesDoPet.Location = new Point(181, 84);
            GbInformacoesDoPet.Name = "GbInformacoesDoPet";
            GbInformacoesDoPet.Size = new Size(560, 79);
            GbInformacoesDoPet.TabIndex = 35;
            GbInformacoesDoPet.TabStop = false;
            GbInformacoesDoPet.Text = "Informações do Pet";
            // 
            // PnlIdade
            // 
            PnlIdade.Controls.Add(LblIdadeDado);
            PnlIdade.Controls.Add(LblIdade);
            PnlIdade.Location = new Point(471, 13);
            PnlIdade.Name = "PnlIdade";
            PnlIdade.Size = new Size(83, 60);
            PnlIdade.TabIndex = 3;
            // 
            // LblIdadeDado
            // 
            LblIdadeDado.AutoSize = true;
            LblIdadeDado.Location = new Point(42, 6);
            LblIdadeDado.Name = "LblIdadeDado";
            LblIdadeDado.Size = new Size(13, 15);
            LblIdadeDado.TabIndex = 1;
            LblIdadeDado.Text = "0";
            // 
            // LblIdade
            // 
            LblIdade.AutoSize = true;
            LblIdade.Location = new Point(3, 6);
            LblIdade.Name = "LblIdade";
            LblIdade.Size = new Size(39, 15);
            LblIdade.TabIndex = 0;
            LblIdade.Text = "Idade:";
            // 
            // PnlAlergicoObservacao
            // 
            PnlAlergicoObservacao.Controls.Add(PnlObservacoes);
            PnlAlergicoObservacao.Controls.Add(LblAlergicoDado);
            PnlAlergicoObservacao.Location = new Point(320, 13);
            PnlAlergicoObservacao.Name = "PnlAlergicoObservacao";
            PnlAlergicoObservacao.Size = new Size(121, 60);
            PnlAlergicoObservacao.TabIndex = 2;
            // 
            // PnlObservacoes
            // 
            PnlObservacoes.Controls.Add(LblObservacoes);
            PnlObservacoes.Location = new Point(3, 24);
            PnlObservacoes.Name = "PnlObservacoes";
            PnlObservacoes.Size = new Size(88, 33);
            PnlObservacoes.TabIndex = 1;
            // 
            // LblObservacoes
            // 
            LblObservacoes.AutoSize = true;
            LblObservacoes.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            LblObservacoes.ForeColor = SystemColors.Highlight;
            LblObservacoes.Location = new Point(3, 7);
            LblObservacoes.Name = "LblObservacoes";
            LblObservacoes.Size = new Size(74, 15);
            LblObservacoes.TabIndex = 0;
            LblObservacoes.Text = "Observações";
            LblObservacoes.MouseHover += LblObservacoes_MouseHover;
            // 
            // LblAlergicoDado
            // 
            LblAlergicoDado.AutoSize = true;
            LblAlergicoDado.Location = new Point(3, 6);
            LblAlergicoDado.Name = "LblAlergicoDado";
            LblAlergicoDado.Size = new Size(73, 15);
            LblAlergicoDado.TabIndex = 0;
            LblAlergicoDado.Text = "Sem alergias";
            // 
            // PnlPorteVacinado
            // 
            PnlPorteVacinado.Controls.Add(LblPorteDado);
            PnlPorteVacinado.Controls.Add(LblPorte);
            PnlPorteVacinado.Controls.Add(LblVacinadoDado);
            PnlPorteVacinado.Location = new Point(203, 13);
            PnlPorteVacinado.Name = "PnlPorteVacinado";
            PnlPorteVacinado.Size = new Size(93, 60);
            PnlPorteVacinado.TabIndex = 1;
            // 
            // LblPorteDado
            // 
            LblPorteDado.AutoSize = true;
            LblPorteDado.Location = new Point(45, 6);
            LblPorteDado.Name = "LblPorteDado";
            LblPorteDado.Size = new Size(15, 15);
            LblPorteDado.TabIndex = 2;
            LblPorteDado.Text = "G";
            // 
            // LblPorte
            // 
            LblPorte.AutoSize = true;
            LblPorte.Location = new Point(3, 6);
            LblPorte.Name = "LblPorte";
            LblPorte.Size = new Size(38, 15);
            LblPorte.TabIndex = 1;
            LblPorte.Text = "Porte:";
            // 
            // LblVacinadoDado
            // 
            LblVacinadoDado.AutoSize = true;
            LblVacinadoDado.Location = new Point(3, 31);
            LblVacinadoDado.Name = "LblVacinadoDado";
            LblVacinadoDado.Size = new Size(80, 15);
            LblVacinadoDado.TabIndex = 0;
            LblVacinadoDado.Text = "Não Vacinado";
            // 
            // PnlRacaPelo
            // 
            PnlRacaPelo.Controls.Add(LblRacaDado);
            PnlRacaPelo.Controls.Add(LblPeloDado);
            PnlRacaPelo.Controls.Add(LblRaca);
            PnlRacaPelo.Controls.Add(LblPelo);
            PnlRacaPelo.Location = new Point(6, 13);
            PnlRacaPelo.Name = "PnlRacaPelo";
            PnlRacaPelo.Size = new Size(191, 60);
            PnlRacaPelo.TabIndex = 0;
            // 
            // LblRacaDado
            // 
            LblRacaDado.AutoSize = true;
            LblRacaDado.Location = new Point(44, 6);
            LblRacaDado.Name = "LblRacaDado";
            LblRacaDado.Size = new Size(84, 15);
            LblRacaDado.TabIndex = 3;
            LblRacaDado.Text = "Nome da Raça";
            // 
            // LblPeloDado
            // 
            LblPeloDado.AutoSize = true;
            LblPeloDado.Location = new Point(44, 31);
            LblPeloDado.Name = "LblPeloDado";
            LblPeloDado.Size = new Size(73, 15);
            LblPeloDado.TabIndex = 1;
            LblPeloDado.Text = "Tipo do pelo";
            // 
            // LblRaca
            // 
            LblRaca.AutoSize = true;
            LblRaca.Location = new Point(3, 6);
            LblRaca.Name = "LblRaca";
            LblRaca.Size = new Size(35, 15);
            LblRaca.TabIndex = 2;
            LblRaca.Text = "Raça:";
            // 
            // LblPelo
            // 
            LblPelo.AutoSize = true;
            LblPelo.Location = new Point(5, 31);
            LblPelo.Name = "LblPelo";
            LblPelo.Size = new Size(33, 15);
            LblPelo.TabIndex = 0;
            LblPelo.Text = "Pelo:";
            // 
            // MTxtValor
            // 
            MTxtValor.Location = new Point(641, 29);
            MTxtValor.Mask = "$ ###,00";
            MTxtValor.Name = "MTxtValor";
            MTxtValor.PromptChar = ' ';
            MTxtValor.Size = new Size(100, 23);
            MTxtValor.TabIndex = 38;
            MTxtValor.Text = "00000";
            // 
            // LblValor
            // 
            LblValor.AutoSize = true;
            LblValor.Location = new Point(641, 11);
            LblValor.Name = "LblValor";
            LblValor.Size = new Size(33, 15);
            LblValor.TabIndex = 39;
            LblValor.Text = "Valor";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(248, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(458, 123);
            dataGridView1.TabIndex = 40;
            // 
            // BtnAdicionarInsumo
            // 
            BtnAdicionarInsumo.Image = Properties.Resources.btnAdicionar;
            BtnAdicionarInsumo.Location = new Point(712, 227);
            BtnAdicionarInsumo.Name = "BtnAdicionarInsumo";
            BtnAdicionarInsumo.Size = new Size(29, 25);
            BtnAdicionarInsumo.TabIndex = 41;
            BtnAdicionarInsumo.UseVisualStyleBackColor = true;
            // 
            // btnRemoverInsumo
            // 
            btnRemoverInsumo.Image = Properties.Resources.btnRemover;
            btnRemoverInsumo.Location = new Point(712, 255);
            btnRemoverInsumo.Name = "btnRemoverInsumo";
            btnRemoverInsumo.Size = new Size(29, 25);
            btnRemoverInsumo.TabIndex = 42;
            btnRemoverInsumo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(368, 198);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(338, 23);
            textBox1.TabIndex = 43;
            // 
            // btnPesquisaInsumo
            // 
            btnPesquisaInsumo.Image = Properties.Resources.btnLupa;
            btnPesquisaInsumo.Location = new Point(332, 196);
            btnPesquisaInsumo.Name = "btnPesquisaInsumo";
            btnPesquisaInsumo.Size = new Size(30, 23);
            btnPesquisaInsumo.TabIndex = 44;
            btnPesquisaInsumo.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(78, 23);
            textBox2.TabIndex = 45;
            // 
            // LblIdInsumo
            // 
            LblIdInsumo.AutoSize = true;
            LblIdInsumo.Location = new Point(248, 179);
            LblIdInsumo.Name = "LblIdInsumo";
            LblIdInsumo.Size = new Size(75, 15);
            LblIdInsumo.TabIndex = 46;
            LblIdInsumo.Text = "Cod. Insumo";
            // 
            // LblDescricaoInsumo
            // 
            LblDescricaoInsumo.AutoSize = true;
            LblDescricaoInsumo.Location = new Point(368, 180);
            LblDescricaoInsumo.Name = "LblDescricaoInsumo";
            LblDescricaoInsumo.Size = new Size(58, 15);
            LblDescricaoInsumo.TabIndex = 47;
            LblDescricaoInsumo.Text = "Descrição";
            // 
            // LblProcedimentos
            // 
            LblProcedimentos.AutoSize = true;
            LblProcedimentos.Location = new Point(12, 179);
            LblProcedimentos.Name = "LblProcedimentos";
            LblProcedimentos.Size = new Size(87, 15);
            LblProcedimentos.TabIndex = 37;
            LblProcedimentos.Text = "Procedimentos";
            // 
            // LbProcedimentos
            // 
            LbProcedimentos.FormattingEnabled = true;
            LbProcedimentos.ItemHeight = 15;
            LbProcedimentos.Location = new Point(12, 226);
            LbProcedimentos.Name = "LbProcedimentos";
            LbProcedimentos.Size = new Size(186, 124);
            LbProcedimentos.TabIndex = 48;
            // 
            // TxtAdicionarProcedimento
            // 
            TxtAdicionarProcedimento.Location = new Point(12, 197);
            TxtAdicionarProcedimento.Name = "TxtAdicionarProcedimento";
            TxtAdicionarProcedimento.PlaceholderText = "Digite o procedimento";
            TxtAdicionarProcedimento.Size = new Size(186, 23);
            TxtAdicionarProcedimento.TabIndex = 49;
            TxtAdicionarProcedimento.KeyPress += TxtAdicionarProcedimento_KeyPress;
            // 
            // btnRemoverProcedimento
            // 
            btnRemoverProcedimento.Image = Properties.Resources.btnRemover;
            btnRemoverProcedimento.Location = new Point(204, 255);
            btnRemoverProcedimento.Name = "btnRemoverProcedimento";
            btnRemoverProcedimento.Size = new Size(29, 25);
            btnRemoverProcedimento.TabIndex = 51;
            btnRemoverProcedimento.UseVisualStyleBackColor = true;
            btnRemoverProcedimento.Click += btnRemoverProcedimento_Click;
            // 
            // BtnAdicionarProcedimento
            // 
            BtnAdicionarProcedimento.Image = Properties.Resources.btnAdicionar;
            BtnAdicionarProcedimento.Location = new Point(204, 226);
            BtnAdicionarProcedimento.Name = "BtnAdicionarProcedimento";
            BtnAdicionarProcedimento.Size = new Size(29, 25);
            BtnAdicionarProcedimento.TabIndex = 50;
            BtnAdicionarProcedimento.UseVisualStyleBackColor = true;
            BtnAdicionarProcedimento.Click += BtnAdicionarProcedimento_Click;
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Image = Properties.Resources.btnSalvar1;
            BtnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCadastrar.Location = new Point(338, 356);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(73, 41);
            BtnCadastrar.TabIndex = 52;
            BtnCadastrar.Text = "Salvar";
            BtnCadastrar.TextAlign = ContentAlignment.MiddleRight;
            BtnCadastrar.UseVisualStyleBackColor = true;
            // 
            // TTObservacao
            // 
            TTObservacao.IsBalloon = true;
            TTObservacao.ToolTipIcon = ToolTipIcon.Info;
            TTObservacao.ToolTipTitle = "Observações do pet";
            // 
            // frmCadastroOrdemDeServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(748, 404);
            Controls.Add(BtnCadastrar);
            Controls.Add(btnRemoverProcedimento);
            Controls.Add(BtnAdicionarProcedimento);
            Controls.Add(TxtAdicionarProcedimento);
            Controls.Add(LbProcedimentos);
            Controls.Add(LblDescricaoInsumo);
            Controls.Add(LblIdInsumo);
            Controls.Add(textBox2);
            Controls.Add(btnPesquisaInsumo);
            Controls.Add(textBox1);
            Controls.Add(btnRemoverInsumo);
            Controls.Add(BtnAdicionarInsumo);
            Controls.Add(dataGridView1);
            Controls.Add(LblValor);
            Controls.Add(MTxtValor);
            Controls.Add(LblProcedimentos);
            Controls.Add(GbInformacoesDoPet);
            Controls.Add(LbListaDePets);
            Controls.Add(LblData);
            Controls.Add(DtData);
            Controls.Add(LblListaDePets);
            Controls.Add(BtnBuscarCliente);
            Controls.Add(TxtIdCliente);
            Controls.Add(LblIdCliente);
            Controls.Add(TxtNomeDoCliente);
            Controls.Add(LblNomeCliente);
            Controls.Add(TxtCodigoPedido);
            Controls.Add(LblPedido);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(809, 541);
            Name = "frmCadastroOrdemDeServico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ordem de Serviço";
            Load += frmCadastroOrdemDeServico_Load;
            GbInformacoesDoPet.ResumeLayout(false);
            PnlIdade.ResumeLayout(false);
            PnlIdade.PerformLayout();
            PnlAlergicoObservacao.ResumeLayout(false);
            PnlAlergicoObservacao.PerformLayout();
            PnlObservacoes.ResumeLayout(false);
            PnlObservacoes.PerformLayout();
            PnlPorteVacinado.ResumeLayout(false);
            PnlPorteVacinado.PerformLayout();
            PnlRacaPelo.ResumeLayout(false);
            PnlRacaPelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblPedido;
        private TextBox TxtCodigoPedido;
        private TextBox TxtNomeDoCliente;
        private Label LblIdCliente;
        private TextBox TxtIdCliente;
        private Button BtnBuscarCliente;
        private Label LblNomeCliente;
        private ListBox LbListaDePets;
        private Label LblListaDePets;
        private DateTimePicker DtData;
        private Label LblData;
        private GroupBox GbInformacoesDoPet;
        private Label LblPeloDado;
        private Label LblPelo;
        private Label LblRacaDado;
        private Label LblRaca;
        private Panel PnlPorteVacinado;
        private Label LblPorte;
        private Label LblVacinadoDado;
        private Panel PnlRacaPelo;
        private Panel PnlAlergicoObservacao;
        private Label LblObservacoes;
        private Label LblAlergicoDado;
        private Label LblPorteDado;
        private Panel PnlIdade;
        private Label LblIdadeDado;
        private Label LblIdade;
        private Panel PnlObservacoes;
        private MaskedTextBox MTxtValor;
        private Label LblValor;
        private DataGridView dataGridView1;
        private Button BtnAdicionarInsumo;
        private Button btnRemoverInsumo;
        private TextBox textBox1;
        private Button btnPesquisaInsumo;
        private TextBox textBox2;
        private Label LblIdInsumo;
        private Label LblDescricaoInsumo;
        private Label LblProcedimentos;
        private ListBox LbProcedimentos;
        private TextBox TxtAdicionarProcedimento;
        private Button btnRemoverProcedimento;
        private Button BtnAdicionarProcedimento;
        private Button BtnCadastrar;
        private ToolTip TTObservacao;
    }
}