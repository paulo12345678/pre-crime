
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace Model.Models
{
    public class Localizacao
    {
        private int id;
        private int latitude;
        private int longitude;
        private Ocorrencia ocorrencia;

        public Localizacao()
        {
        }
        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [Required(ErrorMessage = "Latitude  Obrigatorio")]
        [Display(Name = " Latitude ")]
        public int Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }
        [Required(ErrorMessage = "Longitude Obrigatorio")]
        [Display(Name = " Longitude ")]
        public int Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        public Ocorrencia Ocorrencias
        {
            get { return ocorrencia; }
            set { ocorrencia = value; }
        }

}
}