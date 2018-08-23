using System.Collections.Generic;
using Model.Models;
using Persistence.Persistence;

namespace Business.Business
{
    public class GerenciadoraUsuario
    {
        public UsuarioPersistencia persistencia;

        public GerenciadoraUsuario()
        {
            persistencia = new UsuarioPersistencia();
        }

        public void Adicionar(Usuario Obj_usuario)
        {
                persistencia.Adicionar(Obj_usuario);
        }
    

        public void Editar(Usuario Obj_usuario) => persistencia.Editar(Obj_usuario);

        public void Remover(int? id) => persistencia.Remover(id);

        public List<Usuario> ExibirListaUsuarios()
        {
            return persistencia.ExibirListaUsuarios();
        }

        public Usuario ObterById(int? id) => persistencia.ObterId(id);
    }
}
