using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechStore.Models
{
    public class FormProducto
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del Producto")]
        [Required]
        public string? Nombre { get; set; }

        [Display(Name = "Descripcion")]
        [Required]
        public string? Descripcion { get; set; }

        
        [Display(Name = "Precio de Producto")]
        [Required]
        public Double? Precio { get; set; }

       
    }
}