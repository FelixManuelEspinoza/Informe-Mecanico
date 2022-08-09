using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformeBD.entidades
{
    [Index (nameof(DNI), Name= "Numero de DNI", IsUnique = true)]
    public class Cliente
    {
       
        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "campo obligatorio")]
        [MaxLength(20, ErrorMessage = "Este dato no puede tener mas de {1} caracteres")]
        public string DNI { get; set; } 

    }
}
