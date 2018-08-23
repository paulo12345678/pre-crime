using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Persistence.Persistence
{
    public class EstatisticaPersistencia
    {
        public static List<Estatisticas> listaEstatisticas;

        static EstatisticaPersistencia()
        {
            listaEstatisticas = new List<Estatisticas>();
        }

        public void Adicionar(Estatisticas obj_estatisticas)
        {
            obj_estatisticas.Id = listaEstatisticas.Count + 1;
            listaEstatisticas.Add(obj_estatisticas);
        }

        public void Editar(Estatisticas obj_estatisticas)
        {
            int idx = listaEstatisticas.FindIndex(e => e.Id == obj_estatisticas.Id);
            listaEstatisticas[idx] = obj_estatisticas;
        }

        public void Remover(int? id)
        {
            int idx = listaEstatisticas.FindIndex(e => e.Id == id);
            listaEstatisticas.RemoveAt(idx);
        }

        public List<Estatisticas> ExibirTodos()
        {
            return listaEstatisticas;
        }

        public Estatisticas ObterId(int? id)
        {
            return (id.HasValue) ? listaEstatisticas.Find(e => e.Id == id) : null;
        }
    }
}
