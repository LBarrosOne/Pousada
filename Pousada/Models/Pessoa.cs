using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public String Nome { get; set; }

        [Required, StringLength(50)]
        public String Cpf { get; set; }

        [Required, StringLength(50)]
        public String DataNascimento { get; set; }

        [Required, StringLength(50)]
        public String Endereco { get; set; }

        [Required, StringLength(50)]
        public String Bairro { get; set; }

        [Required, StringLength(50)]
        public String Cidade { get; set; }

        [Required, StringLength(50)]
        public String Estado { get; set; }

        [Required, StringLength(50)]
        public String DDD { get; set; }

        [Required, StringLength(50)]
        public String Telefone { get; set; }

        [Required, StringLength(50)]
        public String Email { get; set; }
    }
}
