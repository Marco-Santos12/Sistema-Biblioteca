namespace Biblioteca.Data
{
    public class LivroRepository
    {
        private static List<Livro> _tabelaLivros = new List<Livro>();

        private static int proximoID = 1; // Variável auxiliar 

        public void Adicionar (Livro livro) //método: adiciona livros na lista
        {
          livro.Id = proximoID++;
          _tabelaLivros.Add(Livro);
        }
        
        public List<Livro> ObterTodos()
    {
        return _tabelaLivros;
    }


    }
}
