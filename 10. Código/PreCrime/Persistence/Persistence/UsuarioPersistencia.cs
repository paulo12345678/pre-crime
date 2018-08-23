using System.Collections.Generic;
using Model.Models;

namespace Persistence.Persistence
{
    public class UsuarioPersistencia
    {
        public static List<Usuario> usuario;

        static UsuarioPersistencia()
        {
            usuario = new List<Usuario>();
        }

        public void Adicionar(Usuario Obj_usuario)
        {
            Obj_usuario.Id = usuario.Count + 1;
            usuario.Add(Obj_usuario);
        }

        public void Editar(Usuario Obj_usuario)
        {
            int idx = usuario.FindIndex(e => e.Id == Obj_usuario.Id);
            usuario[idx] = Obj_usuario;
        }

        public void Remover(int? id)
        {
            int idx = usuario.FindIndex(e => e.Id == id);
            usuario.RemoveAt(idx);
        }

        public List<Usuario> ExibirListaUsuarios()
        {
            return usuario;
        }

        public Usuario ObterId(int? id)
        {
            return (id.HasValue) ? usuario.Find(p => p.Id == id) : null;
        }
    }
}
