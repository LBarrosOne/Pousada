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

namespace Views
{
    public partial class CadastrarQuarto : Form
    {
        public int? CursoID { get; set; }
        public Curso _Curso { get; set; }

        public CadastrarQuarto(int? idCurso)
        {
            InitializeComponent();

            if (idCurso.HasValue)
                CursoID = idCurso;
        }

        private void frmCadastroCurso_Load(object sender, EventArgs e)
        {
            CarregarFormulario();
        }

        private void CarregarFormulario()
        {
            if (CursoID.HasValue)
            {
                
            }
            else
                LimparCampos();
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
            return !(string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNome.Text));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimparCampos()
        {
            CursoID = null;
            _Curso = null;
            txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            btnSalvar.Text = "Salvar";
        }
    }
}
