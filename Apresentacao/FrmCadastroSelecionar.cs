using System;
using System.Windows.Forms;
using DAO;
using Negocio;

namespace Apresentacao
{
    public partial class FrmCadastroSelecionar : Form
    {
        public FrmCadastroSelecionar()
        {
            InitializeComponent();
            DgvInicio.AutoGenerateColumns = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            cadastroModel cadastroModel = new cadastroModel();
            CadastroColecao colecao = new CadastroColecao();
            colecao = cadastroModel.consulta(txtPesquisa.Text);
            DgvInicio.DataSource = null;
            DgvInicio.DataSource = colecao;
            DgvInicio.Update();
            DgvInicio.Refresh();
        }

        private void AtualizarGrid()
        {
            cadastroModel cadastroModel = new cadastroModel();
            CadastroColecao colecao = new CadastroColecao();
            colecao = cadastroModel.consulta(txtPesquisa.Text);
            DgvInicio.DataSource = null;
            DgvInicio.DataSource = colecao;
            DgvInicio.Update();
            DgvInicio.Refresh();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (DgvInicio.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cadastro Selecionado.");
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem Certeza que quer Excluir o Registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            Cadastro cadastroselecionado = (DgvInicio.SelectedRows[0].DataBoundItem as Cadastro);

            cadastroModel cadastroModel = new cadastroModel();
            string retorno = cadastroModel.Delete(cadastroselecionado);

            try
            {
                int idCliente = Convert.ToInt32(retorno);
                MessageBox.Show("Cadastro Excluido Com Sucesso","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show("Não foi Possivel Excluir. Detalhes"+retorno);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmCadastroInsert Insert = new FrmCadastroInsert(Acaonatela.Inserir,null);
            DialogResult result =  Insert.ShowDialog();
            if (result == DialogResult.Yes)
            {
                AtualizarGrid();
            }
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (DgvInicio.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cadastro Selecionado.");
                return;
            }

            Cadastro cadastroselecionado = (DgvInicio.SelectedRows[0].DataBoundItem as Cadastro);

            FrmCadastroInsert Alterar = new FrmCadastroInsert(Acaonatela.Alterar, cadastroselecionado);
            DialogResult result =Alterar.ShowDialog();
            if (result == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (DgvInicio.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cadastro Selecionado.");
                return;
            }

            Cadastro cadastroselecionado = (DgvInicio.SelectedRows[0].DataBoundItem as Cadastro);
            
            FrmCadastroInsert consulta = new FrmCadastroInsert(Acaonatela.Consultar, cadastroselecionado);
            consulta.ShowDialog();
        }
    }
}
