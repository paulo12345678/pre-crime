using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Persistence.Persistence
{
   public class OcorenciaPercistencia
    {
        private static List<Ocorrencia> listaOcorrencia;

        static OcorenciaPercistencia()
        {
            listaOcorrencia = new List<Ocorrencia>();
        }

        public void Adicionar(Ocorrencia obj_ocorrencia)
        {
            obj_ocorrencia.Id = listaOcorrencia.Count + 1;
            listaOcorrencia.Add(obj_ocorrencia);
        }

        public void Editar(Ocorrencia obj_ocorrencia)
        {
            int idx = listaOcorrencia.FindIndex(e => e.Id == obj_ocorrencia.Id);
            listaOcorrencia[idx] = obj_ocorrencia;
        }

        public void Remover(int? id)
        {
            int idx = listaOcorrencia.FindIndex(e => e.Id == id);
            listaOcorrencia.RemoveAt(idx);
        }

        public List<Ocorrencia> ObterTodos()
        {
            return listaOcorrencia;
        }

        public Ocorrencia ObterId(int? id)
        {
            return (id.HasValue) ? listaOcorrencia.Find(o => o.Id == id) : null;
        }
    }
}
