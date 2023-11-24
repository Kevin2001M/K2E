using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2E.Entities
{
    public class Chapter
    {
        //CapituloId, Nombre, cantidadtitulo, tiempo, cursoid)
        [Key]

        public int CapituloId { get; set; }


        [Required(ErrorMessage = "El campo es requerido")]
        public string Nombre { get; set;}

        
        [Required(ErrorMessage = "El campo es requerido")]
        public int CantidadTitulo { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        public DateTime Tiempo { get; set; }

        [Required]
        public int CursoId { get; set; }
    }
}
