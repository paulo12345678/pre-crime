using System;
using System.Collections.Generic;
using System.Text;
using Persistence.Persistence;
using Model.Models;

namespace Business.Business
{
    public class GerenciadoraLocalizacao
    {
        private LocalizacaoPersistencia persistencia;

        public GerenciadoraLocalizacao()
        {
            persistencia = new LocalizacaoPersistencia();
        }

        public void Adicionar(Localizacao local) => persistencia.Adicionar(local);

        public void Editar(Localizacao local) => persistencia.Editar(local);

        public void Remover(int? id) => persistencia.Remover(id);

        public List<Localizacao> ObterTodos()
        {
            return persistencia.ObterTodos();
        }

        public Localizacao ObterbyId(int? id) => persistencia.ObeterbyId(id);
    }
}
