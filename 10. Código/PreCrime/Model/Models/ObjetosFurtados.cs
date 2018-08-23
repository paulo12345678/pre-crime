
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

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
        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Required(ErrorMessage = "O tipo de Objeto é obrigatório")]
        [Display(Name = "Objeto Furtado")]
        public string Descricao
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