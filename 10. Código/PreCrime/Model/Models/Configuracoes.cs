
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Model.Models;

/**
 * 
 */
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
        private int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        private Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}