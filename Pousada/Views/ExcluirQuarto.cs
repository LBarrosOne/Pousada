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
    public partial class ExcluirQuarto : Form
    {

        //public Aluno _Aluno { get; set; }

        public ExcluirQuarto()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuartoController qc = new QuartoController();
            try
            {
                qc.BuscarQuartoPorID(Int32.Parse(textID.Text));
                MessageBox.Show("Consulta Realizada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuartoController qc = new QuartoController();
            //MessageBox.Show("ID:" + textID.Text);
            string mensagem = "";
            try
            {
                mensagem = qc.excluirQuarto(Int32.Parse(textID.Text));
                MessageBox.Show(mensagem);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO");
            }

        }
    }
}
