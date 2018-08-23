using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Persistence.Persistence
{
    public class LocalizacaoPersistencia
    {
        private static List<Localizacao> ponto;

        static LocalizacaoPersistencia()
        {
            ponto = new List<Localizacao>();
        }

        public void Adicionar(Localizacao obj_local)
        {
            obj_local.Id = ponto.Count + 1;
            ponto.Add(obj_local);
        }

        public void Editar(Localizacao obj_local)
        {
            int idx = ponto.FindIndex(x => x.Id == obj_local.Id);
            ponto[idx] = obj_local;
        }

        public void Remover(int ? id)
        {
            int idx = ponto.FindIndex(x=>x.Id==id);
            ponto.RemoveAt(idx);
        }

        public List<Localizacao> ObterTodos()
        {
            return ponto;
        }

        public Localizacao ObeterbyId (int?id)
        {
            return (id.HasValue) ? ponto.Find(x => x.Id == id) : null;
        }
    }
}
