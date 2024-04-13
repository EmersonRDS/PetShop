namespace PetShop.src.Forms
{
    partial class frmBuscaDeClientes
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
            frmListaDeClientesBindingSource = new BindingSource(components);
            DtgListaDeClientes = new DataGridView();
            CbFiltro = new ComboBox();
            LblFiltro = new Label();
            TxtConteudoParaFiltro = new TextBox();
            BtnBuscar = new Button();
            BtnConfirmar = new Button();
            LblConteudo = new Label();
            ((System.ComponentModel.ISupportInitialize)frmListaDeClientesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtgListaDeClientes).BeginInit();
            SuspendLayout();
            // 
            // frmListaDeClientesBindingSource
            // 
            frmListaDeClientesBindingSource.DataSource = typeof(frmInformacaoDoCliente);
            // 
            // DtgListaDeClientes
            // 
            DtgListaDeClientes.AllowUserToAddRows = false;
            DtgListaDeClientes.AllowUserToDeleteRows = false;
            DtgListaDeClientes.AllowUserToResizeRows = false;
            DtgListaDeClientes.BackgroundColor = SystemColors.Highlight;
            DtgListaDeClientes.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            DtgListaDeClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgListaDeClientes.EditMode = DataGridViewEditMode.EditOnKeystroke;
            DtgListaDeClientes.GridColor = SystemColors.Control;
            DtgListaDeClientes.Location = new Point(12, 12);
            DtgListaDeClientes.MultiSelect = false;
            DtgListaDeClientes.Name = "DtgListaDeClientes";
            DtgListaDeClientes.ReadOnly = true;
            DtgListaDeClientes.RowHeadersVisible = false;
            DtgListaDeClientes.RowTemplate.Height = 25;
            DtgListaDeClientes.ScrollBars = ScrollBars.Vertical;
            DtgListaDeClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgListaDeClientes.ShowCellToolTips = false;
            DtgListaDeClientes.ShowEditingIcon = false;
            DtgListaDeClientes.Size = new Size(537, 378);
            DtgListaDeClientes.TabIndex = 0;
            DtgListaDeClientes.CellDoubleClick += DtgListaDeClientes_CellDoubleClick;
            // 
            // CbFiltro
            // 
            CbFiltro.DisplayMember = "Nome";
            CbFiltro.FormattingEnabled = true;
            CbFiltro.Items.AddRange(new object[] { "Nome", "Telefone" });
            CbFiltro.Location = new Point(12, 418);
            CbFiltro.Name = "CbFiltro";
            CbFiltro.Size = new Size(121, 23);
            CbFiltro.TabIndex = 1;
            CbFiltro.Text = "Selecione";
            // 
            // LblFiltro
            // 
            LblFiltro.AutoSize = true;
            LblFiltro.Location = new Point(12, 400);
            LblFiltro.Name = "LblFiltro";
            LblFiltro.Size = new Size(58, 15);
            LblFiltro.TabIndex = 2;
            LblFiltro.Text = "Filtrar por";
            // 
            // TxtConteudoParaFiltro
            // 
            TxtConteudoParaFiltro.Location = new Point(139, 418);
            TxtConteudoParaFiltro.Name = "TxtConteudoParaFiltro";
            TxtConteudoParaFiltro.PlaceholderText = "Conteúdo para busca";
            TxtConteudoParaFiltro.Size = new Size(268, 23);
            TxtConteudoParaFiltro.TabIndex = 3;
            TxtConteudoParaFiltro.KeyPress += TxtConteudoParaFiltro_KeyPress;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(413, 418);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(59, 23);
            BtnBuscar.TabIndex = 4;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(478, 418);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(71, 23);
            BtnConfirmar.TabIndex = 5;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = true;
            BtnConfirmar.Click += BtnConfirmar_Click;
            // 
            // LblConteudo
            // 
            LblConteudo.AutoSize = true;
            LblConteudo.Location = new Point(139, 400);
            LblConteudo.Name = "LblConteudo";
            LblConteudo.Size = new Size(107, 15);
            LblConteudo.TabIndex = 6;
            LblConteudo.Text = "Digite para a busca";
            // 
            // frmBuscaDeClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(561, 453);
            Controls.Add(LblConteudo);
            Controls.Add(BtnConfirmar);
            Controls.Add(BtnBuscar);
            Controls.Add(TxtConteudoParaFiltro);
            Controls.Add(LblFiltro);
            Controls.Add(CbFiltro);
            Controls.Add(DtgListaDeClientes);
            MaximumSize = new Size(577, 492);
            MinimumSize = new Size(577, 492);
            Name = "frmBuscaDeClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Busca de Clientes";
            ((System.ComponentModel.ISupportInitialize)frmListaDeClientesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtgListaDeClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource frmListaDeClientesBindingSource;
        private DataGridView DtgListaDeClientes;
        private ComboBox CbFiltro;
        private Label LblFiltro;
        private TextBox TxtConteudoParaFiltro;
        private Button BtnBuscar;
        private Button BtnConfirmar;
        private Label LblConteudo;
    }
}