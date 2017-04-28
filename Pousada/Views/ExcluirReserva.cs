using Controllers;
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
    public partial class ExcluirReserva : Form
    {
        public ExcluirReserva()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ReservaController qc = new ReservaController();
            string mensagem = "";
            try
            {
                mensagem = qc.ExcluirReserva(Int32.Parse(txtId.Text));
                MessageBox.Show(mensagem);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO");
            }
        }
    }
}
