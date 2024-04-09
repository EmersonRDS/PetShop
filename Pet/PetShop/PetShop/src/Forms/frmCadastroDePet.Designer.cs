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
            GbVacinado = new GroupBox();
            RdbVacinadoNao = new RadioButton();
            RdbVacinadoSim = new RadioButton();
            GbAlergico = new GroupBox();
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
            GbPorte.SuspendLayout();
            GbVacinado.SuspendLayout();
            GbAlergico.SuspendLayout();
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
            // 
            // txtTipoDePelagem
            // 
            txtTipoDePelagem.Location = new Point(12, 159);
            txtTipoDePelagem.Name = "txtTipoDePelagem";
            txtTipoDePelagem.PlaceholderText = "Digite o tipo de pelagem";
            txtTipoDePelagem.Size = new Size(222, 23);
            txtTipoDePelagem.TabIndex = 3;
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
            RdbPorteG.Location = new Point(26, 22);
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
            RdbPorteM.Location = new Point(65, 22);
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
            RdbPorteP.Location = new Point(104, 22);
            RdbPorteP.Name = "RdbPorteP";
            RdbPorteP.Size = new Size(32, 19);
            RdbPorteP.TabIndex = 6;
            RdbPorteP.TabStop = true;
            RdbPorteP.Text = "P";
            RdbPorteP.UseVisualStyleBackColor = true;
            // 
            // GbPorte
            // 
            GbPorte.Controls.Add(RdbPorteM);
            GbPorte.Controls.Add(RdbPorteP);
            GbPorte.Controls.Add(RdbPorteG);
            GbPorte.Location = new Point(12, 197);
            GbPorte.Name = "GbPorte";
            GbPorte.Size = new Size(169, 64);
            GbPorte.TabIndex = 11;
            GbPorte.TabStop = false;
            GbPorte.Text = "Porte*";
            // 
            // GbVacinado
            // 
            GbVacinado.Controls.Add(RdbVacinadoNao);
            GbVacinado.Controls.Add(RdbVacinadoSim);
            GbVacinado.Location = new Point(12, 282);
            GbVacinado.Name = "GbVacinado";
            GbVacinado.Size = new Size(169, 64);
            GbVacinado.TabIndex = 12;
            GbVacinado.TabStop = false;
            GbVacinado.Text = "Vacinado*";
            // 
            // RdbVacinadoNao
            // 
            RdbVacinadoNao.AutoSize = true;
            RdbVacinadoNao.Location = new Point(104, 22);
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
            RdbVacinadoSim.Location = new Point(26, 22);
            RdbVacinadoSim.Name = "RdbVacinadoSim";
            RdbVacinadoSim.Size = new Size(45, 19);
            RdbVacinadoSim.TabIndex = 7;
            RdbVacinadoSim.TabStop = true;
            RdbVacinadoSim.Text = "Sim";
            RdbVacinadoSim.UseVisualStyleBackColor = true;
            // 
            // GbAlergico
            // 
            GbAlergico.Controls.Add(RdbAlergicoNao);
            GbAlergico.Controls.Add(RdbAlergicoSim);
            GbAlergico.Location = new Point(12, 369);
            GbAlergico.Name = "GbAlergico";
            GbAlergico.Size = new Size(169, 64);
            GbAlergico.TabIndex = 13;
            GbAlergico.TabStop = false;
            GbAlergico.Text = "Alergico*";
            // 
            // RdbAlergicoNao
            // 
            RdbAlergicoNao.AutoSize = true;
            RdbAlergicoNao.Location = new Point(104, 22);
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
            RdbAlergicoSim.Location = new Point(26, 22);
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
            DtDataNascimento.Location = new Point(334, 99);
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
            // frmCadastroDePet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(669, 458);
            Controls.Add(BtnCadastrar);
            Controls.Add(LblObservacoes);
            Controls.Add(TxtObservacoes);
            Controls.Add(txtIdTutor);
            Controls.Add(BtnBuscarCliente);
            Controls.Add(txtNomeTutor);
            Controls.Add(LblNomeTutor);
            Controls.Add(LblDataNascimento);
            Controls.Add(DtDataNascimento);
            Controls.Add(GbAlergico);
            Controls.Add(GbVacinado);
            Controls.Add(GbPorte);
            Controls.Add(txtTipoDePelagem);
            Controls.Add(LblTipoDePelagem);
            Controls.Add(txtRaca);
            Controls.Add(LblRaca);
            Controls.Add(txtNomePet);
            Controls.Add(LblNomeDoPet);
            Name = "frmCadastroDePet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Pet";
            GbPorte.ResumeLayout(false);
            GbPorte.PerformLayout();
            GbVacinado.ResumeLayout(false);
            GbVacinado.PerformLayout();
            GbAlergico.ResumeLayout(false);
            GbAlergico.PerformLayout();
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
    }
}