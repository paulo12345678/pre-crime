using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Persistence.Persistence;

namespace Business.Business
{
    public class GerenciadoraEstatisticas
    {
        public EstatisticaPersistencia persistencia;

        public GerenciadoraEstatisticas()
        {
            persistencia = new EstatisticaPersistencia();
        }

        public void Adicionar(Estatisticas obj_estatisticas)
        {
            persistencia.Adicionar(obj_estatisticas);
        }

        public void Editar(Estatisticas obj_estatisticas) => persistencia.Editar(obj_estatisticas);

        public void Remover(int? id)
        {
            persistencia.Remover(id);
        }

        public List<Estatisticas> ExibirTodos()
        {
            return persistencia.ExibirTodos();
        }

        public Estatisticas ObterById(int? id)
        {
            return persistencia.ObterId(id);
        }
    }
}
