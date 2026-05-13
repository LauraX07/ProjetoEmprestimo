using ProjetoEmprestimo.Models;

namespace ProjetoEmprestimo.Repository.Contract
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> ObterTodasCategorias();
    }
}
