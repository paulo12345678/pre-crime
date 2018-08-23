
using Model.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

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

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [Required(ErrorMessage = "Data do crime é obrigatório")]
        [Display(Name = " Campo Data ")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public System.DateTime Data
        {

            get { return data; }
            set { data = value; }
        }
        [Required(ErrorMessage = "Informe a Latitude")]
        [Display(Name = " Campo Latitude ")]
        public int Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        [Required(ErrorMessage = "Informe a Longitude")]
        [Display(Name = " Campo Longitude ")]
        public int Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        [Required(ErrorMessage = "Campo Descrição Vazio")]
        [Display(Name = " Campo Descrição ")]
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        [Required(ErrorMessage = "Data do crime é obrigatório")]
        [Display(Name = " Campo Data ")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        public System.DateTime Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        [Required(ErrorMessage = "Informe o Prejuízo")]
        [DisplayFormat(DataFormatString = "{0:0,0.00}")]
        public double Prejuizo
        {
            get { return prejuizo; }
            set { prejuizo = value; }
        }

        public Usuario Usuario
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