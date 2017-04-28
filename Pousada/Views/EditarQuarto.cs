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
    public partial class EditarQuarto : Form
    {
        //public int? CursoID { get; set; }
        

        public EditarQuarto()
        {
            InitializeComponent();
            
        }

        private void frmCadastroCurso_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void Alterar()
        {
            try
            {
                if (Validar())
                {
                    QuartoController qc = new QuartoController();
                    string mensagem = qc.alterarQuarto(Int32.Parse(txtID.Text), txtNumero.Text, txtCategoria.Text, txtCapacidade.Text, txtValorDiaria.Text);
                    MessageBox.Show(mensagem);
                    limpaCampos();
                }
                else
                {
                    MessageBox.Show("Todos campos são obrigatórios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO");
            }
        }

        private bool Validar()
        {
            return !(string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtNumero.Text) ||
                     string.IsNullOrEmpty(txtCategoria.Text) || string.IsNullOrEmpty(txtValorDiaria.Text) || string.IsNullOrEmpty(txtCapacidade.Text));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpaCampos()
        {
            this.txtID.Text = "";
            this.txtNumero.Text = "";
            this.txtCategoria.Text = "";
            this.txtCapacidade.Text = "";
            this.txtValorDiaria.Text = "";
        }
    }
}
