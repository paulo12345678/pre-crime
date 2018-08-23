using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Persistence.Persistence;

namespace Business.Business
{
    public class GerenciadoraObjetosRoubados
    {
        public ObjetosFurtadosPersistencia persistencia;

        public GerenciadoraObjetosRoubados()
        {
            persistencia = new ObjetosFurtadosPersistencia();
        }

        public void Adicionar(ObjetosFurtados obj_objetosFurtados)
        {
            persistencia.Adicinar(obj_objetosFurtados);
        }

        public void Editar(ObjetosFurtados obj_objetosFurtados)
        {
            persistencia.Editar(obj_objetosFurtados);
        }

        public void Remover(int? id)
        {
            persistencia.Remover(id);
        }

        public List<ObjetosFurtados> ObterTodos()
        {
            return persistencia.ObterTodos();
        }



        public ObjetosFurtados ObterById(int? id)
        {
            return persistencia.ObterById(id);
        }
    }
}
