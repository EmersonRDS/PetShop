namespace PetShop.src.Forms
{
    partial class frmInformacaoDoCliente
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
            GbInformacaoDoPet = new GroupBox();
            LblObservacoes = new Label();
            TxtObservacoesPet = new TextBox();
            TxtIdade = new TextBox();
            LblIdade = new Label();
            TxtTipoDePelagem = new TextBox();
            LblTipoDePelagem = new Label();
            LblAlergico = new Label();
            LblAlergiaTexto = new Label();
            LblPorte = new Label();
            LblPorteTexto = new Label();
            LblVacinado = new Label();
            LblVacinadoTexto = new Label();
            TxtRaca = new TextBox();
            LblRaca = new Label();
            TxtNomePet = new TextBox();
            LblNomeDoPet = new Label();
            GbCliente = new GroupBox();
            label1 = new Label();
            txtObservacoesCliente = new TextBox();
            LblListaDePets = new Label();
            BtnBuscar = new Button();
            LbListaDePets = new ListBox();
            TxtEndereco = new TextBox();
            LblEndereco = new Label();
            TxtBairro = new TextBox();
            LblBairro = new Label();
            TxtCidade = new TextBox();
            LblCidade = new Label();
            TxtTelefone = new TextBox();
            LblTelefone = new Label();
            TxtNomeDoCliente = new TextBox();
            LblNome = new Label();
            TxtIdCliente = new TextBox();
            LblIdCliente = new Label();
            BtnAlterarCliente = new Button();
            BtnAlterarPet = new Button();
            BtnNovoPedido = new Button();
            GbInformacaoDoPet.SuspendLayout();
            GbCliente.SuspendLayout();
            SuspendLayout();
            // 
            // GbInformacaoDoPet
            // 
            GbInformacaoDoPet.BackColor = SystemColors.ActiveCaption;
            GbInformacaoDoPet.Controls.Add(LblObservacoes);
            GbInformacaoDoPet.Controls.Add(TxtObservacoesPet);
            GbInformacaoDoPet.Controls.Add(TxtIdade);
            GbInformacaoDoPet.Controls.Add(LblIdade);
            GbInformacaoDoPet.Controls.Add(TxtTipoDePelagem);
            GbInformacaoDoPet.Controls.Add(LblTipoDePelagem);
            GbInformacaoDoPet.Controls.Add(LblAlergico);
            GbInformacaoDoPet.Controls.Add(LblAlergiaTexto);
            GbInformacaoDoPet.Controls.Add(LblPorte);
            GbInformacaoDoPet.Controls.Add(LblPorteTexto);
            GbInformacaoDoPet.Controls.Add(LblVacinado);
            GbInformacaoDoPet.Controls.Add(LblVacinadoTexto);
            GbInformacaoDoPet.Controls.Add(TxtRaca);
            GbInformacaoDoPet.Controls.Add(LblRaca);
            GbInformacaoDoPet.Controls.Add(TxtNomePet);
            GbInformacaoDoPet.Controls.Add(LblNomeDoPet);
            GbInformacaoDoPet.ForeColor = SystemColors.ControlText;
            GbInformacaoDoPet.Location = new Point(344, 12);
            GbInformacaoDoPet.Name = "GbInformacaoDoPet";
            GbInformacaoDoPet.Size = new Size(294, 380);
            GbInformacaoDoPet.TabIndex = 13;
            GbInformacaoDoPet.TabStop = false;
            GbInformacaoDoPet.Text = "Informações do Pet";
            GbInformacaoDoPet.Visible = false;
            // 
            // LblObservacoes
            // 
            LblObservacoes.AutoSize = true;
            LblObservacoes.Location = new Point(6, 286);
            LblObservacoes.Name = "LblObservacoes";
            LblObservacoes.Size = new Size(74, 15);
            LblObservacoes.TabIndex = 22;
            LblObservacoes.Text = "Observações";
            // 
            // TxtObservacoesPet
            // 
            TxtObservacoesPet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TxtObservacoesPet.Location = new Point(6, 313);
            TxtObservacoesPet.MaxLength = 300;
            TxtObservacoesPet.Multiline = true;
            TxtObservacoesPet.Name = "TxtObservacoesPet";
            TxtObservacoesPet.ReadOnly = true;
            TxtObservacoesPet.Size = new Size(282, 57);
            TxtObservacoesPet.TabIndex = 21;
            // 
            // TxtIdade
            // 
            TxtIdade.Location = new Point(166, 46);
            TxtIdade.Name = "TxtIdade";
            TxtIdade.ReadOnly = true;
            TxtIdade.Size = new Size(38, 23);
            TxtIdade.TabIndex = 13;
            // 
            // LblIdade
            // 
            LblIdade.AutoSize = true;
            LblIdade.Location = new Point(166, 22);
            LblIdade.Name = "LblIdade";
            LblIdade.Size = new Size(36, 15);
            LblIdade.TabIndex = 12;
            LblIdade.Text = "Idade";
            // 
            // TxtTipoDePelagem
            // 
            TxtTipoDePelagem.Location = new Point(6, 170);
            TxtTipoDePelagem.Name = "TxtTipoDePelagem";
            TxtTipoDePelagem.ReadOnly = true;
            TxtTipoDePelagem.Size = new Size(154, 23);
            TxtTipoDePelagem.TabIndex = 11;
            // 
            // LblTipoDePelagem
            // 
            LblTipoDePelagem.AutoSize = true;
            LblTipoDePelagem.Location = new Point(6, 143);
            LblTipoDePelagem.Name = "LblTipoDePelagem";
            LblTipoDePelagem.Size = new Size(95, 15);
            LblTipoDePelagem.TabIndex = 10;
            LblTipoDePelagem.Text = "Tipo de Pelagem";
            // 
            // LblAlergico
            // 
            LblAlergico.AutoSize = true;
            LblAlergico.Location = new Point(67, 259);
            LblAlergico.Name = "LblAlergico";
            LblAlergico.Size = new Size(29, 15);
            LblAlergico.TabIndex = 9;
            LblAlergico.Text = "Não";
            // 
            // LblAlergiaTexto
            // 
            LblAlergiaTexto.AutoSize = true;
            LblAlergiaTexto.Location = new Point(7, 259);
            LblAlergiaTexto.Name = "LblAlergiaTexto";
            LblAlergiaTexto.Size = new Size(54, 15);
            LblAlergiaTexto.TabIndex = 8;
            LblAlergiaTexto.Text = "Alérgico:";
            // 
            // LblPorte
            // 
            LblPorte.AutoSize = true;
            LblPorte.Location = new Point(46, 232);
            LblPorte.Name = "LblPorte";
            LblPorte.Size = new Size(15, 15);
            LblPorte.TabIndex = 7;
            LblPorte.Text = "G";
            // 
            // LblPorteTexto
            // 
            LblPorteTexto.AutoSize = true;
            LblPorteTexto.Location = new Point(6, 232);
            LblPorteTexto.Name = "LblPorteTexto";
            LblPorteTexto.Size = new Size(38, 15);
            LblPorteTexto.TabIndex = 6;
            LblPorteTexto.Text = "Porte:";
            // 
            // LblVacinado
            // 
            LblVacinado.AutoSize = true;
            LblVacinado.Location = new Point(67, 205);
            LblVacinado.Name = "LblVacinado";
            LblVacinado.Size = new Size(27, 15);
            LblVacinado.TabIndex = 5;
            LblVacinado.Text = "Sim";
            // 
            // LblVacinadoTexto
            // 
            LblVacinadoTexto.AutoSize = true;
            LblVacinadoTexto.Location = new Point(6, 205);
            LblVacinadoTexto.Name = "LblVacinadoTexto";
            LblVacinadoTexto.Size = new Size(58, 15);
            LblVacinadoTexto.TabIndex = 4;
            LblVacinadoTexto.Text = "Vacinado:";
            // 
            // TxtRaca
            // 
            TxtRaca.Location = new Point(6, 108);
            TxtRaca.Name = "TxtRaca";
            TxtRaca.ReadOnly = true;
            TxtRaca.Size = new Size(154, 23);
            TxtRaca.TabIndex = 3;
            // 
            // LblRaca
            // 
            LblRaca.AutoSize = true;
            LblRaca.Location = new Point(6, 81);
            LblRaca.Name = "LblRaca";
            LblRaca.Size = new Size(32, 15);
            LblRaca.TabIndex = 2;
            LblRaca.Text = "Raça";
            // 
            // TxtNomePet
            // 
            TxtNomePet.Location = new Point(6, 46);
            TxtNomePet.Name = "TxtNomePet";
            TxtNomePet.ReadOnly = true;
            TxtNomePet.Size = new Size(154, 23);
            TxtNomePet.TabIndex = 1;
            // 
            // LblNomeDoPet
            // 
            LblNomeDoPet.AutoSize = true;
            LblNomeDoPet.Location = new Point(6, 19);
            LblNomeDoPet.Name = "LblNomeDoPet";
            LblNomeDoPet.Size = new Size(77, 15);
            LblNomeDoPet.TabIndex = 0;
            LblNomeDoPet.Text = "Nome do Pet";
            // 
            // GbCliente
            // 
            GbCliente.Controls.Add(label1);
            GbCliente.Controls.Add(txtObservacoesCliente);
            GbCliente.Controls.Add(LblListaDePets);
            GbCliente.Controls.Add(BtnBuscar);
            GbCliente.Controls.Add(LbListaDePets);
            GbCliente.Controls.Add(TxtEndereco);
            GbCliente.Controls.Add(LblEndereco);
            GbCliente.Controls.Add(TxtBairro);
            GbCliente.Controls.Add(LblBairro);
            GbCliente.Controls.Add(TxtCidade);
            GbCliente.Controls.Add(LblCidade);
            GbCliente.Controls.Add(TxtTelefone);
            GbCliente.Controls.Add(LblTelefone);
            GbCliente.Controls.Add(TxtNomeDoCliente);
            GbCliente.Controls.Add(LblNome);
            GbCliente.Controls.Add(TxtIdCliente);
            GbCliente.Controls.Add(LblIdCliente);
            GbCliente.Location = new Point(5, 12);
            GbCliente.Name = "GbCliente";
            GbCliente.Size = new Size(333, 380);
            GbCliente.TabIndex = 14;
            GbCliente.TabStop = false;
            GbCliente.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 295);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 32;
            label1.Text = "Observações";
            // 
            // txtObservacoesCliente
            // 
            txtObservacoesCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtObservacoesCliente.Location = new Point(7, 316);
            txtObservacoesCliente.MaxLength = 300;
            txtObservacoesCliente.Multiline = true;
            txtObservacoesCliente.Name = "txtObservacoesCliente";
            txtObservacoesCliente.ReadOnly = true;
            txtObservacoesCliente.Size = new Size(304, 57);
            txtObservacoesCliente.TabIndex = 31;
            // 
            // LblListaDePets
            // 
            LblListaDePets.AutoSize = true;
            LblListaDePets.Location = new Point(6, 219);
            LblListaDePets.Name = "LblListaDePets";
            LblListaDePets.Size = new Size(29, 15);
            LblListaDePets.TabIndex = 30;
            LblListaDePets.Text = "Pets";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(257, 40);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(54, 23);
            BtnBuscar.TabIndex = 29;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // LbListaDePets
            // 
            LbListaDePets.FormattingEnabled = true;
            LbListaDePets.ItemHeight = 15;
            LbListaDePets.Location = new Point(6, 240);
            LbListaDePets.Name = "LbListaDePets";
            LbListaDePets.Size = new Size(305, 49);
            LbListaDePets.TabIndex = 28;
            LbListaDePets.Click += LbListaDePets_Click;
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(6, 190);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.ReadOnly = true;
            TxtEndereco.Size = new Size(305, 23);
            TxtEndereco.TabIndex = 27;
            // 
            // LblEndereco
            // 
            LblEndereco.AutoSize = true;
            LblEndereco.Location = new Point(6, 169);
            LblEndereco.Name = "LblEndereco";
            LblEndereco.Size = new Size(56, 15);
            LblEndereco.TabIndex = 26;
            LblEndereco.Text = "Endereço";
            // 
            // TxtBairro
            // 
            TxtBairro.Location = new Point(166, 140);
            TxtBairro.Name = "TxtBairro";
            TxtBairro.ReadOnly = true;
            TxtBairro.Size = new Size(145, 23);
            TxtBairro.TabIndex = 25;
            // 
            // LblBairro
            // 
            LblBairro.AutoSize = true;
            LblBairro.Location = new Point(166, 119);
            LblBairro.Name = "LblBairro";
            LblBairro.Size = new Size(38, 15);
            LblBairro.TabIndex = 24;
            LblBairro.Text = "Bairro";
            // 
            // TxtCidade
            // 
            TxtCidade.Location = new Point(6, 140);
            TxtCidade.Name = "TxtCidade";
            TxtCidade.ReadOnly = true;
            TxtCidade.Size = new Size(145, 23);
            TxtCidade.TabIndex = 23;
            // 
            // LblCidade
            // 
            LblCidade.AutoSize = true;
            LblCidade.Location = new Point(6, 119);
            LblCidade.Name = "LblCidade";
            LblCidade.Size = new Size(44, 15);
            LblCidade.TabIndex = 22;
            LblCidade.Text = "Cidade";
            // 
            // TxtTelefone
            // 
            TxtTelefone.Location = new Point(6, 90);
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.ReadOnly = true;
            TxtTelefone.Size = new Size(145, 23);
            TxtTelefone.TabIndex = 21;
            // 
            // LblTelefone
            // 
            LblTelefone.AutoSize = true;
            LblTelefone.Location = new Point(6, 69);
            LblTelefone.Name = "LblTelefone";
            LblTelefone.Size = new Size(51, 15);
            LblTelefone.TabIndex = 20;
            LblTelefone.Text = "Telefone";
            // 
            // TxtNomeDoCliente
            // 
            TxtNomeDoCliente.Location = new Point(66, 40);
            TxtNomeDoCliente.Name = "TxtNomeDoCliente";
            TxtNomeDoCliente.ReadOnly = true;
            TxtNomeDoCliente.Size = new Size(185, 23);
            TxtNomeDoCliente.TabIndex = 19;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(66, 19);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(97, 15);
            LblNome.TabIndex = 18;
            LblNome.Text = "Nome do Cliente";
            // 
            // TxtIdCliente
            // 
            TxtIdCliente.Location = new Point(6, 40);
            TxtIdCliente.Name = "TxtIdCliente";
            TxtIdCliente.Size = new Size(54, 23);
            TxtIdCliente.TabIndex = 17;
            // 
            // LblIdCliente
            // 
            LblIdCliente.AutoSize = true;
            LblIdCliente.Location = new Point(6, 19);
            LblIdCliente.Name = "LblIdCliente";
            LblIdCliente.Size = new Size(17, 15);
            LblIdCliente.TabIndex = 16;
            LblIdCliente.Text = "Id";
            // 
            // BtnAlterarCliente
            // 
            BtnAlterarCliente.Location = new Point(24, 398);
            BtnAlterarCliente.Name = "BtnAlterarCliente";
            BtnAlterarCliente.Size = new Size(74, 44);
            BtnAlterarCliente.TabIndex = 15;
            BtnAlterarCliente.Text = "Alterar Cliente";
            BtnAlterarCliente.UseVisualStyleBackColor = true;
            BtnAlterarCliente.MouseClick += BtnAlterarCliente_MouseClick;
            // 
            // BtnAlterarPet
            // 
            BtnAlterarPet.Location = new Point(135, 398);
            BtnAlterarPet.Name = "BtnAlterarPet";
            BtnAlterarPet.Size = new Size(74, 44);
            BtnAlterarPet.TabIndex = 16;
            BtnAlterarPet.Text = "Alterar Pet";
            BtnAlterarPet.UseVisualStyleBackColor = true;
            BtnAlterarPet.Click += BtnAlterarPet_Click;
            // 
            // BtnNovoPedido
            // 
            BtnNovoPedido.Location = new Point(242, 398);
            BtnNovoPedido.Name = "BtnNovoPedido";
            BtnNovoPedido.Size = new Size(74, 44);
            BtnNovoPedido.TabIndex = 17;
            BtnNovoPedido.Text = "Novo Pedido";
            BtnNovoPedido.UseVisualStyleBackColor = true;
            // 
            // frmInformacaoDoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(341, 454);
            Controls.Add(BtnNovoPedido);
            Controls.Add(BtnAlterarPet);
            Controls.Add(BtnAlterarCliente);
            Controls.Add(GbCliente);
            Controls.Add(GbInformacaoDoPet);
            Name = "frmInformacaoDoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informações do Cliente";
            Load += frmInformacaoDoCliente_Load;
            GbInformacaoDoPet.ResumeLayout(false);
            GbInformacaoDoPet.PerformLayout();
            GbCliente.ResumeLayout(false);
            GbCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox GbInformacaoDoPet;
        private Label LblNomeDoPet;
        private TextBox TxtNomePet;
        private TextBox TxtRaca;
        private Label LblRaca;
        private Label LblVacinadoTexto;
        private Label LblPorte;
        private Label LblPorteTexto;
        private Label LblVacinado;
        private Label LblAlergico;
        private Label LblAlergiaTexto;
        private TextBox TxtIdade;
        private Label LblIdade;
        private TextBox TxtTipoDePelagem;
        private Label LblTipoDePelagem;
        private Label LblObservacoes;
        private TextBox TxtObservacoesPet;
        private GroupBox GbCliente;
        private Button BtnBuscar;
        private ListBox LbListaDePets;
        private TextBox TxtEndereco;
        private Label LblEndereco;
        private TextBox TxtBairro;
        private Label LblBairro;
        private TextBox TxtCidade;
        private Label LblCidade;
        private TextBox TxtTelefone;
        private Label LblTelefone;
        private TextBox TxtNomeDoCliente;
        private Label LblNome;
        private TextBox TxtIdCliente;
        private Label LblIdCliente;
        private Label LblListaDePets;
        private Label label1;
        private TextBox txtObservacoesCliente;
        private Button BtnAlterarCliente;
        private Button BtnAlterarPet;
        private Button BtnNovoPedido;
    }
}