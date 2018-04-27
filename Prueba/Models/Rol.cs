using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba.Models
{
    [Table ("tbl_Rols")]
    public class Rol
    {
        [Key]
        public int IDRol { get; set; }

        [Required (ErrorMessage = "El campo {0} es requerido")]
        [Display (Name = "Descripción")]
        public string Description { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<RolPermission> RolPermissions { get; set; }
    }
}