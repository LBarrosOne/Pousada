using Controllers;
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
    public partial class CadastrarReserva : Form
    {
        public CadastrarReserva()
        {
            InitializeComponent();

            this.comboCliente.DataSource = ClienteController.retornaTodos();
            this.comboCliente.ValueMember = "id";
            this.comboCliente.DisplayMember = "Nome";
            
           // this.comboCliente.


            this.comboQuarto.DataSource = QuartoController.retornaTodos();
            this.comboQuarto.DisplayMember = "Numero";            
            this.comboQuarto.ValueMember = "QuartoID";
        }

        private void CadastrarReserva_Load(object sender, EventArgs e)
        {

        }

        private void comboQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Salvar();
        }


        private void Salvar()
        {
            try
            {
                if (validar())
                {
                    ReservaController rc = new ReservaController();

                    Object cli = comboQuarto.SelectedValue;
                    Object qua = comboQuarto.SelectedValue;
                  // MessageBox.Show("Cliente: " + cli.ToString());
                   // MessageBox.Show("Quarto: " + qua.ToString());
                    string mensagem = rc.Adicionar(Int32.Parse(cli.ToString()), Int32.Parse(qua.ToString()),
                                                   this.txtDataEntrada.Text, this.txtDataSaida.Text, 
                                                   this.txtTotalPagar.Text);
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

        private bool validar()
        {
            

            return !(string.IsNullOrEmpty(txtDataEntrada.Text) || string.IsNullOrEmpty(txtDataSaida.Text) ||
                    string.IsNullOrEmpty(txtTotalPagar.Text));
        }

        private void limpaCampos()
        {            
            this.txtDataEntrada.Text = "";
            this.txtDataSaida.Text = "";
            this.txtTotalPagar.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
