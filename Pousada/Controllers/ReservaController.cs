using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.DAL;

namespace Controllers
{
    public class ReservaController
    {
        public string Adicionar(int cliente, int quarto, string dataEntrada, string dataSaida, string total)
        {
            Reserva re = new Reserva();

            ClienteController cc = new ClienteController();
            QuartoController qc = new QuartoController();

            re.Cliente = cc.BuscarClientePorID(cliente);
            re.Quarto = qc.BuscarQuartoPorID(quarto);
            re.DataEntrada = dataEntrada;
            re.DataSaida = dataSaida;
            re.ValorTotal = float.Parse(total);

            using (Contexto ctx = new Contexto())
            {
                ctx.Reservas.Add(re);
                ctx.SaveChanges();
                return "Reserva efetuada com sucesso.";
            }
        }

        public string ExcluirReserva(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                Reserva r = BuscarReservaPorID(id);

                if (r != null)
                {
                    ctx.Entry(r).State =
                        System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();
                    return "Reserva excluida com sucesso.";
                }
                else
                {
                    return "Reserva não encontrada";
                }
            }
        }

        public Reserva BuscarReservaPorID(int id)
        {
            using (Contexto ctx = new Contexto())
            {
                return ctx.Reservas.Find(id);
            }
        }
    }
}
