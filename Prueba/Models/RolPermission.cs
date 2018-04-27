﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    [Table("tbl_RolPermissions")]
    public class RolPermission
    {
        [Key]
        public int IDPermission { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Rol:")]
        public int IDRol { get; set; }

        [Display(Name = "¿Puede ver?")]
        public bool CanSee { get; set; }

        [Display(Name = "¿Puede modificar?")]
        public bool CanModify { get; set; }

        [Display(Name = "¿Puede borrar?")]
        public bool CanErase { get; set; }

        public virtual Rol Rol { get; set; }
    }
}