
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model.Models
{

    public class Usuario
    {
        public int id;
        public String email;
        public string senha;
        public string estado;
        public string cidade;
        public List<Ocorrencia> ocorrencia;
        public List<Configuracoes> configuracao;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [Required(ErrorMessage = "Senha é Obrigatório")]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "A senha deve conter entre 6 e 16 digitos")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public List<Ocorrencia> Ocorrencias
        {
            get { return ocorrencia; }
            set { ocorrencia = value; }
        }
        public List<Configuracoes> Configuracao
        {
            get { return configuracao; }
            set { configuracao = value; }
        }

    }
}