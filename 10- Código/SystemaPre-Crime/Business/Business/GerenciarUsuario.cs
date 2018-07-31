using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Persistence.Persistence;

namespace Business.Business
{
    public class GerenciarUsuario
    {
        public UsuarioPersistencia persistencia;

        public GerenciarUsuario()
        {
            persistencia = new UsuarioPersistencia();
        }

        public void Adicionar(Usuario u)
        {
                persistencia.Adicionar(u);
        }
    

        public void Editar(Usuario u) => persistencia.Editar(u);

        public void Remover(int? id) => persistencia.Remover(id);

        public List<Usuario> ExibirListaUsuarios()
        {
            return persistencia.ExibirListaUsuarios();
        }

        public Usuario ObterById(int? id) => persistencia.ObterId(id);
    }
}
