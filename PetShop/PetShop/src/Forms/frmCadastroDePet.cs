using PetShop.src.Models;

namespace PetShop.src.Forms
{
    public partial class frmCadastroDePet : Form
    {

        public bool alteraPet = false;
        public Pets pet = new Pets();
        private int dadosRecebidos;
        public frmCadastroDePet()
        {
            InitializeComponent();
            DtDataNascimento.MaxDate = DateTime.Now;


        }

        private void LimparCampos()
        {
            txtIdTutor.Text = string.Empty;
            txtNomePet.Text = string.Empty;
            txtNomeTutor.Text = string.Empty;
            txtRaca.Text = string.Empty;
            txtTipoDePelagem.Text = string.Empty;
            TxtObservacoes.Text = string.Empty;
            RdbAlergicoNao.Checked = false;
            RdbAlergicoSim.Checked = false;
            RdbPorteG.Checked = false;
            RdbPorteM.Checked = false;
            RdbPorteP.Checked = false;
            RdbVacinadoNao.Checked = false;
            RdbVacinadoSim.Checked = false;
            DtDataNascimento.Value = DtDataNascimento.MaxDate;
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscaDeClientes buscaDeClientes = new frmBuscaDeClientes();
            if (buscaDeClientes.ShowDialog() == DialogResult.OK)
            {
                dadosRecebidos = buscaDeClientes.IdCliente;

                Cliente c = new Cliente();
                c.ConsultaCliente(dadosRecebidos);
                txtIdTutor.Text = c.Id.ToString();
                txtNomeTutor.Text = c.Nome;
            }
        }

