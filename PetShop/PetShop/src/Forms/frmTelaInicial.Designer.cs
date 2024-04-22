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
            ListaDeClientes = new Button();
            CadastrarCliente = new Button();
            CadastrarPet = new Button();
            BtnCadastroPedidos = new Button();
            BtnListaDeOrdens = new Button();
            SuspendLayout();
            // 
            // ListaDeClientes
            // 
            ListaDeClientes.BackColor = Color.Aquamarine;
            ListaDeClientes.FlatAppearance.BorderColor = Color.DodgerBlue;
            ListaDeClientes.FlatAppearance.BorderSize = 2;
            ListaDeClientes.FlatStyle = FlatStyle.Flat;
            ListaDeClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListaDeClientes.ForeColor = SystemColors.ControlText;
            ListaDeClientes.Location = new Point(152, 169);
            ListaDeClientes.Name = "ListaDeClientes";
            ListaDeClientes.Size = new Size(188, 103);
            ListaDeClientes.TabIndex = 1;
            ListaDeClientes.Text = "Lista de Clientes";
            ListaDeClientes.UseVisualStyleBackColor = false;
            ListaDeClientes.Click += ListaDeClientes_Click;
            // 
            // CadastrarCliente
            // 
            CadastrarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CadastrarCliente.BackColor = Color.Aquamarine;
            CadastrarCliente.FlatAppearance.BorderColor = Color.DodgerBlue;
            CadastrarCliente.FlatAppearance.BorderSize = 2;
            CadastrarCliente.FlatStyle = FlatStyle.Flat;
            CadastrarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CadastrarCliente.ForeColor = SystemColors.ControlText;
            CadastrarCliente.Location = new Point(410, 169);
            CadastrarCliente.Name = "CadastrarCliente";
            CadastrarCliente.Size = new Size(188, 103);
            CadastrarCliente.TabIndex = 2;
            CadastrarCliente.Text = "Cadastrar Cliente";
            CadastrarCliente.UseVisualStyleBackColor = false;
            CadastrarCliente.Click += CadastrarCliente_Click;
            // 
            // CadastrarPet
            // 
            CadastrarPet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CadastrarPet.BackColor = Color.Aquamarine;
            CadastrarPet.FlatAppearance.BorderColor = Color.DodgerBlue;
            CadastrarPet.FlatAppearance.BorderSize = 2;
            CadastrarPet.FlatStyle = FlatStyle.Flat;
            CadastrarPet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CadastrarPet.ForeColor = SystemColors.ControlText;
            CadastrarPet.Location = new Point(668, 169);
            CadastrarPet.Name = "CadastrarPet";
            CadastrarPet.Size = new Size(188, 103);
            CadastrarPet.TabIndex = 3;
            CadastrarPet.Text = "Cadastrar Pet";
            CadastrarPet.UseVisualStyleBackColor = false;
            CadastrarPet.Click += CadastrarPet_Click;
            // 
            // BtnCadastroPedidos
            // 
            BtnCadastroPedidos.BackColor = Color.Aquamarine;
            BtnCadastroPedidos.FlatAppearance.BorderColor = Color.DodgerBlue;
            BtnCadastroPedidos.FlatAppearance.BorderSize = 2;
            BtnCadastroPedidos.FlatStyle = FlatStyle.Flat;
            BtnCadastroPedidos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCadastroPedidos.ForeColor = SystemColors.ControlText;
            BtnCadastroPedidos.Location = new Point(152, 334);
            BtnCadastroPedidos.Name = "BtnCadastroPedidos";
            BtnCadastroPedidos.Size = new Size(188, 103);
            BtnCadastroPedidos.TabIndex = 4;
            BtnCadastroPedidos.Text = "Cadastro de Ordem de Serviço";
            BtnCadastroPedidos.UseVisualStyleBackColor = false;
            BtnCadastroPedidos.Click += BtnCadastroPedidos_Click;
            // 
            // BtnListaDeOrdens
            // 
            BtnListaDeOrdens.BackColor = Color.Aquamarine;
            BtnListaDeOrdens.FlatAppearance.BorderColor = Color.DodgerBlue;
            BtnListaDeOrdens.FlatAppearance.BorderSize = 2;
            BtnListaDeOrdens.FlatStyle = FlatStyle.Flat;
            BtnListaDeOrdens.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnListaDeOrdens.ForeColor = SystemColors.ControlText;
            BtnListaDeOrdens.Location = new Point(410, 334);
            BtnListaDeOrdens.Name = "BtnListaDeOrdens";
            BtnListaDeOrdens.Size = new Size(188, 103);
            BtnListaDeOrdens.TabIndex = 5;
            BtnListaDeOrdens.Text = "Ordens de Serviço";
            BtnListaDeOrdens.UseVisualStyleBackColor = false;
            BtnListaDeOrdens.Click += BtnListaDeOrdens_Click;
            // 
            // frmTelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1008, 729);
            Controls.Add(BtnListaDeOrdens);
            Controls.Add(BtnCadastroPedidos);
            Controls.Add(CadastrarPet);
            Controls.Add(CadastrarCliente);
            Controls.Add(ListaDeClientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmTelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial";
            ResumeLayout(false);
        }

        #endregion

        private Button ListaDeClientes;
        private Button CadastrarCliente;
        private Button CadastrarPet;
        private Button BtnCadastroPedidos;
        private Button BtnListaDeOrdens;
    }
}
