using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Cliente : Pessoa
    {
        
        [Required, StringLength(50)]
        public String Profissao { get; set; }

        [Required, StringLength(50)]
        public String Renda { get; set; }
    }
}
