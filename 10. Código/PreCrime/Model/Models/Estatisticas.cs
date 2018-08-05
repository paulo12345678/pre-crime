
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class Estatisticas
    {
        private int id;
        private double percentualCrime;
        private double percentualHora;
        private int quantidade;
        private Ocorrencia ocorrencia;


        public Estatisticas()
        {
        }

        private int Id
        {
            get { return id; }
            set { id = value; }
        }

        private double Crime
        {
            get { return percentualCrime; }
            set { percentualCrime = value; }
        }

        private double Horario
        {
            get { return percentualHora; }
            set { percentualHora = value; }
        }

        private int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public Ocorrencia Ocorrencias
        {
            get { return ocorrencia; }
            set { ocorrencia = value; }
        }

}
}