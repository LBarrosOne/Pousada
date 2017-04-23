using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DAL;
using Models;

namespace Controllers
{
    public class ClienteController
    {
        public void Adicionar(string nome, string cpf, string dataNascimento, string endereco, 
                              string bairro, string cidade, string estado, string ddd, 
                              string telefone, string email)
        {
            Cliente cli = new Cliente();
            cli.Nome = nome;
            cli.Cpf = cpf;
            using (Contexto ctx = new Contexto())
            {
                ctx.Clientes.Add(cli);
                ctx.SaveChanges();
            }
        }

        public void Listar()
        {

        }
        public void BuscarPorId()
        {

        }

        public void Editar()
        {

        }

        public void Excluir()
        {

        }

    }
}
