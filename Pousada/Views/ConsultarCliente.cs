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
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void frmListagemClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pousadaDataSet2.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.pousadaDataSet2.Clientes);
            CarregarGridViewClientes();
        }

        private void CarregarGridViewClientes()
        {
            
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            

        }

        private void lblListaAlunos_Click(object sender, EventArgs e)
        {

        }
    }
}
