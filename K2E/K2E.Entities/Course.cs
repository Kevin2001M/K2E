using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2E.Entities
{
    public class Course
    {
        //(CursoId, Titulo, CategoriaId, subtitulo, fechapublicacion, descripcion, instructorid, portada)
        [Key]
        public int CursoId { get; set; }

        [Required]
        [StringLength(25)]
        public string Titulo { get; set; }

        [Required]
        public int CategoriaId { get; set; }

       [Required]
        [StringLength(50)]
        public string Subtitulo { get; set; }

        
        public DateTime FechaPublicacion { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        public int InstructorId { get; set; }

        [Required]
        public string Portada { get; set; }
    }
}
