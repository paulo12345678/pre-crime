using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Adicionar(Usuario u)
        {
            u.Id = usuario.Count + 1;
            usuario.Add(u);
        }

        public void Editar(Usuario u)
        {
            int idx = usuario.FindIndex(e => e.Id == u.Id);
            usuario[idx] = u;
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

        public Usuario Detalhes(Usuario u)
        {

            return u;
        }

        public Usuario ObterId(int? id)
        {
            return (id.HasValue) ? usuario.Find(p => p.Id == id) : null;
        }
    }
}
