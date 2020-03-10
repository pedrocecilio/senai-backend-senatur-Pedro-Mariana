using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "O título do tipo de usuário é obrigatório!")]
        public string Titulo { get; set; }

        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
