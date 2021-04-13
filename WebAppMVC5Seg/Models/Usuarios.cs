using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVC5Seg.Models
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Ingrese un nombre de usuario")]
        [MinLength(5, ErrorMessage = "Escriba al menos 5 caracteres")]
        public string Nombre { get; set; }
        public string Sal { get; set; }
        public string Clave { get; set; }

    }
}
