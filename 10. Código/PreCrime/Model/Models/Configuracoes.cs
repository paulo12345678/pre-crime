
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Model.Models;

namespace Model.Models
{
    public class Configuracoes
    {
        private int id;
        private string estado;
        private string cidade;
        private Usuario usuario;

        public Configuracoes()
        {
        }
        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [Required(ErrorMessage = "Estado é obrigatório")]
        [MaxLength(20, ErrorMessage = " Este campo só permite 20 caracteres")]
        [MinLength(2, ErrorMessage = " Este campo deve ter no mínimo 2 caracteres")]
        [Display(Name = " Nome do estado ")]
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        [Required(ErrorMessage = "Cidade é obrigatório")]
        [Display(Name = " Nome da Cidade ")]
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        [Required(ErrorMessage = "Usuario é obrigatório")]
        [MaxLength(50, ErrorMessage = " Este campo só permite 20 caracteres")]
        [MinLength(10, ErrorMessage = " Este campo deve posuir no mínimo 2 caracteres")]
        [Display(Name = " Campo Usuario ")]
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}