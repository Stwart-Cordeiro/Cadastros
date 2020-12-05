using System;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menucadastro_Click(object sender, EventArgs e)
        {
            FrmCadastroSelecionar seleciona = new FrmCadastroSelecionar();
            seleciona.MdiParent =this;
            seleciona.Show();
        }
                  
    }
}
