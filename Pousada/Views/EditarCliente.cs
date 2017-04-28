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
    public partial class EditarCliente : Form
    {

        public int? AlunoID { get; set; }
        //public Aluno _Aluno { get; set; }

        public EditarCliente()
        {
            InitializeComponent();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void editar()
        {
            try
            {
                if (Validar())
                {
                    ClienteController cc = new ClienteController();
                    string mensagem = cc.editarCliente(Int32.Parse(txtId.Text), txtNome.Text, txtCpf.Text,
                                        txtDataNascimento.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtEstado.Text,
                                        txtDDD.Text, txtTelefone.Text, txtProfissao.Text, txtRenda.Text, txtEmail.Text);
                    MessageBox.Show(mensagem);
                    LimparCampos();
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
            return !(string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNome.Text) ||
                     string.IsNullOrEmpty(txtCpf.Text) || string.IsNullOrEmpty(txtDataNascimento.Text) ||
                     string.IsNullOrEmpty(txtEndereco.Text) || string.IsNullOrEmpty(txtBairro.Text) ||
                     string.IsNullOrEmpty(txtCidade.Text) || string.IsNullOrEmpty(txtEstado.Text) ||
                     string.IsNullOrEmpty(txtDDD.Text) || string.IsNullOrEmpty(txtTelefone.Text) ||
                     string.IsNullOrEmpty(txtProfissao.Text) || string.IsNullOrEmpty(txtRenda.Text) ||
                     string.IsNullOrEmpty(txtEmail.Text));
        }

        public void LimparCampos()
        {         
            this.txtId.Text = "";
            this.txtNome.Text = "";
            this.txtCpf.Text = "";
            this.txtDataNascimento.Text = "";
            this.txtEndereco.Text = "";
            this.txtBairro.Text = "";
            this.txtCidade.Text = "";
            this.txtEstado.Text = "";
            this.txtDDD.Text = "";
            this.txtTelefone.Text = "";
            this.txtProfissao.Text = "";
            this.txtRenda.Text = "";
            this.txtEmail.Text = "";           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
