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
    public partial class ConsultarQuarto : Form
    {
        public ConsultarQuarto()
        {
            InitializeComponent();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListagemCursos_Load(object sender, EventArgs e)
        {
            CarregarGridViewCursos();
        }

        private void CarregarGridViewCursos()
        {
            
        }

        private void dgvCursos_SelectionChanged(object sender, EventArgs e)
        {
          

        }

    }
}
