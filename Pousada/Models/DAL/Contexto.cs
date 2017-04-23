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
    }
}
