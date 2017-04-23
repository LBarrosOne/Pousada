using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public String Nome{ get; set; }

        [Required, StringLength(11)]
        public String Cpf { get; set; }

        [Required, StringLength(8)]
        public String DataNascimento { get; set; }

        [Required, StringLength(100)]
        public String Endereco { get; set; }

        [Required, StringLength(32)]
        public String Bairro { get; set; }

        [Required, StringLength(32)]
        public String Cidade { get; set; }

        [Required, StringLength(32)]
        public String Estado { get; set; }

        [Required, StringLength(3)]
        public String DDD { get; set; }

        [Required, StringLength(9)]
        public String Telefone { get; set; }

        [Required, StringLength(32)]
        public String Email { get; set; }
    }
}
