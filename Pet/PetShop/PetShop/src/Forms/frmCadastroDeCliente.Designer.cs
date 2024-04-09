namespace PetShop.src.Forms
{
    partial class frmCadastroDeCliente
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
            TxtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTelefone = new TextBox();
            label3 = new Label();
            txtEndereco = new TextBox();
            label4 = new Label();
            TxtObservacoes = new TextBox();
            btnCadastrar = new Button();
            label5 = new Label();
            txtCidade = new TextBox();
            label6 = new Label();
            txtBairro = new TextBox();
            SuspendLayout();
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(12, 58);
            TxtNome.MaxLength = 150;
            TxtNome.Name = "TxtNome";
            TxtNome.PlaceholderText = "Digite o Nome";
            TxtNome.Size = new Size(172, 23);
            TxtNome.TabIndex = 0;
            TxtNome.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(12, 112);
            txtTelefone.MaxLength = 20;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Digite o Telefone (números)";
            txtTelefone.Size = new Size(172, 23);
            txtTelefone.TabIndex = 1;
            txtTelefone.WordWrap = false;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 143);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Endereço";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(250, 166);
            txtEndereco.MaxLength = 250;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "Digite o Endereço";
            txtEndereco.Size = new Size(172, 23);
            txtEndereco.TabIndex = 4;
            txtEndereco.WordWrap = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 7;
            label4.Text = "Observações";
            // 
            // TxtObservacoes
            // 
            TxtObservacoes.Location = new Point(12, 220);
            TxtObservacoes.MaxLength = 300;
            TxtObservacoes.Multiline = true;
            TxtObservacoes.Name = "TxtObservacoes";
            TxtObservacoes.PlaceholderText = "Digite as Observações";
            TxtObservacoes.Size = new Size(295, 66);
            TxtObservacoes.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCadastrar.BackColor = SystemColors.ButtonFace;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Location = new Point(12, 294);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 25);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += button1_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(250, 89);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 10;
            label5.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(250, 112);
            txtCidade.MaxLength = 250;
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "Digite a Cidade";
            txtCidade.Size = new Size(172, 23);
            txtCidade.TabIndex = 2;
            txtCidade.WordWrap = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 143);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 12;
            label6.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(12, 166);
            txtBairro.MaxLength = 250;
            txtBairro.Name = "txtBairro";
            txtBairro.PlaceholderText = "Digite o Bairro";
            txtBairro.Size = new Size(172, 23);
            txtBairro.TabIndex = 3;
            txtBairro.WordWrap = false;
            // 
            // frmCadastroDeCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(484, 354);
            Controls.Add(label6);
            Controls.Add(txtBairro);
            Controls.Add(label5);
            Controls.Add(txtCidade);
            Controls.Add(btnCadastrar);
            Controls.Add(label4);
            Controls.Add(TxtObservacoes);
            Controls.Add(label3);
            Controls.Add(txtEndereco);
            Controls.Add(label2);
            Controls.Add(txtTelefone);
            Controls.Add(label1);
            Controls.Add(TxtNome);
            ForeColor = SystemColors.ControlText;
            Name = "frmCadastroDeCliente";
            Text = "Cadastro de Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNome;
        private Label label1;
        private Label label2;
        private TextBox txtTelefone;
        private Label label3;
        private TextBox txtEndereco;
        private Label label4;
        private TextBox TxtObservacoes;
        private Button btnCadastrar;
        private Label label5;
        private TextBox txtCidade;
        private Label label6;
        private TextBox txtBairro;
    }
}