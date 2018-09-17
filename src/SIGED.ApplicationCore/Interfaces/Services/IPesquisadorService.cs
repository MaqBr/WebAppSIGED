using ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Interfaces.Services
{
    public interface IPesquisadorService
    {
        Pesquisador Adicionar(Pesquisador entity);
        void Atualizar(Pesquisador entity);
        IEnumerable<Pesquisador> ObterTodos();
        Pesquisador ObterPorId(int id);
        IEnumerable<Pesquisador> Buscar(Expression<Func<Pesquisador, bool>> predicado);
        void Remover(Pesquisador entity);
    }
}
