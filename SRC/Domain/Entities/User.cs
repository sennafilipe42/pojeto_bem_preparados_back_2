using System;

namespace Domain.Entities
{
    public class User : Base
    {
        public string Usuario { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }

        public DateTime ValidadeSenha { get; set; }

    }
}
