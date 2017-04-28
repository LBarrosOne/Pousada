using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Operador : Pessoa
    {
        [Required, StringLength(8)]
        public String Matricula { get; set; }

        [Required, StringLength(10)]
        public String Salario { get; set; }

        [Required, StringLength(10)]
        public String DataAdmissao { get; set; }
    }
}
