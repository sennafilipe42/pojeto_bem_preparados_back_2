using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Base
    {
        [Required]
        [Column("USUARIO_ATUALIZACAO")]
        public string UsuarioAtualizacao { get; set; }

        [Required]
        [Column("DATA_ATUALIZACAO")]
        public DateTime DataAtualizacao { get; set; }
    }
}
