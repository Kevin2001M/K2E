using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2E.Entities
{
    public class Rol
    {
        [Key]
        public int RolId { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(80)]
        public string Nombre { get; set; }
    }
}
