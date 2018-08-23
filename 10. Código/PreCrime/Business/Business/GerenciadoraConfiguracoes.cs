using System;
using System.Collections.Generic;
using Model.Models;
using Persistence.Persistence;

namespace Business.Business
{
    public class GerenciadoraConfiguracoes
    {
        private ConfiguracoesPersitencia persistencia;

        public GerenciadoraConfiguracoes()
        {
            persistencia = new ConfiguracoesPersitencia();
        }

        public void Adicionar(Configuracoes p) => persistencia.Adicionar(p);

        public void Editar(Configuracoes p) => persistencia.Editar(p);

        public void Remover(int? id) => persistencia.Remover(id);

        public List<Configuracoes> ObterTodos()
        {
            return persistencia.ObterTodos();
        }

        public Configuracoes ObterById(int? id) => persistencia.ObterById(id);
    }
}
