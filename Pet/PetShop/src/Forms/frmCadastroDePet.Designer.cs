namespace PetShop.src.Forms
{
    partial class frmCadastroDePet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroDePet));
            LblNomeDoPet = new Label();
            txtNomePet = new TextBox();
            LblRaca = new Label();
            txtRaca = new TextBox();
            txtTipoDePelagem = new TextBox();
            LblTipoDePelagem = new Label();
            RdbPorteG = new RadioButton();
            RdbPorteM = new RadioButton();
            RdbPorteP = new RadioButton();
            GbPorte = new GroupBox();
            PnlPorte = new Panel();
            GbVacinado = new GroupBox();
            PnlVacinado = new Panel();
            RdbVacinadoNao = new RadioButton();
            RdbVacinadoSim = new RadioButton();
            GbAlergico = new GroupBox();
            PnlAlergico = new Panel();
            RdbAlergicoNao = new RadioButton();
            RdbAlergicoSim = new RadioButton();
            DtDataNascimento = new DateTimePicker();
            LblDataNascimento = new Label();
            txtNomeTutor = new TextBox();
            LblNomeTutor = new Label();
            BtnBuscarCliente = new Button();
            txtIdTutor = new TextBox();
            TxtObservacoes = new TextBox();
            LblObservacoes = new Label();
            BtnCadastrar = new Button();
            LblAlteraPet = new Label();
            panel1 = new Panel();
            GbPorte.SuspendLayout();
            PnlPorte.SuspendLayout();
            GbVacinado.SuspendLayout();
            PnlVacinado.SuspendLayout();
            GbAlergico.SuspendLayout();
            PnlAlergico.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LblNomeDoPet
            // 
            LblNomeDoPet.AutoSize = true;
            LblNomeDoPet.Location = new Point(12, 25);
            LblNomeDoPet.Name = "LblNomeDoPet";
            LblNomeDoPet.Size = new Size(82, 15);
            LblNomeDoPet.TabIndex = 0;
            LblNomeDoPet.Text = "Nome do Pet*";
            // 
            // txtNomePet
            // 
            txtNomePet.Location = new Point(12, 43);
            txtNomePet.Name = "txtNomePet";
            txtNomePet.PlaceholderText = "Digite o nome do Pet";
            txtNomePet.Size = new Size(222, 23);
            txtNomePet.TabIndex = 1;
            txtNomePet.DoubleClick += txtNomePet_DoubleClick;
            // 
            // LblRaca
            // 
            LblRaca.AutoSize = true;
            LblRaca.Location = new Point(12, 84);
            LblRaca.Name = "LblRaca";
            LblRaca.Size = new Size(37, 15);
            LblRaca.TabIndex = 0;
            LblRaca.Text = "Raça*";
            // 
            // txtRaca
            // 
            txtRaca.Location = new Point(12, 102);
            txtRaca.Name = "txtRaca";
            txtRaca.PlaceholderText = "Digite a raça do Pet";
            txtRaca.Size = new Size(222, 23);
            txtRaca.TabIndex = 2;
            txtRaca.DoubleClick += txtRaca_DoubleClick;
            // 
            // txtTipoDePelagem
            // 
            txtTipoDePelagem.Location = new Point(12, 159);
            txtTipoDePelagem.Name = "txtTipoDePelagem";
            txtTipoDePelagem.PlaceholderText = "Digite o tipo de pelagem";
            txtTipoDePelagem.Size = new Size(222, 23);
            txtTipoDePelagem.TabIndex = 3;
            txtTipoDePelagem.DoubleClick += txtTipoDePelagem_DoubleClick;
            // 
            // LblTipoDePelagem
            // 
            LblTipoDePelagem.AutoSize = true;
            LblTipoDePelagem.Location = new Point(12, 141);
            LblTipoDePelagem.Name = "LblTipoDePelagem";
            LblTipoDePelagem.Size = new Size(100, 15);
            LblTipoDePelagem.TabIndex = 0;
            LblTipoDePelagem.Text = "Tipo de Pelagem*";
            // 
            // RdbPorteG
            // 
            RdbPorteG.AutoSize = true;
            RdbPorteG.Location = new Point(22, 3);
            RdbPorteG.Name = "RdbPorteG";
            RdbPorteG.Size = new Size(33, 19);
            RdbPorteG.TabIndex = 4;
            RdbPorteG.TabStop = true;
            RdbPorteG.Text = "G";
            RdbPorteG.UseVisualStyleBackColor = true;
            // 
            // RdbPorteM
            // 
            RdbPorteM.AutoSize = true;
            RdbPorteM.Location = new Point(61, 3);
            RdbPorteM.Name = "RdbPorteM";
            RdbPorteM.Size = new Size(36, 19);
            RdbPorteM.TabIndex = 5;
            RdbPorteM.TabStop = true;
            RdbPorteM.Text = "M";
            RdbPorteM.UseVisualStyleBackColor = true;
            // 
            // RdbPorteP
            // 
            RdbPorteP.AutoSize = true;
            RdbPorteP.Location = new Point(100, 3);
            RdbPorteP.Name = "RdbPorteP";
            RdbPorteP.Size = new Size(32, 19);
            RdbPorteP.TabIndex = 6;
            RdbPorteP.TabStop = true;
            RdbPorteP.Text = "P";
            RdbPorteP.UseVisualStyleBackColor = true;
            // 
            // GbPorte
            // 
            GbPorte.Controls.Add(PnlPorte);
            GbPorte.Location = new Point(12, 197);
            GbPorte.Name = "GbPorte";
            GbPorte.Size = new Size(169, 64);
            GbPorte.TabIndex = 11;
            GbPorte.TabStop = false;
            GbPorte.Text = "Porte*";
            // 
            // PnlPorte
            // 
            PnlPorte.Controls.Add(RdbPorteM);
            PnlPorte.Controls.Add(RdbPorteP);
            PnlPorte.Controls.Add(RdbPorteG);
            PnlPorte.Dock = DockStyle.Fill;
            PnlPorte.Location = new Point(3, 19);
            PnlPorte.Name = "PnlPorte";
            PnlPorte.Size = new Size(163, 42);
            PnlPorte.TabIndex = 0;
            PnlPorte.DoubleClick += PnlPorte_DoubleClick;
            // 
            // GbVacinado
            // 
            GbVacinado.Controls.Add(PnlVacinado);
            GbVacinado.Location = new Point(12, 282);
            GbVacinado.Name = "GbVacinado";
            GbVacinado.Size = new Size(169, 64);
            GbVacinado.TabIndex = 12;
            GbVacinado.TabStop = false;
            GbVacinado.Text = "Vacinado*";
            // 
            // PnlVacinado
            // 
            PnlVacinado.Controls.Add(RdbVacinadoNao);
            PnlVacinado.Controls.Add(RdbVacinadoSim);
            PnlVacinado.Dock = DockStyle.Fill;
            PnlVacinado.Location = new Point(3, 19);
            PnlVacinado.Name = "PnlVacinado";
            PnlVacinado.Size = new Size(163, 42);
            PnlVacinado.TabIndex = 0;
            PnlVacinado.DoubleClick += PnlVacinado_DoubleClick;
            // 
            // RdbVacinadoNao
            // 
            RdbVacinadoNao.AutoSize = true;
            RdbVacinadoNao.Location = new Point(100, 3);
            RdbVacinadoNao.Name = "RdbVacinadoNao";
            RdbVacinadoNao.Size = new Size(47, 19);
            RdbVacinadoNao.TabIndex = 8;
            RdbVacinadoNao.TabStop = true;
            RdbVacinadoNao.Text = "Nao";
            RdbVacinadoNao.UseVisualStyleBackColor = true;
            // 
            // RdbVacinadoSim
            // 
            RdbVacinadoSim.AutoSize = true;
            RdbVacinadoSim.Location = new Point(22, 3);
            RdbVacinadoSim.Name = "RdbVacinadoSim";
            RdbVacinadoSim.Size = new Size(45, 19);
            RdbVacinadoSim.TabIndex = 7;
            RdbVacinadoSim.TabStop = true;
            RdbVacinadoSim.Text = "Sim";
            RdbVacinadoSim.UseVisualStyleBackColor = true;
            // 
            // GbAlergico
            // 
            GbAlergico.Controls.Add(PnlAlergico);
            GbAlergico.Location = new Point(12, 369);
            GbAlergico.Name = "GbAlergico";
            GbAlergico.Size = new Size(169, 64);
            GbAlergico.TabIndex = 13;
            GbAlergico.TabStop = false;
            GbAlergico.Text = "Alergico*";
            // 
            // PnlAlergico
            // 
            PnlAlergico.Controls.Add(RdbAlergicoNao);
            PnlAlergico.Controls.Add(RdbAlergicoSim);
            PnlAlergico.Dock = DockStyle.Fill;
            PnlAlergico.Location = new Point(3, 19);
            PnlAlergico.Name = "PnlAlergico";
            PnlAlergico.Size = new Size(163, 42);
            PnlAlergico.TabIndex = 0;
            PnlAlergico.DoubleClick += PnlAlergico_DoubleClick;
            // 
            // RdbAlergicoNao
            // 
            RdbAlergicoNao.AutoSize = true;
            RdbAlergicoNao.Location = new Point(100, 3);
            RdbAlergicoNao.Name = "RdbAlergicoNao";
            RdbAlergicoNao.Size = new Size(47, 19);
            RdbAlergicoNao.TabIndex = 9;
            RdbAlergicoNao.TabStop = true;
            RdbAlergicoNao.Text = "Nao";
            RdbAlergicoNao.UseVisualStyleBackColor = true;
            // 
            // RdbAlergicoSim
            // 
            RdbAlergicoSim.AutoSize = true;
            RdbAlergicoSim.Location = new Point(22, 3);
            RdbAlergicoSim.Name = "RdbAlergicoSim";
            RdbAlergicoSim.Size = new Size(45, 19);
            RdbAlergicoSim.TabIndex = 8;
            RdbAlergicoSim.TabStop = true;
            RdbAlergicoSim.Text = "Sim";
            RdbAlergicoSim.UseVisualStyleBackColor = true;
            // 
            // DtDataNascimento
            // 
            DtDataNascimento.Format = DateTimePickerFormat.Short;
            DtDataNascimento.Location = new Point(0, 3);
            DtDataNascimento.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            DtDataNascimento.Name = "DtDataNascimento";
            DtDataNascimento.Size = new Size(106, 23);
            DtDataNascimento.TabIndex = 14;
            // 
            // LblDataNascimento
            // 
            LblDataNascimento.AutoSize = true;
            LblDataNascimento.Location = new Point(334, 81);
            LblDataNascimento.Name = "LblDataNascimento";
            LblDataNascimento.Size = new Size(114, 15);
            LblDataNascimento.TabIndex = 15;
            LblDataNascimento.Text = "Data de Nascimento";
            // 
            // txtNomeTutor
            // 
            txtNomeTutor.Location = new Point(385, 43);
            txtNomeTutor.Name = "txtNomeTutor";
            txtNomeTutor.PlaceholderText = "Nome do Tutor";
            txtNomeTutor.ReadOnly = true;
            txtNomeTutor.Size = new Size(222, 23);
            txtNomeTutor.TabIndex = 17;
            // 
            // LblNomeTutor
            // 
            LblNomeTutor.AutoSize = true;
            LblNomeTutor.Location = new Point(334, 25);
            LblNomeTutor.Name = "LblNomeTutor";
            LblNomeTutor.Size = new Size(40, 15);
            LblNomeTutor.TabIndex = 16;
            LblNomeTutor.Text = "Tutor*";
            // 
            // BtnBuscarCliente
            // 
            BtnBuscarCliente.Image = Properties.Resources.BuscarCliente1;
            BtnBuscarCliente.Location = new Point(613, 42);
            BtnBuscarCliente.Name = "BtnBuscarCliente";
            BtnBuscarCliente.Size = new Size(35, 23);
            BtnBuscarCliente.TabIndex = 18;
            BtnBuscarCliente.UseVisualStyleBackColor = true;
            BtnBuscarCliente.Click += BtnBuscarCliente_Click;
            // 
            // txtIdTutor
            // 
            txtIdTutor.Location = new Point(334, 43);
            txtIdTutor.Name = "txtIdTutor";
            txtIdTutor.PlaceholderText = "Id";
            txtIdTutor.Size = new Size(45, 23);
            txtIdTutor.TabIndex = 19;
            txtIdTutor.TextChanged += txtIdTutor_TextChanged;
            txtIdTutor.DoubleClick += txtIdTutor_DoubleClick;
            txtIdTutor.KeyPress += txtIdTutor_KeyPress;
            txtIdTutor.Leave += txtIdTutor_Leave;
            // 
            // TxtObservacoes
            // 
            TxtObservacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TxtObservacoes.Location = new Point(334, 159);
            TxtObservacoes.MaxLength = 300;
            TxtObservacoes.Multiline = true;
            TxtObservacoes.Name = "TxtObservacoes";
            TxtObservacoes.PlaceholderText = "Digite as Observações";
            TxtObservacoes.Size = new Size(314, 66);
            TxtObservacoes.TabIndex = 20;
            TxtObservacoes.DoubleClick += TxtObservacoes_DoubleClick;
            // 
            // LblObservacoes
            // 
            LblObservacoes.AutoSize = true;
            LblObservacoes.Location = new Point(334, 141);
            LblObservacoes.Name = "LblObservacoes";
            LblObservacoes.Size = new Size(74, 15);
            LblObservacoes.TabIndex = 21;
            LblObservacoes.Text = "Observações";
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCadastrar.Location = new Point(574, 405);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(74, 28);
            BtnCadastrar.TabIndex = 22;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // LblAlteraPet
            // 
            LblAlteraPet.AutoSize = true;
            LblAlteraPet.ForeColor = Color.Red;
            LblAlteraPet.Location = new Point(12, 9);
            LblAlteraPet.Name = "LblAlteraPet";
            LblAlteraPet.Size = new Size(236, 15);
            LblAlteraPet.TabIndex = 23;
            LblAlteraPet.Text = "Dois cliques no campo para liberar a edição";
            LblAlteraPet.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(DtDataNascimento);
            panel1.Location = new Point(334, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 26);
            panel1.TabIndex = 24;
            panel1.DoubleClick += panel1_DoubleClick;
            // 
            // frmCadastroDePet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(669, 458);
            Controls.Add(panel1);
            Controls.Add(LblAlteraPet);
            Controls.Add(BtnCadastrar);
            Controls.Add(LblObservacoes);
            Controls.Add(TxtObservacoes);
            Controls.Add(txtIdTutor);
            Controls.Add(BtnBuscarCliente);
            Controls.Add(txtNomeTutor);
            Controls.Add(LblNomeTutor);
            Controls.Add(LblDataNascimento);
            Controls.Add(GbAlergico);
            Controls.Add(GbVacinado);
            Controls.Add(GbPorte);
            Controls.Add(txtTipoDePelagem);
            Controls.Add(LblTipoDePelagem);
            Controls.Add(txtRaca);
            Controls.Add(LblRaca);
            Controls.Add(txtNomePet);
            Controls.Add(LblNomeDoPet);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroDePet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Pet";
            Load += frmCadastroDePet_Load;
            GbPorte.ResumeLayout(false);
            PnlPorte.ResumeLayout(false);
            PnlPorte.PerformLayout();
            GbVacinado.ResumeLayout(false);
            PnlVacinado.ResumeLayout(false);
            PnlVacinado.PerformLayout();
            GbAlergico.ResumeLayout(false);
            PnlAlergico.ResumeLayout(false);
            PnlAlergico.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNomeDoPet;
        private TextBox txtNomePet;
        private Label LblRaca;
        private TextBox txtRaca;
        private TextBox txtTipoDePelagem;
        private Label LblTipoDePelagem;
        private RadioButton RdbPorteG;
        private RadioButton RdbPorteM;
        private RadioButton RdbPorteP;
        private GroupBox GbPorte;
        private GroupBox GbVacinado;
        private RadioButton RdbVacinadoNao;
        private RadioButton RdbVacinadoSim;
        private GroupBox GbAlergico;
        private RadioButton RdbAlergicoNao;
        private RadioButton RdbAlergicoSim;
        private DateTimePicker DtDataNascimento;
        private Label LblDataNascimento;
        private TextBox txtNomeTutor;
        private Label LblNomeTutor;
        private Button BtnBuscarCliente;
        private TextBox txtIdTutor;
        private TextBox TxtObservacoes;
        private Label LblObservacoes;
        private Button BtnCadastrar;
        private Label LblAlteraPet;
        private Panel PnlPorte;
        private Panel PnlVacinado;
        private Panel PnlAlergico;
        private Panel panel1;
    }
}