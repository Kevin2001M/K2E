using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2E.Entities
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(100)]
        public string TituloEspecialidad { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        public string SobreMi { get; set; }


        public string UrlSite { get; set; }

        public string UrlX { get; set; }

        public string UrlLink { get; set; }

        public string UrlYt { get; set; }

        public string UrlFb { get; set; }

    }
}
