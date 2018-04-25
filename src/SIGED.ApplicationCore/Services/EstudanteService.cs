using SIGED.ApplicationCore.Entity;
using SIGED.ApplicationCore.Interfaces.Repository;
using SIGED.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SIGED.ApplicationCore.Services
{
    public class EstudanteService : IEstudanteService
    {
        private readonly IEstudanteRepository _estudanteRepository;
        public EstudanteService(IEstudanteRepository estudanteRepository)
        {
            _estudanteRepository = estudanteRepository;
        }

        public Estudante Adicionar(Estudante entity)
        {
            return _estudanteRepository.Adicionar(entity);
        }

        public void Atualizar(Estudante entity)
        {
            _estudanteRepository.Atualizar(entity);
        }

        public IEnumerable<Estudante> Buscar(Expression<Func<Estudante, bool>> predicado)
        {
            return _estudanteRepository.Buscar(predicado);
        }

        public Estudante ObterPorId(int id)
        {
            return _estudanteRepository.ObterPorId(id);
        }

        public IEnumerable<Estudante> ObterTodos()
        {
            return _estudanteRepository.ObterTodos();
        }

        public void Remover(Estudante entity)
        {
            _estudanteRepository.Remover(entity);
        }
    }
}
