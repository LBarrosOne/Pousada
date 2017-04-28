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
    public partial class CadastrarQuarto : Form
    {
        //public int? CursoID { get; set; }
        

        public CadastrarQuarto()
        {
            InitializeComponent();
            
        }

        private void frmCadastroCurso_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            try
            {
                if (Validar())
                {
                    QuartoController qc = new QuartoController();
                    qc.cadastrar(txtNumero.Text, txtCategoria.Text, txtCapacidade.Text, txtValorDiaria.Text);
                    MessageBox.Show("Quarto cadastrado com sucesso.");
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
            return !(string.IsNullOrEmpty(txtNumero.Text) || string.IsNullOrEmpty(txtCapacidade.Text) ||
                     string.IsNullOrEmpty(txtCategoria.Text) || string.IsNullOrEmpty(txtValorDiaria.Text));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpaCampos()
        {
            this.txtNumero.Text = "";
            this.txtCategoria.Text = "";
            this.txtCapacidade.Text = "";
            this.txtValorDiaria.Text = "";
        }
    }
}
