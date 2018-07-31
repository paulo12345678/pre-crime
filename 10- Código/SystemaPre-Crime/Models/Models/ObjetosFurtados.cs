
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class ObjetosFurtados
    {
        private int id;
        private string descricao;
        private Ocorrencia ocorrencia;

        public ObjetosFurtados()
        {
        }

        private int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public Ocorrencia Ocorrencias
        {
            get { return ocorrencia; }
            set { ocorrencia = value; }
        }
    }

}