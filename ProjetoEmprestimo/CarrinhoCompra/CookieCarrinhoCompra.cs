using Newtonsoft.Json;
using ProjetoEmprestimo.Models;

namespace ProjetoEmprestimo.CarrinhoCompra
{
    public class CookieCarrinhoCompra
    {
        //criar uma chave
        private string Key = "Carrinho.Compras";
        private Cookie.Cookie _cookie;

        public CookieCarrinhoCompra(Cookie.Cookie cookie)
        {
            _cookie = cookie;
        }

        //Salvar
        public void Salvar(List<Livro> Lista)
        {
            string Valor = JsonConvert.SerializeObject(Lista);
            _cookie.Cadastrar(Key, Valor);

        }

        //Consulta
        public List<Livro> Consultar()
        {
            if (_cookie.Existe(Key))
            {
                string valor = _cookie.Consultar(Key);
                return JsonConvert.DeserializeObject<List<Livro>>(valor); 
            }
            else
            {
                return new List<Livro>();
            }
        }
    }
}
