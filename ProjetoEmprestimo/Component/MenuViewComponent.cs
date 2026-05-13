using Microsoft.AspNetCore.Mvc;
using ProjetoEmprestimo.Repository.Contract;

namespace ProjetoEmprestimo.Component
{
    public class MenuViewComponent : ViewComponent
    {
        private ICategoriaRepository _categoriarepository;
        public MenuViewComponent(ICategoriaRepository categoriaRepository)
        {
            _categoriarepository = categoriaRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var ListaCategoria = _categoriarepository.ObterTodasCategorias().ToList();  
            return View(ListaCategoria);
        }
    }
}
