using Model.Models;
using System.Collections.Generic;

namespace Persistence.Persistence
{
    public class ConfiguracoesPersitencia
    {
        private static List<Configuracoes> configuracoes;

        static ConfiguracoesPersitencia()
        {
            if (configuracoes == null)
                configuracoes = new List<Configuracoes>();
        }

        public void Adicionar( Configuracoes obj_config)
        {
            obj_config.Id = configuracoes.Count + 1;
            configuracoes.Add(obj_config);
        }
        public void Editar(Configuracoes obj_config)
        {
            int idx = configuracoes.FindIndex(e => e.Id == obj_config.Id);
            configuracoes[idx] = obj_config;
        }

        public void Remover(int? id)
        {
            int idx = configuracoes.FindIndex(e => e.Id == id);
            configuracoes.RemoveAt(idx);
        }

        public List<Configuracoes> ObterTodos()
        {
            return configuracoes;
        }

        public Configuracoes ObterById(int? id)
        {
            return (id.HasValue) ? configuracoes.Find(p => p.Id == id) : null;
        }

    }
}
