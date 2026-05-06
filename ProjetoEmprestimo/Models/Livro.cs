using System.ComponentModel;

namespace ProjetoEmprestimo.Models
{
    public class Livro
    {
        public int codLivro { get; set; }

        [DisplayName("Nome do Livro")]
        public string nomeLivro { get; set; }
        public string imagemLivro { get; set; }
        public int quantidade { get; set; }

    }
}
