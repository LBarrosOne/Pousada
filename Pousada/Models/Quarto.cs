using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Quarto
    {
        [Key]
        public int QuartoID { get; set; }

        [Required, StringLength(5)]
        public string Numero { get; set; }

        [Required, StringLength(32)]
        public string Categoria { get; set; }

        [Required, StringLength(2)]
        public string Capacidade { get; set; }

        [Required, StringLength(10)]
        public string ValorDiaria { get; set; }

    }
}
