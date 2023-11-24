using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2E.Entities
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(60)]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        public string Nacionalidad { get; set; }
    }
}
