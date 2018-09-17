using ApplicationCore.Entity;
using ApplicationCore.Interfaces.Repository;
using ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Services
{
    public class PesquisadorService : IPesquisadorService
    {
        private readonly IPesquisadorRepository _pesquisadorRepository;
        public PesquisadorService(IPesquisadorRepository pesquisadorRepository)
        {
            _pesquisadorRepository = pesquisadorRepository;
        }

        public Pesquisador Adicionar(Pesquisador entity)
        {
            return _pesquisadorRepository.Adicionar(entity);
        }

        public void Atualizar(Pesquisador entity)
        {
            _pesquisadorRepository.Atualizar(entity);
        }

        public IEnumerable<Pesquisador> Buscar(Expression<Func<Pesquisador, bool>> predicado)
        {
            return _pesquisadorRepository.Buscar(predicado);
        }

        public Pesquisador ObterPorId(int id)
        {
            return _pesquisadorRepository.ObterPorId(id);
        }

        public IEnumerable<Pesquisador> ObterTodos()
        {
            return _pesquisadorRepository.ObterTodos();
        }

        public void Remover(Pesquisador entity)
        {
            _pesquisadorRepository.Remover(entity);
        }
    }
}
