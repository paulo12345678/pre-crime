
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
        [Required(ErrorMessage = "Estado � obrigat�rio")]
        [MaxLength(20, ErrorMessage = " Este campo s� permite 20 caracteres")]
        [MinLength(2, ErrorMessage = " Este campo deve ter no m�nimo 2 caracteres")]
        [Display(Name = " Nome do estado ")]
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        [Required(ErrorMessage = "Cidade � obrigat�rio")]
        [Display(Name = " Nome da Cidade ")]
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        [Required(ErrorMessage = "Usuario � obrigat�rio")]
        [MaxLength(50, ErrorMessage = " Este campo s� permite 20 caracteres")]
        [MinLength(10, ErrorMessage = " Este campo deve posuir no m�nimo 2 caracteres")]
        [Display(Name = " Campo Usuario ")]
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}