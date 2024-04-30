namespace PetShop.src.Forms
{
    partial class frmCadastroDeInsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroDeInsumo));
            BtnBuscarInsumo = new Button();
            TxtDescricaoInsumo = new TextBox();
            LblDescricao = new Label();
            TxtCodInusmo = new TextBox();
            lblCodInsumo = new Label();
            LblVolume = new Label();
            TxtVolume = new TextBox();
            CbUnidadeMedida = new ComboBox();
            LblEstqoueAtual = new Label();
            TxtEstoqueAtual = new TextBox();
            TxtCusto = new TextBox();
            LblCusto = new Label();
            btnRemoverCodigoBarras = new Button();
            BtnAdicionarCodigoBarras = new Button();
            TxtAdicionarCodigoBarras = new TextBox();
            LbCodigoBarras = new ListBox();
            LblCodigoBarras = new Label();
            BtnNovo = new Button();
            BtnCancelar = new Button();
            BtnAlterar = new Button();
            BtnSalvar = new Button();
            SuspendLayout();
            // 
            // BtnBuscarInsumo
            // 
            BtnBuscarInsumo.Image = Properties.Resources.btnLupa;
            BtnBuscarInsumo.Location = new Point(82, 30);
            BtnBuscarInsumo.Name = "BtnBuscarInsumo";
            BtnBuscarInsumo.Size = new Size(34, 23);
            BtnBuscarInsumo.TabIndex = 34;
            BtnBuscarInsumo.UseVisualStyleBackColor = true;
            BtnBuscarInsumo.Click += BtnBuscarInsumo_Click;
            // 
            // TxtDescricaoInsumo
            // 
            TxtDescricaoInsumo.Location = new Point(122, 30);
            TxtDescricaoInsumo.Name = "TxtDescricaoInsumo";
            TxtDescricaoInsumo.ReadOnly = true;
            TxtDescricaoInsumo.Size = new Size(331, 23);
            TxtDescricaoInsumo.TabIndex = 33;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(123, 9);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(58, 15);
            LblDescricao.TabIndex = 32;
            LblDescricao.Text = "Descrição";
            // 
            // TxtCodInusmo
            // 
            TxtCodInusmo.Location = new Point(12, 30);
            TxtCodInusmo.Name = "TxtCodInusmo";
            TxtCodInusmo.Size = new Size(64, 23);
            TxtCodInusmo.TabIndex = 31;
            TxtCodInusmo.TextChanged += TxtCodInusmo_TextChanged;
            TxtCodInusmo.KeyPress += TxtCodInusmo_KeyPress;
            // 
            // lblCodInsumo
            // 
            lblCodInsumo.AutoSize = true;
            lblCodInsumo.Location = new Point(12, 9);
            lblCodInsumo.Name = "lblCodInsumo";
            lblCodInsumo.Size = new Size(46, 15);
            lblCodInsumo.TabIndex = 30;
            lblCodInsumo.Text = "Código";
            // 
            // LblVolume
            // 
            LblVolume.AutoSize = true;
            LblVolume.Location = new Point(257, 59);
            LblVolume.Name = "LblVolume";
            LblVolume.Size = new Size(115, 15);
            LblVolume.TabIndex = 35;
            LblVolume.Text = "Volume por Unidade";
            // 
            // TxtVolume
            // 
            TxtVolume.Location = new Point(257, 80);
            TxtVolume.Name = "TxtVolume";
            TxtVolume.ReadOnly = true;
            TxtVolume.Size = new Size(54, 23);
            TxtVolume.TabIndex = 36;
            // 
            // CbUnidadeMedida
            // 
            CbUnidadeMedida.Enabled = false;
            CbUnidadeMedida.FormattingEnabled = true;
            CbUnidadeMedida.Items.AddRange(new object[] { "Litro", "KG" });
            CbUnidadeMedida.Location = new Point(317, 80);
            CbUnidadeMedida.Name = "CbUnidadeMedida";
            CbUnidadeMedida.Size = new Size(55, 23);
            CbUnidadeMedida.TabIndex = 37;
            // 
            // LblEstqoueAtual
            // 
            LblEstqoueAtual.AutoSize = true;
            LblEstqoueAtual.Location = new Point(257, 129);
            LblEstqoueAtual.Name = "LblEstqoueAtual";
            LblEstqoueAtual.Size = new Size(80, 15);
            LblEstqoueAtual.TabIndex = 38;
            LblEstqoueAtual.Text = "Estoque Atual";
            // 
            // TxtEstoqueAtual
            // 
            TxtEstoqueAtual.Location = new Point(257, 149);
            TxtEstoqueAtual.Name = "TxtEstoqueAtual";
            TxtEstoqueAtual.ReadOnly = true;
            TxtEstoqueAtual.Size = new Size(104, 23);
            TxtEstoqueAtual.TabIndex = 39;
            // 
            // TxtCusto
            // 
            TxtCusto.Location = new Point(367, 149);
            TxtCusto.Name = "TxtCusto";
            TxtCusto.ReadOnly = true;
            TxtCusto.Size = new Size(86, 23);
            TxtCusto.TabIndex = 41;
            // 
            // LblCusto
            // 
            LblCusto.AutoSize = true;
            LblCusto.Location = new Point(367, 129);
            LblCusto.Name = "LblCusto";
            LblCusto.Size = new Size(38, 15);
            LblCusto.TabIndex = 40;
            LblCusto.Text = "Custo";
            // 
            // btnRemoverCodigoBarras
            // 
            btnRemoverCodigoBarras.Enabled = false;
            btnRemoverCodigoBarras.Image = Properties.Resources.btnRemover;
            btnRemoverCodigoBarras.Location = new Point(204, 147);
            btnRemoverCodigoBarras.Name = "btnRemoverCodigoBarras";
            btnRemoverCodigoBarras.Size = new Size(29, 25);
            btnRemoverCodigoBarras.TabIndex = 56;
            btnRemoverCodigoBarras.UseVisualStyleBackColor = true;
            btnRemoverCodigoBarras.Click += btnRemoverCodigoBarras_Click;
            // 
            // BtnAdicionarCodigoBarras
            // 
            BtnAdicionarCodigoBarras.Enabled = false;
            BtnAdicionarCodigoBarras.Image = Properties.Resources.btnAdicionar;
            BtnAdicionarCodigoBarras.Location = new Point(204, 110);
            BtnAdicionarCodigoBarras.Name = "BtnAdicionarCodigoBarras";
            BtnAdicionarCodigoBarras.Size = new Size(29, 25);
            BtnAdicionarCodigoBarras.TabIndex = 55;
            BtnAdicionarCodigoBarras.UseVisualStyleBackColor = true;
            BtnAdicionarCodigoBarras.Click += BtnAdicionarCodigoBarras_Click;
            // 
            // TxtAdicionarCodigoBarras
            // 
            TxtAdicionarCodigoBarras.Location = new Point(12, 80);
            TxtAdicionarCodigoBarras.Name = "TxtAdicionarCodigoBarras";
            TxtAdicionarCodigoBarras.PlaceholderText = "Digite o código de barras";
            TxtAdicionarCodigoBarras.ReadOnly = true;
            TxtAdicionarCodigoBarras.Size = new Size(186, 23);
            TxtAdicionarCodigoBarras.TabIndex = 54;
            TxtAdicionarCodigoBarras.TextChanged += TxtAdicionarCodigoBarras_TextChanged;
            TxtAdicionarCodigoBarras.KeyPress += TxtAdicionarCodigoBarras_KeyPress;
            // 
            // LbCodigoBarras
            // 
            LbCodigoBarras.FormattingEnabled = true;
            LbCodigoBarras.ItemHeight = 15;
            LbCodigoBarras.Location = new Point(12, 108);
            LbCodigoBarras.Name = "LbCodigoBarras";
            LbCodigoBarras.Size = new Size(186, 64);
            LbCodigoBarras.TabIndex = 53;
            // 
            // LblCodigoBarras
            // 
            LblCodigoBarras.AutoSize = true;
            LblCodigoBarras.Location = new Point(12, 59);
            LblCodigoBarras.Name = "LblCodigoBarras";
            LblCodigoBarras.Size = new Size(97, 15);
            LblCodigoBarras.TabIndex = 52;
            LblCodigoBarras.Text = "Código de barras";
            // 
            // BtnNovo
            // 
            BtnNovo.Image = Properties.Resources.btnNovo;
            BtnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNovo.Location = new Point(72, 193);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(73, 41);
            BtnNovo.TabIndex = 60;
            BtnNovo.Text = "Novo";
            BtnNovo.TextAlign = ContentAlignment.MiddleRight;
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Enabled = false;
            BtnCancelar.Image = Properties.Resources.BtnCancelar;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(230, 193);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(87, 41);
            BtnCancelar.TabIndex = 59;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAlterar
            // 
            BtnAlterar.Image = Properties.Resources.BtnAlterar2;
            BtnAlterar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAlterar.Location = new Point(151, 193);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(73, 41);
            BtnAlterar.TabIndex = 58;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.TextAlign = ContentAlignment.MiddleRight;
            BtnAlterar.UseVisualStyleBackColor = true;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Enabled = false;
            BtnSalvar.Image = Properties.Resources.btnSalvar1;
            BtnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalvar.Location = new Point(323, 193);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(73, 41);
            BtnSalvar.TabIndex = 57;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.TextAlign = ContentAlignment.MiddleRight;
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // frmCadastroDeInsumo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(469, 246);
            Controls.Add(BtnNovo);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnSalvar);
            Controls.Add(btnRemoverCodigoBarras);
            Controls.Add(BtnAdicionarCodigoBarras);
            Controls.Add(TxtAdicionarCodigoBarras);
            Controls.Add(LbCodigoBarras);
            Controls.Add(LblCodigoBarras);
            Controls.Add(TxtCusto);
            Controls.Add(LblCusto);
            Controls.Add(TxtEstoqueAtual);
            Controls.Add(LblEstqoueAtual);
            Controls.Add(CbUnidadeMedida);
            Controls.Add(TxtVolume);
            Controls.Add(LblVolume);
            Controls.Add(BtnBuscarInsumo);
            Controls.Add(TxtDescricaoInsumo);
            Controls.Add(LblDescricao);
            Controls.Add(TxtCodInusmo);
            Controls.Add(lblCodInsumo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroDeInsumo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Insumo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBuscarInsumo;
        private TextBox TxtDescricaoInsumo;
        private Label LblDescricao;
        private TextBox TxtCodInusmo;
        private Label lblCodInsumo;
        private Label LblVolume;
        private TextBox TxtVolume;
        private ComboBox CbUnidadeMedida;
        private Label LblEstqoueAtual;
        private TextBox TxtEstoqueAtual;
        private TextBox TxtCusto;
        private Label LblCusto;
        private Button btnRemoverCodigoBarras;
        private Button BtnAdicionarCodigoBarras;
        private TextBox TxtAdicionarCodigoBarras;
        private ListBox LbCodigoBarras;
        private Label LblCodigoBarras;
        private Button BtnNovo;
        private Button BtnCancelar;
        private Button BtnAlterar;
        private Button BtnSalvar;
    }
}