
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
        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [Required(ErrorMessage = "Email é obrigatório")]
        [Display(Name =" Campo de email ")]
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
        [Required(ErrorMessage = "Estado é obrigatório")]
        [MaxLength(20, ErrorMessage = "Este campo só permite 20 caracteris")]
        [MinLength(2, ErrorMessage = "Este campo deve posuir no mínimo 2 caracteris")]
        [Display(Name = "Campo do estado")]
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        [Required(ErrorMessage = "Cidade é obrigatório")]
        [Display(Name ="Campo da cidade")]
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