using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2E.Entities
{
    public class Title
    {
        //itulos (TituloId, Nombre, tiempo, CapituloId)
        [Key] public int TituloId { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(50)]
        public string Nombre { get; set; }
        
        
        [Required]
        public DateTime Tiempo { get; set; } 
        
        
        [Required]
        public int CapituloId { get; set; }


    }
}
