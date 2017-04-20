using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCliente consultarCllientes = new ConsultarCliente();
            consultarCllientes.MdiParent = this;
            consultarCllientes.Show();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCliente listagem = new ConsultarCliente();
            listagem.MdiParent = this;
            listagem.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarQuarto cadCurso = new CadastrarQuarto(null);
            cadCurso.MdiParent = this;
            cadCurso.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarQuarto listagem = new ConsultarQuarto();
            listagem.MdiParent = this;
            listagem.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciarCurso edCurso = new GerenciarCurso(null);
            edCurso.MdiParent = this;
            edCurso.Show();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GerenciarCliente edAluno = new GerenciarCliente(null);
            edAluno.MdiParent = this;
            edAluno.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
