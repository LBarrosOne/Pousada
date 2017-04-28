using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DAL;
using Models;

namespace Controllers
{
    public class ClienteController : ICliente
    {
        public string Adicionar(string nome, string cpf, string dataNascimento, string endereco, 
                              string bairro, string cidade, string estado, string ddd, 
                              string telefone, string email, string profissao, string renda)
        {
            Cliente cli = new Cliente();
            cli.Nome = nome;
            cli.Cpf = cpf;
            cli.DataNascimento = dataNascimento;
            cli.Endereco = endereco;
            cli.Bairro = bairro;
            cli.Cidade = cidade;
            cli.Estado = estado;
            cli.DDD = ddd;
            cli.Telefone = telefone;
            cli.Email = email;
            cli.Profissao = profissao;
            cli.Renda = renda;

            using (Contexto ctx = new Contexto())
            {
                ctx.Clientes.Add(cli);
                ctx.SaveChanges();
                return "Cliente cadastrado com sucesso";
            }
        }
        
        public Cliente BuscarClientePorID(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Clientes.Find(id);
            }
        }

        public string editarCliente(int id, string nome, string cpf, string dataNascimento, string endereco,
                                    string bairro, string cidade, string estado, string ddd, string telefone, 
                                    string profissao, string renda, string email)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = nome;
            cliente.Cpf = cpf;
            cliente.DataNascimento = dataNascimento;
            cliente.Endereco = endereco;
            cliente.Bairro = bairro;
            cliente.Cidade = cidade;
            cliente.Estado = estado;
            cliente.DDD = ddd;
            cliente.Telefone = telefone;
            cliente.Profissao = profissao;
            cliente.Renda = renda;
            cliente.Email = email;

            using (Contexto ctx = new Contexto())
            {
                Cliente c = BuscarClientePorID(id);

                if (c != null)
                {
                    c.Nome = cliente.Nome;
                    c.Cpf = cliente.Cpf;
                    c.DataNascimento = cliente.DataNascimento;
                    c.Endereco = cliente.Endereco;
                    c.Bairro = cliente.Bairro;
                    c.Cidade = cliente.Cidade;
                    c.Estado = cliente.Estado;
                    c.DDD = cliente.DDD;
                    c.Telefone = cliente.Telefone;
                    c.Profissao = cliente.Profissao;
                    c.Renda = cliente.Renda;
                    c.Email = cliente.Email;


                    ctx.Entry(c).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                    return "Cliente alterado com sucesso.";
                }
                else
                {
                    return "Cliente não encontrado";
                }
            }
        }

        public string ExcluirCliente( int id)
        {
            using (Contexto ctx = new Contexto())
            {
                Cliente c = BuscarClientePorID(id);

                if (c != null)
                {
                    ctx.Entry(c).State =
                        System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();
                    return "Cliente excluido com sucesso.";
                }
                else
                {
                    return "Cliente não encontrado";
                }
            }
        }

        public static List<Cliente> retornaTodos()
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Clientes.ToList();
            }
        }

    }
}
