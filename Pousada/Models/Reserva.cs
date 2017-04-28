using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Reserva
    {
        [Key]
        public int ReservaId { get; set; }
        
        public Cliente Cliente { get; set; }

        public Quarto Quarto { get; set; }

        public string DataEntrada { get; set; }

        public string DataSaida { get; set; }

        public float ValorTotal { get; set; }



    }
}
