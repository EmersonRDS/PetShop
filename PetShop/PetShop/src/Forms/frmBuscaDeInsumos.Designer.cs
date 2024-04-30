namespace PetShop.src.Forms
{
    partial class frmBuscaDeInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaDeInsumos));
            LblConteudo = new Label();
            BtnConfirmar = new Button();
            BtnBuscar = new Button();
            TxtConteudoParaFiltro = new TextBox();
            LblFiltro = new Label();
            CbFiltro = new ComboBox();
            DtgListaDeInsumos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DtgListaDeInsumos).BeginInit();
            SuspendLayout();
            // 
            // LblConteudo
            // 
            LblConteudo.AutoSize = true;
            LblConteudo.Location = new Point(139, 400);
            LblConteudo.Name = "LblConteudo";
            LblConteudo.Size = new Size(107, 15);
            LblConteudo.TabIndex = 13;
            LblConteudo.Text = "Digite para a busca";
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(478, 418);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(71, 23);
            BtnConfirmar.TabIndex = 12;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = true;
            BtnConfirmar.Click += BtnConfirmar_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(413, 418);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(59, 23);
            BtnBuscar.TabIndex = 11;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtConteudoParaFiltro
            // 
            TxtConteudoParaFiltro.Location = new Point(139, 418);
            TxtConteudoParaFiltro.Name = "TxtConteudoParaFiltro";
            TxtConteudoParaFiltro.PlaceholderText = "Conteúdo para busca";
            TxtConteudoParaFiltro.Size = new Size(268, 23);
            TxtConteudoParaFiltro.TabIndex = 10;
            TxtConteudoParaFiltro.KeyPress += TxtConteudoParaFiltro_KeyPress;
            // 
            // LblFiltro
            // 
            LblFiltro.AutoSize = true;
            LblFiltro.Location = new Point(12, 400);
            LblFiltro.Name = "LblFiltro";
            LblFiltro.Size = new Size(58, 15);
            LblFiltro.TabIndex = 9;
            LblFiltro.Text = "Filtrar por";
            // 
            // CbFiltro
            // 
            CbFiltro.DisplayMember = "Nome";
            CbFiltro.FormattingEnabled = true;
            CbFiltro.Items.AddRange(new object[] { "Nome", "Cod. Barras" });
            CbFiltro.Location = new Point(12, 418);
            CbFiltro.Name = "CbFiltro";
            CbFiltro.Size = new Size(121, 23);
            CbFiltro.TabIndex = 8;
            CbFiltro.Text = "Selecione";
            // 
            // DtgListaDeInsumos
            // 
            DtgListaDeInsumos.AllowUserToAddRows = false;
            DtgListaDeInsumos.AllowUserToDeleteRows = false;
            DtgListaDeInsumos.AllowUserToResizeRows = false;
            DtgListaDeInsumos.BackgroundColor = SystemColors.Highlight;
            DtgListaDeInsumos.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            DtgListaDeInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgListaDeInsumos.EditMode = DataGridViewEditMode.EditOnKeystroke;
            DtgListaDeInsumos.GridColor = SystemColors.Control;
            DtgListaDeInsumos.Location = new Point(12, 12);
            DtgListaDeInsumos.MultiSelect = false;
            DtgListaDeInsumos.Name = "DtgListaDeInsumos";
            DtgListaDeInsumos.ReadOnly = true;
            DtgListaDeInsumos.RowHeadersVisible = false;
            DtgListaDeInsumos.RowTemplate.Height = 25;
            DtgListaDeInsumos.ScrollBars = ScrollBars.Vertical;
            DtgListaDeInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgListaDeInsumos.ShowCellToolTips = false;
            DtgListaDeInsumos.ShowEditingIcon = false;
            DtgListaDeInsumos.Size = new Size(537, 378);
            DtgListaDeInsumos.TabIndex = 7;
            DtgListaDeInsumos.CellDoubleClick += DtgListaDeInsumos_CellDoubleClick;
            // 
            // frmBuscaDeInsumos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(561, 453);
            Controls.Add(LblConteudo);
            Controls.Add(BtnConfirmar);
            Controls.Add(BtnBuscar);
            Controls.Add(TxtConteudoParaFiltro);
            Controls.Add(LblFiltro);
            Controls.Add(CbFiltro);
            Controls.Add(DtgListaDeInsumos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBuscaDeInsumos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Busca de Insumos";
            ((System.ComponentModel.ISupportInitialize)DtgListaDeInsumos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblConteudo;
        private Button BtnConfirmar;
        private Button BtnBuscar;
        private TextBox TxtConteudoParaFiltro;
        private Label LblFiltro;
        private ComboBox CbFiltro;
        private DataGridView DtgListaDeInsumos;
    }
}