using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.DAL;

namespace Controllers
{
    public class QuartoController
    {
        public void cadastrar(string numero, string categoria, string Capacidade, string valorDiaria)
        {
            Quarto quarto = new Quarto();
            quarto.Numero = numero;
            quarto.Categoria = categoria;
            quarto.Capacidade = Capacidade;
            quarto.ValorDiaria = valorDiaria;

            using (Contexto ctx = new Contexto())
            {
                ctx.Quartos.Add(quarto);
                ctx.SaveChanges();
            }
        }

        public Quarto BuscarQuartoPorID(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Quartos.Find(id);
            }
        }

        public string alterarQuarto(int id, string numero, string categoria, string Capacidade, string valorDiaria)
        {
            Quarto quarto = new Quarto();
            quarto.Numero = numero;
            quarto.Categoria = categoria;
            quarto.Capacidade = Capacidade;
            quarto.ValorDiaria = valorDiaria;

            using (Contexto ctx = new Contexto())
            {
                Quarto q = BuscarQuartoPorID(id);

                if (q != null)
                {
                    q.Numero = quarto.Numero;
                    q.Categoria = quarto.Categoria;
                    q.Capacidade = quarto.Capacidade;
                    q.ValorDiaria = quarto.ValorDiaria;

                    ctx.Entry(q).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                    return "Quarto alterado com sucesso.";
                }
                else
                {
                    return "Quarto nao encontrado";
                }
            }
        }

        public string excluirQuarto(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                Quarto q = BuscarQuartoPorID(id);

                if (q != null)
                {
                    ctx.Entry(q).State =
                        System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();
                    return "Quarto excluido com sucesso.";
                }
                else
                {
                    return "Quarto nao encontrado";
                }
            }
        }

        public static List<Quarto> retornaTodos()
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Quartos.ToList();
            }
        }
    }
}
