using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2E.Entities
{
    public class Comment
    {
        //(ComentarioId, CursoId, email, Mensaje, fecha)
        [Key] public int ComentarioId { get; set; }

        [Required]
        public int CursoId { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Mensaje { get; set; }

        [Required]
        public DateTime Fecha { get; set; }
    }
}
