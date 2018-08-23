
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [Required(ErrorMessage = "Informe o percentual sem o %")]
        [Display(Name = " Percentual de Crime ")]
        public double Crime
        {
            get { return percentualCrime; }
            set { percentualCrime = value; }
        }

        [Required(ErrorMessage = "Informe Apenas a hora")]
        [Range(0, 23)]
        public double Horario
        {
            get { return percentualHora; }
            set { percentualHora = value; }
        }
        [Required(ErrorMessage = "Informe a quantidade de crimes")]
        [Display(Name = " Quantidade de Crime ")]
        public int Quantidade
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