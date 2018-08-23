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

        public void Adicionar(TipoCrime Obj_tipo)
        {
            Obj_tipo.Id = crime.Count + 1;
            crime.Add(Obj_tipo);
        }

        public void Editar(TipoCrime Obj_tipo)
        {
            int idxs = crime.FindIndex(e => e.Id == Obj_tipo.Id);
            crime[idxs] = Obj_tipo;
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

        public TipoCrime ObterId(int? id)
        {
            return (id.HasValue) ? crime.Find(p => p.Id == id): null;
        }
    }
}
