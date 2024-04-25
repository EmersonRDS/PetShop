namespace PetShop.src.Forms
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
            LblOrdemDeServico = new Label();
            TxtCodigoOrdem = new TextBox();
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
            pictureBox1 = new PictureBox();
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
            TxtDescricaoInsumo = new TextBox();
            btnPesquisaInsumo = new Button();
            TxtCodInsumo = new TextBox();
            LblIdInsumo = new Label();
            LblDescricaoInsumo = new Label();
            LblProcedimentos = new Label();
            LbProcedimentos = new ListBox();
            TxtAdicionarProcedimento = new TextBox();
            btnRemoverProcedimento = new Button();
            BtnAdicionarProcedimento = new Button();
            BtnSalvar = new Button();
            TTObservacao = new ToolTip(components);
            BtnAlterar = new Button();
            BtnCancelar = new Button();
            BtnFinalizar = new Button();
            GbInformacoesDoPet.SuspendLayout();
            PnlIdade.SuspendLayout();
            PnlAlergicoObservacao.SuspendLayout();
            PnlObservacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PnlPorteVacinado.SuspendLayout();
            PnlRacaPelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LblOrdemDeServico
            // 
            LblOrdemDeServico.AutoSize = true;
            LblOrdemDeServico.Location = new Point(12, 9);
            LblOrdemDeServico.Name = "LblOrdemDeServico";
            LblOrdemDeServico.Size = new Size(101, 15);
            LblOrdemDeServico.TabIndex = 0;
            LblOrdemDeServico.Text = "Ordem de Serviço";
            // 
            // TxtCodigoOrdem
            // 
            TxtCodigoOrdem.Location = new Point(12, 26);
            TxtCodigoOrdem.Name = "TxtCodigoOrdem";
            TxtCodigoOrdem.ReadOnly = true;
            TxtCodigoOrdem.Size = new Size(100, 23);
            TxtCodigoOrdem.TabIndex = 1;
            // 
            // TxtNomeDoCliente
            // 
            TxtNomeDoCliente.Location = new Point(416, 26);
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
            LblIdCliente.Size = new Size(77, 15);
            LblIdCliente.TabIndex = 4;
            LblIdCliente.Text = "Cod. Cliente*";
            // 
            // TxtIdCliente
            // 
            TxtIdCliente.Location = new Point(295, 26);
            TxtIdCliente.Name = "TxtIdCliente";
            TxtIdCliente.Size = new Size(72, 23);
            TxtIdCliente.TabIndex = 5;
            TxtIdCliente.TextChanged += TxtIdCliente_TextChanged;
            TxtIdCliente.KeyPress += TxtIdCliente_KeyPress;
            // 
            // BtnBuscarCliente
            // 
            BtnBuscarCliente.Image = Properties.Resources.BuscarCliente;
            BtnBuscarCliente.Location = new Point(373, 26);
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
            LblListaDePets.Size = new Size(89, 15);
            LblListaDePets.TabIndex = 30;
            LblListaDePets.Text = "Pets do cliente*";
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
            LblData.Size = new Size(109, 15);
            LblData.TabIndex = 34;
            LblData.Text = "Horário do Pedido*";
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
            PnlObservacoes.Controls.Add(pictureBox1);
            PnlObservacoes.Controls.Add(LblObservacoes);
            PnlObservacoes.Location = new Point(3, 22);
            PnlObservacoes.Name = "PnlObservacoes";
            PnlObservacoes.Size = new Size(98, 35);
            PnlObservacoes.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.btnInformacao1;
            pictureBox1.Location = new Point(69, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 16);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // LblObservacoes
            // 
            LblObservacoes.AutoSize = true;
            LblObservacoes.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            LblObservacoes.ForeColor = SystemColors.InfoText;
            LblObservacoes.Location = new Point(-3, 9);
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
            MTxtValor.Location = new Point(641, 26);
            MTxtValor.Mask = "$ ###,00";
            MTxtValor.Name = "MTxtValor";
            MTxtValor.PromptChar = ' ';
            MTxtValor.Size = new Size(100, 23);
            MTxtValor.TabIndex = 38;
            MTxtValor.Text = "00000";
            MTxtValor.KeyPress += MTxtValor_KeyPress;
            MTxtValor.Leave += MTxtValor_Leave;
            // 
            // LblValor
            // 
            LblValor.AutoSize = true;
            LblValor.Location = new Point(641, 11);
            LblValor.Name = "LblValor";
            LblValor.Size = new Size(38, 15);
            LblValor.TabIndex = 39;
            LblValor.Text = "Valor*";
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
            // TxtDescricaoInsumo
            // 
            TxtDescricaoInsumo.Location = new Point(368, 198);
            TxtDescricaoInsumo.Name = "TxtDescricaoInsumo";
            TxtDescricaoInsumo.ReadOnly = true;
            TxtDescricaoInsumo.Size = new Size(338, 23);
            TxtDescricaoInsumo.TabIndex = 43;
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
            // TxtCodInsumo
            // 
            TxtCodInsumo.Location = new Point(248, 197);
            TxtCodInsumo.Name = "TxtCodInsumo";
            TxtCodInsumo.Size = new Size(78, 23);
            TxtCodInsumo.TabIndex = 45;
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
            LblProcedimentos.Size = new Size(92, 15);
            LblProcedimentos.TabIndex = 37;
            LblProcedimentos.Text = "Procedimentos*";
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
            // BtnSalvar
            // 
            BtnSalvar.Image = Properties.Resources.btnSalvar1;
            BtnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalvar.Location = new Point(283, 356);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(73, 41);
            BtnSalvar.TabIndex = 52;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.TextAlign = ContentAlignment.MiddleRight;
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // TTObservacao
            // 
            TTObservacao.IsBalloon = true;
            TTObservacao.ToolTipIcon = ToolTipIcon.Info;
            TTObservacao.ToolTipTitle = "Observações do pet";
            // 
            // BtnAlterar
            // 
            BtnAlterar.Enabled = false;
            BtnAlterar.Image = Properties.Resources.BtnAlterar2;
            BtnAlterar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAlterar.Location = new Point(200, 356);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(73, 41);
            BtnAlterar.TabIndex = 53;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.TextAlign = ContentAlignment.MiddleRight;
            BtnAlterar.UseVisualStyleBackColor = true;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Enabled = false;
            BtnCancelar.Image = Properties.Resources.BtnCancelar;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(366, 356);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(87, 41);
            BtnCancelar.TabIndex = 54;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.Enabled = false;
            BtnFinalizar.Image = Properties.Resources.BtnConfirmar1;
            BtnFinalizar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFinalizar.Location = new Point(463, 356);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(86, 41);
            BtnFinalizar.TabIndex = 55;
            BtnFinalizar.Text = "Finalizar";
            BtnFinalizar.TextAlign = ContentAlignment.MiddleRight;
            BtnFinalizar.UseVisualStyleBackColor = true;
            BtnFinalizar.Click += BtnFinalizar_Click;
            // 
            // frmCadastroOrdemDeServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(748, 404);
            Controls.Add(BtnFinalizar);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnSalvar);
            Controls.Add(btnRemoverProcedimento);
            Controls.Add(BtnAdicionarProcedimento);
            Controls.Add(TxtAdicionarProcedimento);
            Controls.Add(LbProcedimentos);
            Controls.Add(LblDescricaoInsumo);
            Controls.Add(LblIdInsumo);
            Controls.Add(TxtCodInsumo);
            Controls.Add(btnPesquisaInsumo);
            Controls.Add(TxtDescricaoInsumo);
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
            Controls.Add(TxtCodigoOrdem);
            Controls.Add(LblOrdemDeServico);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PnlPorteVacinado.ResumeLayout(false);
            PnlPorteVacinado.PerformLayout();
            PnlRacaPelo.ResumeLayout(false);
            PnlRacaPelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblOrdemDeServico;
        private TextBox TxtCodigoOrdem;
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
        private TextBox TxtDescricaoInsumo;
        private Button btnPesquisaInsumo;
        private TextBox TxtCodInsumo;
        private Label LblIdInsumo;
        private Label LblDescricaoInsumo;
        private Label LblProcedimentos;
        private ListBox LbProcedimentos;
        private TextBox TxtAdicionarProcedimento;
        private Button btnRemoverProcedimento;
        private Button BtnAdicionarProcedimento;
        private Button BtnSalvar;
        private ToolTip TTObservacao;
        private Button BtnAlterar;
        private Button BtnCancelar;
        private Button BtnFinalizar;
        private PictureBox pictureBox1;
    }
}