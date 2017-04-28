using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Operador> Operadores { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

    }
}
