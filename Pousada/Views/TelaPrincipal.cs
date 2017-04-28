using Models;
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
            //Contexto contexto = new Contexto();
            
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCliente consultarCllientes = new ConsultarCliente();
            consultarCllientes.MdiParent = this;
            consultarCllientes.Show();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastro = new CadastrarCliente(null);
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarQuarto cc = new ConsultarQuarto();
            cc.MdiParent = this;
            cc.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarQuarto listagem = new CadastrarQuarto();
            listagem.MdiParent = this;
            listagem.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirCliente ec = new ExcluirCliente();
            ec.MdiParent = this;
            ec.Show();
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExcluirQuarto gq = new ExcluirQuarto();
            gq.MdiParent = this;
            gq.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarCliente edAluno = new EditarCliente();
            edAluno.MdiParent = this;
            edAluno.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarQuarto  ac = new EditarQuarto();
            ac.MdiParent = this;
            ac.Show();
        }

        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditarCliente ec = new EditarCliente();
            ec.MdiParent = this;
            ec.Show();
        }

        private void operadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarReserva cr = new ConsultarReserva();
            cr.MdiParent = this;
            cr.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarReserva cr = new CadastrarReserva();
            cr.MdiParent = this;
            cr.Show();

        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirReserva er = new ExcluirReserva();
            er.MdiParent = this;
            er.Show();
        }
    }
}
