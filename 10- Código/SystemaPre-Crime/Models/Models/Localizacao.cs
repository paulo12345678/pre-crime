
using System;
using System.Collections.Generic;
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

        private int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        private int Longitude
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