using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Persistence.Persistence;

namespace Business.Business
{
    public class GerenciadoraOcorrencia
    {
        public OcorenciaPercistencia percistencia;

        public GerenciadoraOcorrencia()
        {
            percistencia = new OcorenciaPercistencia();
        }

        public void Adicionar(Ocorrencia obj_ocorrencia)
        {
            percistencia.Adicionar(obj_ocorrencia);
        }

        public void Editar(Ocorrencia obj_ocorrencia)
        {
            percistencia.Editar(obj_ocorrencia);
        }

        public void Remover(int? id)
        {
            percistencia.Remover(id);
        }

        public List<Ocorrencia> ObterTodos()
        {
            return percistencia.ObterTodos();
        }

        public Ocorrencia ObterById(int? id)
        {
            return percistencia.ObterId(id);
        }
    }
}
