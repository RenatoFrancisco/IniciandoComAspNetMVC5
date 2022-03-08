using System;

namespace TesteMVC5.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime Datamatricula { get; set; }
        public bool Ativo { get; set; }
    }
}