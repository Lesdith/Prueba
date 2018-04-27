using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba.Models
{
    public class RolModels
    {
        [Key]
        public int IDRol { get; set; }

        [Required (ErrorMessage = "El campo {0} es requerido")]
        [Display (Name = "Descripción")]
        public string Description { get; set; }
    }
}