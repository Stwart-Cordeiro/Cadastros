using System;
using System.Windows.Forms;
using DAO;
using Negocio;


namespace Apresentacao
{
    public partial class FrmCadastroInsert : Form
    {
        Acaonatela acaoselecionada;

        public FrmCadastroInsert(Acaonatela acaoNaTela , Cadastro cadastro)
        {
            InitializeComponent();

            acaoselecionada = acaoNaTela;

            if (acaoNaTela == Acaonatela.Inserir)
            {
                this.Text = "Inserir Cliente";
            }
            else if (acaoNaTela == Acaonatela.Alterar)
            {
                this.Text = "Alterar Cliente";
                txtCodigo.Text = cadastro.IDCadastro.ToString();
                txtNome.Text = cadastro.Nome;
                txtTelefone.Text = cadastro.Telefone;
                txtEmail.Text = cadastro.Email;
                btnSalvar.Text = "Alterar";
            }
            else if (acaoNaTela == Acaonatela.Consultar)
            {
                this.Text = "Consultar Cliente";
                txtCodigo.TabStop = false;
                txtNome.ReadOnly = true;
                txtNome.TabStop = false;
                txtTelefone.ReadOnly = true;
                txtTelefone.TabStop = false;
                txtEmail.ReadOnly = true;
                txtEmail.TabStop = false;
                txtCodigo.Text = cadastro.IDCadastro.ToString();
                txtNome.Text = cadastro.Nome;
                txtTelefone.Text = cadastro.Telefone;
                txtEmail.Text = cadastro.Email;
                btnSalvar.Visible = false;
                btnSair.Text = "Fechar";
                btnSair.Focus();

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (acaoselecionada == Acaonatela.Inserir)
            {
                Cadastro cadastro = new Cadastro();
                cadastro.Nome = txtNome.Text;
                cadastro.Telefone = txtTelefone.Text;
                cadastro.Email = txtEmail.Text;
                cadastroModel cadastroModel = new cadastroModel();
                string retorno = cadastroModel.Insert(cadastro);

                try
                {
                    int idcliente = Convert.ToInt32(retorno);
                    MessageBox.Show("Cadastro Efetuado com Sucesso: "+idcliente.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                     MessageBox.Show("Não foi Possivel Inserir. Detalhes"+retorno);
                    this.DialogResult = DialogResult.No;
                }
            }
            else if (acaoselecionada == Acaonatela.Alterar)
            {
                Cadastro cadastro = new Cadastro();
                cadastro.IDCadastro = Convert.ToInt32(txtCodigo.Text);
                cadastro.Nome = txtNome.Text;
                cadastro.Telefone = txtTelefone.Text;
                cadastro.Email = txtEmail.Text;
                cadastroModel cadastroModelAltera = new cadastroModel();
                string retorno = cadastroModelAltera.Update(cadastro);

                try
                {
                    int idcliente = Convert.ToInt32(retorno);
                    MessageBox.Show("Alteração Efetuado com Sucesso: " + idcliente.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi Possivel Alterar. Detalhes" + retorno);
                    this.DialogResult = DialogResult.No;
                }
            }
        }
    }
}
