using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AppCatalogoJogos.Entities;

namespace AppCatalogoJogos.Repositorios
{
    public interface IJogoRepository : IDisposable
    {
        Task<List<Jogo>> Obter(int pagina, int quantidade);
        Task<Jogo> Obter(Guid id);
        Task<List<Jogo>> Obter(string nome, string produtora);
        Task Inserir(Jogo jogo);
        Task Atualizar(Jogo jogo);
        Task Remover(Guid id);
        
    }
}