using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Prueba.Models
{
    public class UserModels
    {
        [Key]
        public int IDUser { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(255, ErrorMessage = "Debe contener entre 8 caracteres", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "Fecha de Modificación de la Contraseña")]
        public DateTime ModificationDatePassword { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(255, ErrorMessage = "Debe contener entre 8 y 25 caracteres", MinimumLength = 8)]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-.]+$", ErrorMessage = "Debe ser un correo electronico valido")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Correo Electronico")]
        [Index("UserModels_Email_Index", IsUnique = true)]
        public int email { get; set; }

        public virtual ICollection<RolModels> Rols { get; set; }
    }
}