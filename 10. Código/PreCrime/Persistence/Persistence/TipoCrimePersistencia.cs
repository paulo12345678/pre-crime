using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Persistence.Persistence
{
    public  class TipoCrimePersistencia
    {
        public static  List<TipoCrime> crime;
        static TipoCrimePersistencia()
        {
            crime = new List<TipoCrime>();
        }

        public void Adicionar(TipoCrime Tipo )
        {
            Tipo.Id = crime.Count + 1;
            crime.Add(Tipo);
        }

        public void Editar(TipoCrime Tipo2)
        {
            int idxs = crime.FindIndex(e => e.Id == Tipo2.Id);
            crime[idxs] = Tipo2;
        }

        public void Remover (int? id)
        {
            int idxs = crime.FindIndex(e => e.Id == id);
            crime.RemoveAt(idxs);
        }

        public List<TipoCrime> ObterTodos()
        {
            return crime;
        }

        public TipoCrime Detalhes(TipoCrime Tipo3)
        {
            return Tipo3;
        }

        public TipoCrime ObterId(int? id)
        {
            return (id.HasValue) ? crime.Find(p => p.Id == id): null;
        }
    }
}
