using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2E.Entities
{
    public class User
    {
        [Key]
        [StringLength(40)]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(30)]
        public string Clave { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        public int RolId { get; set; }

    }
}