        private void txtIdTutor_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdTutor.Text))
            {
                // Remove o caracter se nao for numero
                txtIdTutor.Text = new string(txtIdTutor.Text.Where(char.IsDigit).ToArray());
            }
        }

        private void txtIdTutor_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtIdTutor.Text))
            {
                dadosRecebidos = Convert.ToInt32(txtIdTutor.Text);
                Cliente c = new Cliente();
                c.ConsultaCliente(dadosRecebidos);
                txtIdTutor.Text = c.Id.ToString();
                txtNomeTutor.Text = c.Nome;
            }
            else
            {
                MessageBox.Show("Digite um Id válido para o tutor");
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            string nome, raca, tipoDePelo, porte, observacoes;
            DateTime dataDeNascimento;
            int idTutor, vacinado, alergico;

            if (!(String.IsNullOrWhiteSpace(txtNomePet.Text) || String.IsNullOrWhiteSpace(txtRaca.Text) || String.IsNullOrWhiteSpace(txtTipoDePelagem.Text)
                || String.IsNullOrWhiteSpace(txtIdTutor.Text) || (!RdbPorteG.Checked && !RdbPorteM.Checked && !RdbPorteP.Checked) || (!RdbAlergicoSim.Checked && !RdbAlergicoNao.Checked)
                || (!RdbVacinadoNao.Checked && !RdbVacinadoSim.Checked)))
            {
                nome = txtNomePet.Text;
                idTutor = Convert.ToInt32(txtIdTutor.Text);
                raca = txtRaca.Text;
                tipoDePelo = txtTipoDePelagem.Text;
                dataDeNascimento = DtDataNascimento.Value;
                observacoes = TxtObservacoes.Text;

                Pets pets = new Pets(nome, idTutor, raca, tipoDePelo, dataDeNascimento, observacoes);

                //valida porte
                if (RdbPorteG.Checked)
                {
                    porte = "G";
                }
                else if (RdbPorteM.Checked)
                {
                    porte = "M";
                }
                else
                {
                    porte = "P";
                }

                pets.Porte = porte;

                //valida alergico

                if (RdbAlergicoSim.Checked)
                {
                    alergico = 1;
                }
                else
                {
                    alergico = 0;
                }
                pets.PossuiAlergia = alergico;

                //valida vacinado
                if (RdbVacinadoSim.Checked)
                {
                    vacinado = 1;
                }
                else
                {
                    vacinado = 0;
                }
                pets.Vacinado = vacinado;

                if (alteraPet)
                {
                    pets.Id = pet.Id;
                }

                try
                {
                    if (!alteraPet)
                    {
                        pets.CadastroDePet();
                        LimparCampos();
                    }
                    else
                    {
                        pets.update = true;
                        pets.AlterarPet();
                        Close();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Preencha as informações obrigatórias!\nInformações obrigatórias possuem um *");
            }
        }

        private void txtIdTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                txtIdTutor_Leave(sender, e);
            }
        }

        private void frmCadastroDePet_Load(object sender, EventArgs e)
        {
            if (alteraPet)
            {
                txtIdTutor.ReadOnly = true;
                txtNomePet.ReadOnly = true;
                txtRaca.ReadOnly = true;
                txtTipoDePelagem.ReadOnly = true;
                TxtObservacoes.ReadOnly = true;
                DtDataNascimento.Enabled = false;
                BtnBuscarCliente.Enabled = false;
                RdbAlergicoNao.Enabled = false;
                RdbAlergicoSim.Enabled = false;
                RdbPorteG.Enabled = false;
                RdbPorteM.Enabled = false;
                RdbPorteP.Enabled = false;
                RdbVacinadoNao.Enabled = false;
                RdbVacinadoSim.Enabled = false;
                LblAlteraPet.Visible = true;

                BtnCadastrar.Text = "Confirmar";
                txtNomePet.Text = pet.Nome;
                txtRaca.Text = pet.Raca;
                txtTipoDePelagem.Text = pet.TipoDePelagem;
                TxtObservacoes.Text = pet.Observacoes;
                if (!(pet.DataDeNascimento.ToString() == "01/01/0001 00:00:00"))
                {
                    DtDataNascimento.Value = pet.DataDeNascimento;
                }

                switch (pet.Vacinado)
                {
                    case 0:
                        RdbVacinadoNao.Checked = true;
                        break;
                    case 1:
                        RdbVacinadoSim.Checked = true;
                        break;
                }

                switch (pet.PossuiAlergia)
                {
                    case 0:
                        RdbAlergicoNao.Checked = true;
                        break;
                    case 1:
                        RdbAlergicoSim.Checked = true;
                        break;
                }

                switch (pet.Porte)
                {
                    case "G":
                        RdbPorteG.Checked = true;
                        break;
                    case "M":
                        RdbPorteM.Checked = true;
                        break;
                    case "P":
                        RdbPorteP.Checked = true;
                        break;
                }

                txtIdTutor.Text = pet.IdTutor.ToString();
                txtIdTutor_Leave(sender, e);
            }
        }

        private void PnlPorte_DoubleClick(object sender, EventArgs e)
        {
            RdbPorteG.Enabled = true;
            RdbPorteM.Enabled = true;
            RdbPorteP.Enabled = true;
        }

        private void PnlVacinado_DoubleClick(object sender, EventArgs e)
        {
            RdbVacinadoNao.Enabled = true;
            RdbVacinadoSim.Enabled = true;
        }

        private void PnlAlergico_DoubleClick(object sender, EventArgs e)
        {
            RdbAlergicoNao.Enabled = true;
            RdbAlergicoSim.Enabled = true;
        }

        private void txtNomePet_DoubleClick(object sender, EventArgs e)
        {
            txtNomePet.ReadOnly = false;
        }

        private void txtRaca_DoubleClick(object sender, EventArgs e)
        {
            txtRaca.ReadOnly = false;
        }

        private void txtTipoDePelagem_DoubleClick(object sender, EventArgs e)
        {
            txtTipoDePelagem.ReadOnly = false;
        }

        private void txtIdTutor_DoubleClick(object sender, EventArgs e)
        {
            txtIdTutor.ReadOnly = false;
            BtnBuscarCliente.Enabled = true;
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            DtDataNascimento.Enabled = true;
        }

        private void TxtObservacoes_DoubleClick(object sender, EventArgs e)
        {
            TxtObservacoes.ReadOnly = false;
        }
    }
}