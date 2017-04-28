using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    interface IQuarto
    {
        void cadastrar(string numero, string categoria, string Capacidade, string valorDiaria);

        Quarto BuscarQuartoPorID(int id);

        string alterarQuarto(int id, string numero, string categoria, string Capacidade, string valorDiaria);

        string excluirQuarto(int id);
    }
}
