
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    public class TipoCrime
    {
        private int id;
        private string tipo;
        private Ocorrencia ocorrencia;

        public TipoCrime()
        {
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Ocorrencia Ocorrencias
        {
            get { return ocorrencia; }
            set { ocorrencia = value; }
        }

}
}