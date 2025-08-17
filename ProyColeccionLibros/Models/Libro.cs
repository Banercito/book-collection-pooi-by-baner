using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyColeccionLibros.Models;
using System.ComponentModel.DataAnnotations;

namespace ProyColeccionLibros.Models
{
    public class Libro
    {
        [Required]
        [Range(1001, 2000)]    
        public int IdLibro { get; set; }
        
        [Required]
        public string NombreLibro { get; set; }
        
        [Required]
        public double Precio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true,
           DataFormatString ="{0:yyyy-MM-dd}" )]
        public DateTime FechaImpresion { get; set; }

        public bool EsNuevo { get; set; }
    }
}