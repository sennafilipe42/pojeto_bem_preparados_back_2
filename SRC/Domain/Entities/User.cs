using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class User : Base
    {
        [Required]
        [Column("USUARIO")]
        public string Usuario { get; set; }

        [Required]
        [Column("SENHA")]
        public string Senha { get; set; }

        [Required]
        [Column("NOME")]
        public string Nome { get; set; }

        [Required]
        [Column("VALIDADE_SENHA")]
        public DateTime ValidadeSenha { get; set; }

    }
}
