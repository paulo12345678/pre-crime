using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Persistence.Persistence;

namespace Business.Business
{
    public class GerenciarTipoCrime
    {
        public TipoCrimePersistencia persistencia;

        public GerenciarTipoCrime ()
        {
            persistencia = new TipoCrimePersistencia();
        }

        public void Adicionar (TipoCrime Crime  )
        {
            persistencia.Adicionar(Crime);
        }
        public void Editar(TipoCrime Crime) => persistencia.Editar(Crime);
        public void Remove(int? id) => persistencia.Remover(id);
        public List<TipoCrime> ObterTodos()
        {
            return persistencia.ObterTodos();
        }
        public TipoCrime ObterById(int? id) => persistencia.ObterId(id);
    }
}
