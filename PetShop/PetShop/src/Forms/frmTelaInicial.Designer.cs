namespace PetShop
{
    partial class frmTelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaInicial));
            PnlMenuLateral = new Panel();
            PnlBotoes = new Panel();
            btnListarOrdem = new Button();
            btnCadastrarOrdem = new Button();
            BtnInformacoesDoCliente = new Button();
            BtnCadastrarPet = new Button();
            btnCadastrarCliente = new Button();
            PnlLogo = new Panel();
            imgLogo = new PictureBox();
            PnlMenuLateral.SuspendLayout();
            PnlBotoes.SuspendLayout();
            PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // PnlMenuLateral
            // 
            PnlMenuLateral.BackColor = Color.FromArgb(46, 139, 201);
            PnlMenuLateral.Controls.Add(PnlBotoes);
            PnlMenuLateral.Controls.Add(PnlLogo);
            PnlMenuLateral.Dock = DockStyle.Left;
            PnlMenuLateral.Location = new Point(0, 0);
            PnlMenuLateral.Name = "PnlMenuLateral";
            PnlMenuLateral.Size = new Size(232, 729);
            PnlMenuLateral.TabIndex = 6;
            // 
            // PnlBotoes
            // 
            PnlBotoes.Controls.Add(btnListarOrdem);
            PnlBotoes.Controls.Add(btnCadastrarOrdem);
            PnlBotoes.Controls.Add(BtnInformacoesDoCliente);
            PnlBotoes.Controls.Add(BtnCadastrarPet);
            PnlBotoes.Controls.Add(btnCadastrarCliente);
            PnlBotoes.Dock = DockStyle.Fill;
            PnlBotoes.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PnlBotoes.Location = new Point(0, 100);
            PnlBotoes.Name = "PnlBotoes";
            PnlBotoes.Size = new Size(232, 629);
            PnlBotoes.TabIndex = 1;
            // 
            // btnListarOrdem
            // 
            btnListarOrdem.Dock = DockStyle.Top;
            btnListarOrdem.FlatAppearance.BorderSize = 0;
            btnListarOrdem.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 153, 204);
            btnListarOrdem.FlatStyle = FlatStyle.Flat;
            btnListarOrdem.Location = new Point(0, 180);
            btnListarOrdem.Name = "btnListarOrdem";
            btnListarOrdem.Size = new Size(232, 45);
            btnListarOrdem.TabIndex = 4;
            btnListarOrdem.Text = "Lista de Ordens de Serviço";
            btnListarOrdem.UseVisualStyleBackColor = true;
            btnListarOrdem.Click += btnListarOrdem_Click;
            // 
            // btnCadastrarOrdem
            // 
            btnCadastrarOrdem.Dock = DockStyle.Top;
            btnCadastrarOrdem.FlatAppearance.BorderSize = 0;
            btnCadastrarOrdem.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 153, 204);
            btnCadastrarOrdem.FlatStyle = FlatStyle.Flat;
            btnCadastrarOrdem.Location = new Point(0, 135);
            btnCadastrarOrdem.Name = "btnCadastrarOrdem";
            btnCadastrarOrdem.Size = new Size(232, 45);
            btnCadastrarOrdem.TabIndex = 3;
            btnCadastrarOrdem.Text = "Cadastro de Ordem de Serviço";
            btnCadastrarOrdem.UseVisualStyleBackColor = true;
            btnCadastrarOrdem.Click += btnCadastrarOrdem_Click;
            // 
            // BtnInformacoesDoCliente
            // 
            BtnInformacoesDoCliente.Dock = DockStyle.Top;
            BtnInformacoesDoCliente.FlatAppearance.BorderSize = 0;
            BtnInformacoesDoCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 153, 204);
            BtnInformacoesDoCliente.FlatStyle = FlatStyle.Flat;
            BtnInformacoesDoCliente.Location = new Point(0, 90);
            BtnInformacoesDoCliente.Name = "BtnInformacoesDoCliente";
            BtnInformacoesDoCliente.Size = new Size(232, 45);
            BtnInformacoesDoCliente.TabIndex = 2;
            BtnInformacoesDoCliente.Text = "Informações do Cliente";
            BtnInformacoesDoCliente.UseVisualStyleBackColor = true;
            BtnInformacoesDoCliente.Click += BtnInformacoesDoCliente_Click;
            // 
            // BtnCadastrarPet
            // 
            BtnCadastrarPet.Dock = DockStyle.Top;
            BtnCadastrarPet.FlatAppearance.BorderSize = 0;
            BtnCadastrarPet.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 153, 204);
            BtnCadastrarPet.FlatStyle = FlatStyle.Flat;
            BtnCadastrarPet.Location = new Point(0, 45);
            BtnCadastrarPet.Name = "BtnCadastrarPet";
            BtnCadastrarPet.Size = new Size(232, 45);
            BtnCadastrarPet.TabIndex = 1;
            BtnCadastrarPet.Text = "Cadastrar Pet";
            BtnCadastrarPet.UseVisualStyleBackColor = true;
            BtnCadastrarPet.Click += BtnCadastrarPet_Click;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Dock = DockStyle.Top;
            btnCadastrarCliente.FlatAppearance.BorderSize = 0;
            btnCadastrarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 153, 204);
            btnCadastrarCliente.FlatStyle = FlatStyle.Flat;
            btnCadastrarCliente.Location = new Point(0, 0);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(232, 45);
            btnCadastrarCliente.TabIndex = 0;
            btnCadastrarCliente.Text = "Cadastrar Cliente";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // PnlLogo
            // 
            PnlLogo.BackgroundImageLayout = ImageLayout.None;
            PnlLogo.Controls.Add(imgLogo);
            PnlLogo.Dock = DockStyle.Top;
            PnlLogo.Location = new Point(0, 0);
            PnlLogo.Name = "PnlLogo";
            PnlLogo.RightToLeft = RightToLeft.Yes;
            PnlLogo.Size = new Size(232, 100);
            PnlLogo.TabIndex = 0;
            // 
            // imgLogo
            // 
            imgLogo.BackgroundImage = Properties.Resources.logotipo;
            imgLogo.BackgroundImageLayout = ImageLayout.Center;
            imgLogo.Dock = DockStyle.Left;
            imgLogo.Location = new Point(0, 0);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(66, 100);
            imgLogo.TabIndex = 0;
            imgLogo.TabStop = false;
            // 
            // frmTelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 153, 204);
            ClientSize = new Size(1008, 729);
            Controls.Add(PnlMenuLateral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmTelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial";
            PnlMenuLateral.ResumeLayout(false);
            PnlBotoes.ResumeLayout(false);
            PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel PnlMenuLateral;
        private Panel PnlLogo;
        private PictureBox imgLogo;
        private Panel PnlBotoes;
        private Button btnListarOrdem;
        private Button btnCadastrarOrdem;
        private Button BtnInformacoesDoCliente;
        private Button BtnCadastrarPet;
        private Button btnCadastrarCliente;
    }
}
