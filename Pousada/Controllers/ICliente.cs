using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    interface ICliente
    {
        string Adicionar(string nome, string cpf, string dataNascimento, string endereco,
                              string bairro, string cidade, string estado, string ddd,
                              string telefone, string email, string profissao, string renda);


        Cliente BuscarClientePorID(int id);


        string editarCliente(int id, string nome, string cpf, string dataNascimento, string endereco,
                                    string bairro, string cidade, string estado, string ddd, string telefone,
                                    string profissao, string renda, string email);


        string ExcluirCliente(int id);
    }
}
