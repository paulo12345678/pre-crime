
using Model.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class Ocorrencia
    {

        private int id;
        private System.DateTime data;
        private int latitude;
        private int longitude;
        private string descricao;
        private System.DateTime hora;
        private double prejuizo;
        private Usuario usuario;
        private TipoCrime tipodecrime;
        private Estatisticas estatisticas;
        private Localizacao localizacao;
        private ObjetosFurtados objetosFurtados;


        public Ocorrencia()
        {
        }

        private int Id
        {
            get { return id; }
            set { id = value; }
        }

        private System.DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        private int Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        private int Longitud
        {
            get { return longitude; }
            set { longitude = value; }
        }

        private string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private System.DateTime Hora
        {
            get { return hora; }
            set { hora = value; }
        }


        private double Prejuizo
        {
            get { return prejuizo; }
            set { prejuizo = value; }
        }

        private Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public TipoCrime TipoDeCrime
        {
            get { return tipodecrime; }
            set { tipodecrime = value; }
        }

        public Estatisticas Estatistica
        {
            get { return estatisticas; }
            set { estatisticas = value; }
        }

        public Localizacao Localizacoes
        {
            get { return localizacao; }
            set { localizacao = value; }
        }

        public ObjetosFurtados ObjetoFurtado
        {
            get { return objetosFurtados; }
            set { objetosFurtados = value; }
        }
    }
}