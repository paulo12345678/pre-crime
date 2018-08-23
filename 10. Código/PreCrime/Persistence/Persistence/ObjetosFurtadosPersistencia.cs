using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Persistence.Persistence
{
    public class ObjetosFurtadosPersistencia
    {
        private static List<ObjetosFurtados> listaObjetosFurtados;

        static ObjetosFurtadosPersistencia()
        {
            listaObjetosFurtados = new List<ObjetosFurtados>();
        }

        public void Adicinar(ObjetosFurtados obj_ObjetoFutados)
        {
            obj_ObjetoFutados.Id = listaObjetosFurtados.Count + 1;
            listaObjetosFurtados.Add(obj_ObjetoFutados);
        }

        public void Editar(ObjetosFurtados obj_objetosFurtados)
        {
            int idx = listaObjetosFurtados.FindIndex(e => e.Id == obj_objetosFurtados.Id);
            listaObjetosFurtados[idx] = obj_objetosFurtados;
        }

        public void Remover(int? id)
        {
            int idx = listaObjetosFurtados.FindIndex(e => e.Id == id);
            listaObjetosFurtados.RemoveAt(idx);
        }

        public List<ObjetosFurtados> ObterTodos()
        {
            return listaObjetosFurtados;
        }

        public ObjetosFurtados ObterById(int? id)
        {
            return (id.HasValue) ? listaObjetosFurtados.Find(e => e.Id == id) : null;
        }
    }
}
