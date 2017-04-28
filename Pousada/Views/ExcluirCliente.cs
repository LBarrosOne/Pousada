using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Controllers;

namespace Views
{
    public partial class ExcluirCliente : Form
    {


        public ExcluirCliente()
        {
            InitializeComponent();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ClienteController cc = new ClienteController();
            //MessageBox.Show("ID:" + textID.Text);
            string mensagem = "";
            try
            {
                mensagem = cc.ExcluirCliente(Int32.Parse(txtID.Text));
                MessageBox.Show(mensagem);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO");
            }
        }
    }
}
