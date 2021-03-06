﻿using System;
using System.Windows.Forms;
using Models;
using Controllers;


namespace Views
{
    public partial class CadastrarCliente : Form
    {
        public int? ClienteID { get; set; }
        public Cliente Cliente { get; set; }

        public CadastrarCliente(int? idAluno)
        {
            InitializeComponent();

            if (idAluno.HasValue) {
                //AlunoID = idAluno;
            }
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            CarregarFormulario();

        }

        private void CarregarFormulario()
        {
            
        }

        public void LimparCampos()
        {
            //AlunoID = null;
            //_Aluno = null;
            txtNome.Clear();
            txtCpf.Clear();
            btnSalvar.Text = "Salvar";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }     

        private bool Validar()
        {
            return !(string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCpf.Text));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCncelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            try
            {
                if (validar())
                {
                    ClienteController cc = new ClienteController();

                    string mensagem = cc.Adicionar(txtNome.Text, txtCpf.Text, tbDataNascimento.Text, tbEndereco.Text, tbBairro.Text,
                                    tbCidade.Text, tbEstado.Text, tbDDD.Text, tbTelefone.Text, tbEmail.Text, tbProfissao.Text,
                                    tbRenda.Text);
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
            return !(string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCpf.Text) ||
                    string.IsNullOrEmpty(tbDataNascimento.Text) || string.IsNullOrEmpty(tbEndereco.Text) ||
                    string.IsNullOrEmpty(tbBairro.Text) || string.IsNullOrEmpty(tbEstado.Text) ||
                    string.IsNullOrEmpty(tbDDD.Text) || string.IsNullOrEmpty(tbTelefone.Text) ||
                    string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbCidade.Text) ||
                    string.IsNullOrEmpty(tbProfissao.Text) || string.IsNullOrEmpty(tbRenda.Text));
        }

        private void limpaCampos()
        {
            this.txtNome.Text = "";
            this.txtCpf.Text = "";
            this.tbDataNascimento.Text = "";
            this.tbEndereco.Text = "";
            this.tbBairro.Text = "";
            this.tbEstado.Text = "";
            this.tbDDD.Text = "";
            this.tbTelefone.Text = "";
            this.tbEmail.Text = "";
            this.tbCidade.Text = "";
            this.tbProfissao.Text = "";
            this.tbRenda.Text = "";
        }
    }
}
