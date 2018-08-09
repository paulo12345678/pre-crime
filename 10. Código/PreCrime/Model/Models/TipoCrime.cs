
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

        public TipoCrime()
        {
        }
        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [Required(ErrorMessage = "Tipo Do Crime Obrigatorio")]
        [Display(Name = " Tipo Do Crime ")]
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

    }
}